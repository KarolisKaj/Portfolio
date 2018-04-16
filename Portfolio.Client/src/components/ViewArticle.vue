<template>
    <div></div>
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
    httpService.get('/article').then(value => {
      self.articles = value.data
    }).catch(ex => {
      console.log(ex)
    })
  }
}
</script>
