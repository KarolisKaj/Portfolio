<template>
    <v-avatar size="256" >
        <img :src=imgSrc alt="avatar">
    </v-avatar>
</template>

<script>
export default {
  name: 'Author',
  props: {
    imgSrc: {
      type: String,
      required: true
    }
  }
}
</script>
