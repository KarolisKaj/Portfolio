<template>
  <v-toolbar app>
      <v-btn class="hidden-xs-only" flat large href="/">Portfolio</v-btn>
      <v-btn class="hidden-xs-only" flat large href="/about">About</v-btn>
      <v-btn class="hidden-xs-only" flat large href="/contact">Contact Me</v-btn>
      <v-menu offset-y class="hidden-sm-and-up">
        <v-toolbar-side-icon slot="activator"></v-toolbar-side-icon>
        <v-list>
          <v-list-tile href="/">
            <v-list-tile-title href="/">Portfolio</v-list-tile-title>
          </v-list-tile>
          <v-list-tile href="/about">
            <v-list-tile-title href="/about">About</v-list-tile-title>
          </v-list-tile>
          <v-list-tile href="/contact">
            <v-list-tile-title href="/contact">Contact Me</v-list-tile-title>
          </v-list-tile>
        </v-list>
      </v-menu>
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
