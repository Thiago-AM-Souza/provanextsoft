<template>
  <div id="app">
    <MenuVue></MenuVue>
    <router-view></router-view>
  </div>

</template>

<script>

import MenuVue from './components/template/Menu.vue'

export default {
  components: { MenuVue }, 
}
</script>

<style>

</style>
