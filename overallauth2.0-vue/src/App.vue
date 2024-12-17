<template>
  <router-view />
</template>

<script lang="ts">
import { defineComponent } from "vue";


export default defineComponent({
  setup() {
  },
});
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  /* margin-top: 60px; */
}
html,  
    body,  
    #app {  
        height: 100%;  
        margin: 0;  
        padding: 0;  
    }
</style>