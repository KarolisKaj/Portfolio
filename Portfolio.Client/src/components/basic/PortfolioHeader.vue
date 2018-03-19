<template>
    <v-toolbar>
        <v-toolbar-title>Portfolio</v-toolbar-title>
    </v-toolbar>
</template>

<script>
export default {
  name: 'PortfolioHeader',
  data () {
    return {
      year: (new Date()).getFullYear()
    }
  }
}
</script>
