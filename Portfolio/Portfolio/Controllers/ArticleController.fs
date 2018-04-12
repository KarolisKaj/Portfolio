namespace Portfolio.Controllers

open Microsoft.AspNetCore.Mvc
open Portfolio.DataStore.DataStore

[<Route("api/v1/[controller]")>]
type ArticleController () =
    inherit Controller()

    [<HttpGet>]
    member this.Get() =
        ObtainArticles

    [<HttpGet("{id}")>]
    member this.Get(id:string) =
        ObtainArticle id 

    [<HttpPost>]
    member this.Post([<FromBody>]value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>]value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
