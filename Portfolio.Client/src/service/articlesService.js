import articles from '../static/articles/articles'

let articleService = {
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

export default articleService
