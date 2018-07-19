<template>
    <v-flex xs12 mt-3 >
      <v-card  >
        <v-container fluid grid-list-lg elevation-7>
          <v-layout row wrap >
            <v-flex>
              <div>
                <div class="headline">{{article.title}}</div>
                <div>{{article.description}}</div>
              </div>
            </v-flex>
            <v-flex v-if="article" xs12 sm4 md4 lg3 xl3>
              <v-card-media
                :src= "require('../../service/articles/researchwebsite.png')"
                height="125px"
                contain
              ></v-card-media>
            </v-flex>
            <v-flex xs12>
              <v-btn :href=link>
                read more
              </v-btn>
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
    link: function () {
      return '/article/' + this.article.id
    }
  }
}
</script>
