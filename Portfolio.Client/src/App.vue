<template>
  <div id="app">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <PortfolioHeader app v-bind:metaLinks="metaLinks"></PortfolioHeader>
    <v-content>
      <router-view/>
    </v-content>
    <PortfolioFooter app></PortfolioFooter>
  </div>
</template>

<script>
import PortfolioFooter from './components/basic/PortfolioFooter'
import PortfolioHeader from './components/basic/PortfolioHeader'

export default {
  name: 'App',
  components: { PortfolioFooter, PortfolioHeader },
  data () {
    return {
      metaLinks: [
        { link: 'https://www.linkedin.com/in/karolis-kaj%C4%97nas-b22146ab/', icon: 'fab fa-linkedin' },
        { link: 'https://stackoverflow.com/users/5505949', icon: 'fab fa-stack-overflow' },
        { link: 'https://github.com/KarolisKaj', icon: 'fab fa-github-square' }
      ]
    }
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
}
/* Will not show scrollbar */
html, body {
 overflow-y: auto;
}
</style>
