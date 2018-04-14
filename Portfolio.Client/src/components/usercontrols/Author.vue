<template>
    <v-avatar size=256 >
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
