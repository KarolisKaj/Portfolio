<template>
  <div id="app">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <PortfolioHeader v-bind:metalinks="metalinkss"></PortfolioHeader>
    <router-view/>
    <PortfolioFooter id="footer"></PortfolioFooter>
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
      metalinkss: [
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
  min-height: 100vh; /* will cover the 100% of viewport */
  overflow: hidden;
  display: block;
  position: relative;
}
/* Will not show scrollbar */
html, body {
 overflow-y: auto;
 height: 100%;
 position: relative;
}
#footer{
  position: absolute;
  bottom: 0;
  width: 100%;
}
</style>
