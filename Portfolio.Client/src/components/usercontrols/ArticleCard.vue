<template>
    <v-flex xs12 mt-2>
      <v-card color="cyan darken-2" class="white--text" >
        <v-container fluid grid-list-lg>
          <v-layout row>
            <v-flex xs7>
              <div>
                <div class="headline">{{article.title}}</div>
                <div>{{article.teaser}}</div>
              </div>
            </v-flex>
            <v-flex v-if="article" xs5>
              <v-card-media
                v-bind:src="fullImgSrc"
                height="125px"
                contain
              ></v-card-media>
            </v-flex>
          </v-layout>
        </v-container>
      </v-card>
    </v-flex>
</template>

<script>
export default {
  name: 'ArticleCard',
  props: {
    article: {
      required: true
    }
  },
  computed: {
    fullImgSrc: function () {
      return 'data:image/png;base64,' + this.article.attachment
    }
  },
  data () {
    return {
      msg: ''
    }
  }
}
</script>
