<template>
  <v-container>
      <v-flex headline offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
       Contact me
      </v-flex>
      <v-flex offset-xs1 offset-sm1 offset-md2 offset-lg3 xs10 sm10 md8 lg6>
        <v-form v-model="valid" ref="form">
        <v-text-field v-model="name" :rules="nameRules" label="Name" required></v-text-field>
        <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>
        <v-text-field v-model="message" :rules="messageRules" label="Message" counter=10 required multi-line></v-text-field>
        <v-btn :disabled="!valid" v-on:click="sumbit()" :loading="loading">Send</v-btn>
      </v-form>
    </v-flex>
    <v-layout>
    <v-snackbar :value="isSuccess || isFailure" m-0 pa-0 timeout="99999999" style="{ padding: 0 !important; }">
      <div pa-0>
        <v-alert v-model="isSuccess" m-0 pa-0 type="success" dismissible transition="scale-transition">
          Successfully sent message. Will get back to you soon.
        </v-alert>
      </div>
      <v-alert v-model="isFailure" type="error" dismissible transition="scale-transition">
        Failed to send message. Please try again later.
      </v-alert>
    </v-snackbar>
    </v-layout>
  </v-container>
</template>

<script>
import httpService from '../service/httpService'

export default {
  name: 'Contact',
  data () {
    return {
      valid: false,
      name: '',
      nameRules: [
        v => !!v || 'Name is required'
      ],
      email: '',
      emailRules: [
        v => !!v || 'E-mail is required',
        v => /^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/.test(v) || 'E-mail must be valid'
      ],
      message: '',
      messageRules: [
        v => (v && v.length > 10) || 'Message must be longer than 10 characters'
      ],
      loading: false,
      isSuccess: true,
      isFailure: false
    }
  },
  methods: {
    sumbit: function () {
      let self = this
      self.loading = true
      httpService.post('/contact', {
        name: self.name,
        email: self.email,
        message: self.message
      }).then(value => {
        self.loading = false
        self.isSuccess = true
      }).catch(ex => {
        self.loading = false
        self.isFailure = true
      })
      this.$refs.form.reset()
    }
  }
}
</script>

<style scoped>
.snack__content {
  padding: "0px 0px 0px 0px !important";
}
</style>
