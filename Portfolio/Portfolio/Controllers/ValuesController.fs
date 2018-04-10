namespace Portfolio.Controllers

open Microsoft.AspNetCore.Mvc
open Portfolio.DataStore.DataStore

[<Route("api/v1/[controller]")>]
type ValuesController () =
    inherit Controller()

    [<HttpGet>]
    member this.Get() =
        [|"value1"; "value2"|]

    [<HttpGet("{id}")>]
    member this.Get(id:string) =
        OpenConnection |> ignore
        "ha"

    [<HttpPost>]
    member this.Post([<FromBody>]value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>]value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
