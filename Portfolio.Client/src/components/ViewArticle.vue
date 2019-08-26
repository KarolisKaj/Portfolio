<template>
  <v-container>
    <v-flex offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
      <div v-html="articleBody"></div>
    </v-flex>
  </v-container>
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
    this.articleBody = articleService.getArticle(
      this.$route.params.id
    ).body;
  }
};
</script>
