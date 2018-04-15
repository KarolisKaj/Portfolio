namespace Portfolio.DataStore

open Raven.Client.Documents
open Model
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
        let session, store = initConnection
        (query {
            for article in session.Query<Article>() do
            where (article.id = id)
            select article
        } |> Seq.toArray)

    let GetArticles = 
        let session, store = initConnection
        let articles = (session.Query<Article>() |> Seq.toArray)
        //for article in articles do
        //    let attachment = store.Operations.Send(new GetAttachmentOperation(article.id, article.images.[0], AttachmentType.Document, null))
        //    let memStr = new MemoryStream()
        //    attachment.Stream.CopyTo(memStr)
        //    article.attachment <-  memStr.ToArray()
        //    memStr.Dispose()
        //    attachment.Dispose()
        articles
        
