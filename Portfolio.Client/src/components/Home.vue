<template>
  <v-container fluid="true">
    <v-layout row wrap>
      <v-flex >
        <Author imgSrc='https://pre00.deviantart.net/7bf3/th/pre/f/2008/021/a/8/hokusai_omage_by_zweezwyy.jpg'></Author>
      </v-flex>
      <v-flex >
        <ArticleGrid :articles='articles'></ArticleGrid>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import httpService from '../service/httpService'
import ArticleGrid from './usercontrols/ArticleGrid'
import Author from './usercontrols/Author'
export default {
  name: 'home',
  components: { ArticleGrid, Author },
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
