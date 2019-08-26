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
    <v-snackbar :value="isSuccess || isFailure" :timeout='7000' :color=computeColor()>
        <div v-if="isSuccess">Thanks for reaching out! Will get back to you soon.</div>
        <div v-if="isFailure">Failed to send message. Please try again later.</div>
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
      isSuccess: false,
      isFailure: false
    }
  },
  methods: {
    sumbit: function () {
      let self = this
      self.loading = true
      self.isSuccess = self.isFailure = false
      httpService.post('/contact', {
        name: self.name,
        email: self.email,
        message: self.message
      }).then(() => {
        self.loading = false
        self.isSuccess = true
        self.$refs.form.reset()
      }).catch(() => {
        self.loading = false
        self.isFailure = true
      })
    },
    computeColor: function () {
      return this.isSuccess ? 'success' : 'error'
    }
  }
}
</script>
