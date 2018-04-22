<template>
    <v-toolbar app>
      <v-btn flat large href="/">Portfolio</v-btn>
      <v-btn flat large href="/about">About</v-btn>
      <v-btn flat large href="/contact">Contact Me</v-btn>
      <v-spacer></v-spacer>
      <v-btn v-for="metaLink in metaLinks" icon v-on:click="linkRedirect(metaLink.link)" v-bind:key="metaLink.link + metaLink.icon" >
        <v-icon>{{metaLink.icon}}</v-icon>
      </v-btn>
    </v-toolbar>
</template>

<script>
export default {
  name: 'PortfolioHeader',
  props: {
    metaLinks: {
      type: Array,
      required: true
    }
  },
  methods: {
    linkRedirect: function (link) {
      window.open(link)
    }
  }
}
</script>
