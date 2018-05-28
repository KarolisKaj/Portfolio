namespace Portfolio.DataStore

module Model =

    type Article = {
        id : string
        articleBodyId :string
        name :string
        title : string
        teaser : string 
        images : string array
        keywords : string array
        mutable attachment : byte array
        }
    
    type ArticlesBody = {
        Id: string
        articleId: string
        title: string
        body: string
    }

    type Message = {
        name: string
        email: string
        message: string
    }
