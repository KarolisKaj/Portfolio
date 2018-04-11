namespace Portfolio.DataStore

open Raven.Client.Documents
open Model

module DataStore =
    
    let OpenConnection = 
        let store = new DocumentStore (Urls = [|"https://a.portfolio.ravendb.community:44300"|], Database = "Portfolio")
        store.Initialize() |> ignore
        let session = store.OpenSession()
        let data = session.Query<Article>()
        let a = data.ToList()
        let me = a.Result
        me
        store
