<template>
  <div id="app">
    <MenuVue></MenuVue>
    <router-view></router-view>
  </div>

</template>

<script>
//import TesteVue from './components/Teste.vue'
import MenuVue from './components/template/Menu.vue'

export default {
  components: { MenuVue }, 
}
</script>

<style>

</style>
