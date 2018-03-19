<template>
  <v-footer height="5px" class="lime lighten-1 m-b-0" absolute="true">
      <v-flex xs12 py-3 text-xs-center blue accent-4--text>&copy;{{year}} — <strong>Karolis Kajėnas</strong>
      </v-flex>
  </v-footer>
</template>

<script>
export default {
  name: 'PortfolioFooter',
  data () {
    return {
      year: (new Date()).getFullYear()
    }
  }
}
</script>
