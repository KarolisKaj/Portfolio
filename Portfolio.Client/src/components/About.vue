<template>
  <v-container fluid>
    <v-layout row align-center>
      <v-flex class="text-xs-center">
        <Author :img=img elevation-7 align-center></Author>
      </v-flex>
    </v-layout>
    <v-layout>
      asdasd
    </v-layout>
  </v-container>
</template>

<script>
import Author from './usercontrols/Author'
import Image from '../assets/author_img.jpg'

export default {
  name: 'About',
  components: { Author },
  data () {
    return {
      msg: 'About page',
      img: Image
    }
  }
}
</script>
