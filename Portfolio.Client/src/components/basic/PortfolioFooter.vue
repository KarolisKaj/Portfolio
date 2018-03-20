<template>
  <v-footer>
      <v-flex xs12 py-3 text-xs-center blue accent-4--text>&copy;{{year}} — <strong>Karolis Kajėnas</strong>
      </v-flex>
  </v-footer>
</template>

<script>
export default {
  name: 'portfolioFooter',
  data () {
    return {
      year: (new Date()).getFullYear()
    }
  }
}
</script>
