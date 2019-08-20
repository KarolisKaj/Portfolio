import articles from './articles/articles'

let articlesService = {
  getArticles: function () {
    return articles
  },
  getArticle: function (id) {
    return articles[id]
  },
}

export default articlesService
