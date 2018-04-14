namespace Portfolio.DataStore

open Raven.Client.Documents
open Model
open System.Security.Cryptography.X509Certificates

module DataStore =
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
        getSession store
        
    let GetArticle id = 
        let session = initConnection
        (query {
            for article in session.Query<Article>() do
            where (article.id = id)
            select article
        } |> Seq.toArray)

    let GetArticles = 
        let session = initConnection
        (session.Query<Article>() |> Seq.toArray)
        
