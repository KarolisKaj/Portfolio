﻿module Model

open System

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
