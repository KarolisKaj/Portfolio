<template>
  <v-container fluid>
    <v-layout row mb-3>
      <v-flex headline offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
       About me
      </v-flex>
    </v-layout>
    <v-layout row mb-3>
      <v-flex offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
        <Author :img=img elevation-7 align-center></Author>
      </v-flex>
    </v-layout>
    <v-layout row mb-3>
      <v-flex offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6 body-2 justify-right>
        My name is Karolis Kajenas and I am full-time software engineer.
        My experience vary from full stack website software to full blown desktop apps.
        Whether you have an idea or require to upgrade your existing solutions I am here to deliver quality software. <a href="/contact">Contact me...</a>
      </v-flex>
    </v-layout>
    <v-layout row mb-3>
      <v-flex offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
        <v-chip v-for="tech in techStack" :key=tech disabled>{{ tech }}</v-chip>
      </v-flex>
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
      img: Image,
      techStack: ['.net', 'c#', 'kafka', 'vue', 'react', 'wpf', 'webpages', 'desktop apps']
    }
  }
}
</script>
