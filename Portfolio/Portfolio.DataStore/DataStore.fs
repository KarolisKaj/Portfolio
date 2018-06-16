namespace Portfolio.DataStore

module DataStore =
    open Raven.Client.Documents.Operations.Attachments
    open Raven.Client.Documents.Attachments
    open System.IO
    open System
    open Raven.Client.Documents
    open Portfolio.DataStore.Model
    open System.Security.Cryptography.X509Certificates

    let certificate = new X509Certificate2("C:\\RavenDB\\Clusters\\Portfolio\\A\\cluster.server.certificate.portfolio.pfx")
    let hosts = [|"https://a.portfolio.ravendb.community:44300"|]
    let dbName = "Portfolio"

    let getStore urls db cert = 
        let store = new DocumentStore (Urls = urls, Database = db, Certificate = cert)
        store.Initialize()

    let createSession (store : IDocumentStore) =
        store.OpenSession()

    let initConnection () =
        let store = getStore hosts dbName certificate
        (createSession store, store)

    let getSession () =
        let session, toDispose = initConnection()
        toDispose.Dispose |> ignore 
        session

    let GetArticle id = 
        use session = getSession()
        (query {
            for article in session.Query<Article>() do
            where (article.id = id)
            select article
        } |> Seq.toArray)

    let GetArticles () = 
        let s1, s2 = initConnection()
        use session = s1
        use store = s2
        let articles = (session.Query<Article>() |> Seq.toArray)
        for article in articles do
            use attachment = store.Operations.Send(new GetAttachmentOperation(article.id, article.images.[0], AttachmentType.Document, null))
            use memStr = new MemoryStream()
            attachment.Stream.CopyTo(memStr)
            article.attachment <-  memStr.ToArray()
        articles

    let GetArticleBody id = 
        use session = getSession()
        (query {
        for articleBody in session.Query<ArticlesBody>() do
        where (articleBody.Id = id)
        select articleBody
        } |> Seq.take 1)

    let StoreMessage message =
        use session = getSession()
        session.Store({ name = message.name; email= message.email; message = message.message }, null)
        session.SaveChanges()
