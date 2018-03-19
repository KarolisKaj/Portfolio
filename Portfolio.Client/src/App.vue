<template>
  <div id="app">
      <PortfolioHeader></PortfolioHeader>
      <router-view/>
      <PortfolioFooter></PortfolioFooter>
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
}
/* Will not show scrollbar */
html {
  overflow-y: auto
}
</style>
