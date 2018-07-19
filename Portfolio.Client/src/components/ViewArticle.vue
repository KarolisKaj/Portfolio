<template>
    <div>{{ articleBody }}</div>
</template>

<script>
import articleService from '../service/articlesService'

export default {
  name: 'ViewArticle',
  data () {
    return {
      articleBody: undefined
    }
  },
  created () {
    this.articles = articleService.getArticle(this.$route.params.id)
  }
}
</script>
