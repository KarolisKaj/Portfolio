<template>
  <div id="app">
      <PortfolioHeader></PortfolioHeader>
      <router-view/>
      <PortfolioFooter id="footer"></PortfolioFooter>
  </div>
</template>

<script>
import PortfolioFooter from './components/basic/PortfolioFooter'
import PortfolioHeader from './components/basic/PortfolioHeader'

export default {
  name: 'App',
  data () {
    return {
      year: (new Date()).getFullYear()
    }
  },
  components: { PortfolioFooter, PortfolioHeader }
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
