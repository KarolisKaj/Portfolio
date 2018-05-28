namespace Portfolio.DataStore

open Raven.Client.Documents
open Portfolio.DataStore.Model
open System.Security.Cryptography.X509Certificates

module DataStore =
    open Raven.Client.Documents.Operations.Attachments
    open Raven.Client.Documents.Attachments
    open System.IO
    open System

    let certificate = new X509Certificate2("C:\\RavenDB\\Clusters\\Portfolio\\A\\cluster.server.certificate.portfolio.pfx")
    let hosts = [|"https://a.portfolio.ravendb.community:44300"|]
    let dbName = "Portfolio"

    let getStore urls db cert = 
        let store = new DocumentStore (Urls = urls, Database = db, Certificate = cert)
        store.Initialize()

    let getSession (store : IDocumentStore) =
        store.OpenSession()

    let initConnection =
        let store = getStore hosts dbName certificate
        (getSession store, store)
        
    let GetArticle id = 
        let session, _ = initConnection
        try
            (query {
                for article in session.Query<Article>() do
                where (article.id = id)
                select article
            } |> Seq.toArray)
        finally 
            session.Dispose() |> ignore

    let GetArticles () = 
        let session, store = initConnection
        try
            try
                let articles = (session.Query<Article>() |> Seq.toArray)
                for article in articles do
                    use attachment = store.Operations.Send(new GetAttachmentOperation(article.id, article.images.[0], AttachmentType.Document, null))
                    use memStr = new MemoryStream()
                    attachment.Stream.CopyTo(memStr)
                    article.attachment <-  memStr.ToArray()
                articles
            with
                ex -> 
                reraise()
        finally 
            session.Dispose() |> ignore
            store.Dispose() |> ignore

    let GetArticleBody id = 
        let session, _ = initConnection
        try
            try
                (query {
                for articleBody in session.Query<ArticlesBody>() do
                where (articleBody.Id = id)
                select articleBody
                } |> Seq.take 1)
            with
                ex -> 
                reraise()
        finally 
            session.Dispose() |> ignore

    let StoreMessage message =
        let session, _ = initConnection
        try
            try
                session.Store({ name = message.name; email= message.email; message = message.message }, null)
                session.SaveChanges()
            with
                ex -> 
                reraise()
        finally 
            session.Dispose() |> ignore
