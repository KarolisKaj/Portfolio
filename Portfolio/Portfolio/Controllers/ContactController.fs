namespace Portfolio.Controllers

open Microsoft.AspNetCore.Mvc
open Portfolio.DataStore.Model

[<Route("api/v1/[controller]")>]
type ContactController () =
    inherit Controller()

    [<HttpPost>]
    member this.PostEmail([<FromBody>]value:ContactSubmission) =
        "Hi"
