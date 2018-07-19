<template>
  <v-container fluid >
    <v-layout wrap row>
      <v-flex xs12 sm12 md4 lg3 xl2 class="text-xs-center">
        <Author :img=img elevation-7></Author>
        <v-btn href="/about" flat>About me</v-btn>
      </v-flex>
      <v-flex class="text-xs-center" title v-if="isError" mt-5>
        <div>Unable to load articles. <a href="/contact">Contact me...</a></div>
      </v-flex>
      <v-flex v-if="!isError">
        <ArticleGrid :articles='articles'></ArticleGrid>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import articlesService from '../service/articlesService'
import ArticleGrid from './usercontrols/ArticleGrid'
import Author from './usercontrols/Author'
import Image from '../assets/author_img.jpg'
export default {
  name: 'home',
  components: { ArticleGrid, Author },
  data () {
    return {
      articles: [],
      img: Image,
      isError: false
    }
  },
  created () {
    this.articles = articlesService.getArticles()
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
