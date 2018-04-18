<template>
    <v-toolbar app>
      <v-toolbar-side-icon></v-toolbar-side-icon>
      <v-toolbar-title to="/" exact><router-link to="/">Portfolio</router-link></v-toolbar-title>
      <v-toolbar-title to="/" exact>Portfolio</v-toolbar-title>
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
