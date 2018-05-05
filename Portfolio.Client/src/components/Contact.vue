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
        <v-btn :disabled="!valid" v-on:click="sumbit()">Send</v-btn>
      </v-form>
    </v-flex>
  </v-container>
</template>

<script>
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
      ]
    }
  },
  methods: {
    sumbit: function () {
      this.$refs.form.reset()
    }
  }
}
</script>
