namespace Portfolio.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc

[<Route("api/v1/[controller]")>]
type ValuesController () =
    inherit Controller()

    [<HttpGet>]
    member this.Get() =
        [|"value1"; "value2"|]

    [<HttpGet("{id}")>]
    member this.Get(id:int) =
        ()

    [<HttpPost>]
    member this.Post([<FromBody>]value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>]value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
