<template>
  <div v-html="articleBody"></div>
</template>

<script>
import articleService from "../service/articlesService";

export default {
  name: "ViewArticle",
  data() {
    return {
      articleBody: undefined
    };
  },
  created() {
    this.articleBody = articleService.getArticle(this.$route.params.id).bodyPath;
  }
};
</script>
