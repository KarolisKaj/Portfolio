<template>
    <div>{{ articleBody }}</div>
</template>

<script>
import httpService from '../service/httpService'

export default {
  name: 'ViewArticle',
  data () {
    return {
      articleBody: undefined
    }
  },
  created () {
    let self = this
    httpService.get('/article/body/' + this.$route.params.id).then(value => {
      self.articles = value.data.body
    }).catch(ex => {
      console.log(ex)
    })
  }
}
</script>
