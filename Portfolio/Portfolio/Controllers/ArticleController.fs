namespace Portfolio.Controllers

open Microsoft.AspNetCore.Mvc
open Portfolio.DataStore.DataStore

[<Route("api/v1/[controller]")>]
type ArticleController () =
    inherit Controller()

    [<HttpGet>]
    member this.Get() =
        GetArticles()

    [<HttpGet("{id}")>]
    member this.Get(id:string) =
        GetArticle id

    [<HttpGet("body/{id}")>]
    member this.Post(id:string) =
        GetArticleBody id
