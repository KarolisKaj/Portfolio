<template>
    <v-toolbar >
      <v-toolbar-side-icon></v-toolbar-side-icon>
      <v-toolbar-title>Portfolio</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-btn icon href='https://stackoverflow.com/users/5505949'>
        <v-icon>fab fa-stack-overflow</v-icon>
      </v-btn>
      <v-btn icon href='https://github.com/KarolisKaj'>
        <v-icon>fab fa-github-square</v-icon>
      </v-btn>
    </v-toolbar>
</template>

<script>
export default {
  name: 'PortfolioHeader',
  data () {
    return {

    }
  }
}
</script>
