namespace Portfolio.DataStore

open Raven.Client.Documents

module DataStore =
    
    let OpenConnection = 
        let documentStore = new DocumentStore()
        documentStore.Urls = [|"https://a.portfolio.ravendb.community";|]
        documentStore.Initialize()
        let session = documentStore.OpenSession("https://a.portfolio.ravendb.community")
        let data = session.Query("danske-bank-research-website", "Articles")
        documentStore
