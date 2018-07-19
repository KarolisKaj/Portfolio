<template>
  <v-container wrap>
      <ArticleCard v-for="article in articles" :key=article.id :article=article></ArticleCard>
  </v-container>
</template>

<script>
import ArticleCard from './ArticleCard'

export default {
  name: 'ArticleGrid',
  components: { ArticleCard },
  props: {
    articles: {
      required: true
    }
  }
}
</script>
