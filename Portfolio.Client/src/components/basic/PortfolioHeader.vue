<template>
    <v-toolbar >
      <v-toolbar-side-icon></v-toolbar-side-icon>
      <v-toolbar-title>Portfolio</v-toolbar-title>
      <v-spacer></v-spacer>

    </v-toolbar>
</template>

<script>
export default {
  name: 'PortfolioHeader',
  props: {
    metalinks: {
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
