<template>
  <v-container fluid >
    <v-layout wrap row>
      <v-flex xs12 sm12 md4 lg3 xl2 >
        <Author :img=img elevation-7></Author>
      </v-flex>
      <v-flex>
        <ArticleGrid :articles='articles'></ArticleGrid>
        <v-progress-circular v-if="articles.length === 0" indeterminate :size="70" ></v-progress-circular>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import httpService from '../service/httpService'
import ArticleGrid from './usercontrols/ArticleGrid'
import Author from './usercontrols/Author'
import Image from '../assets/author_img.jpg'
export default {
  name: 'home',
  components: { ArticleGrid, Author },
  data () {
    return {
      articles: [],
      img: Image
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
