<template>
  <div id="app">
      <router-view/>
      <v-footer height="1px" class="lime lighten-1 m-b-0" absolute='true'>
          <v-flex xs12 py-3 text-xs-center black--text>
            &copy;{{year}} — <strong>Karolis Kajėnas</strong>
          </v-flex>
      </v-footer>
  </div>
</template>

<script>
export default {
  name: 'App',
  data () {
    return {
      year: (new Date()).getFullYear()
    }
  }
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
