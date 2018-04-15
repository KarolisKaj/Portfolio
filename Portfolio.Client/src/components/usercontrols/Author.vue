<template>
    <v-avatar size=256 pa-5 >
        <img :src=img>
    </v-avatar>
</template>

<script>
export default {
  name: 'Author',
  props: {
    img: {
      required: true
    }
  }
}
</script>
