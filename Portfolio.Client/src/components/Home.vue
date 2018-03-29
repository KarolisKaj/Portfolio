<template>
  <v-container grid-list-md text-xs-center>
    <v-layout row wrap>
      <v-flex xs12>
        <v-card >
          <v-card-text class="px-0" v-text="msg">  </v-card-text>
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
      msg: 'My'
    }
  },
  created () {
    let self = this
    httpService.get('http://localhost:50746/api/v1/values').then(value => {
      self.msg = value.data[0]
    }).catch(ex => {
      console.log(ex)
    })
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
