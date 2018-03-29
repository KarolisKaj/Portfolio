<template>
  <v-container grid-list-md text-xs-center>
    <v-layout row wrap>
      <v-flex xs12>
        <v-card >
          <v-card-text class="px-0" > {{ msg }} </v-card-text>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import httpService from '../service/httpService'
export default {
  name: 'home',
  data () {
    return {
      msg: 'Initial Value'
    }
  },
  created: () => {
    console.log(this)
    httpService.get('http://localhost:50746/api/v1/values').then(value => {
      console.log(value)
    }).catch(ex => {
      console.log(ex)
    })
  },
  mounted: () => {
    console.log(this.msg)
    console.log(this)
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
