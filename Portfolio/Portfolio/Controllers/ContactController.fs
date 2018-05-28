namespace Portfolio.Controllers

open Microsoft.AspNetCore.Mvc
open Portfolio.DataStore.Model
open Portfolio.DataStore.DataStore

[<Route("api/v1/[controller]")>]
type ContactController () =
    inherit Controller()

    [<HttpPost>]
    member this.PostEmail([<FromBody>]value:Message) =
        StoreMessage value
        StatusCodeResult(200)
