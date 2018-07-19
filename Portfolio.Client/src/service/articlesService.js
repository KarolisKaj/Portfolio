import articles from './articles/articles'

let articlesService = {
  getArticles: function () {
    return articles
  },
  getArticle: function (id) {
    return articles[id]
  },
  getArticleBody: function (id) {
    return articles[id].body
  }
}

export default articlesService
