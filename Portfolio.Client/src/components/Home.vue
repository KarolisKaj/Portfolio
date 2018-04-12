<template>
  <ArticleGrid :articles='articles'></ArticleGrid>
</template>

<script>
import httpService from '../service/httpService'
import ArticleGrid from './usercontrols/ArticleGrid'
export default {
  name: 'home',
  components: { ArticleGrid },
  data () {
    return {
      articles: []
    }
  },
  created () {
    let self = this
    httpService.get('/article').then(value => {
      self.articles = value.data
    }).catch(ex => {
      console.log(ex)
    })
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
