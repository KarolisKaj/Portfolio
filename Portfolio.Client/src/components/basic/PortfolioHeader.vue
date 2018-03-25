<template>
    <v-toolbar app>
      <v-toolbar-side-icon></v-toolbar-side-icon>
      <v-toolbar-title>Portfolio</v-toolbar-title>
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
  },
  created: () => console.log(this),
  mounted: () => console.log(this),
  updated: () => console.log(this),
  beforeUpdate: () => console.log(this)
}
</script>
