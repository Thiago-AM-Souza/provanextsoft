<template>
    <div class="container flex">
        <h1>Lista de Moradores</h1>
        <router-link to="/moradorcreate"><button class="btn btn-primary">Cadastrar novo</button></router-link>
        <div class="row">
            <MoradorCard v-for="morador of moradores" 
                :key="morador.id"
                :id="morador.id"
                :nome="morador.nome"
                :idade="morador.idade"
                :familiaId="morador.familiaId"
            ></MoradorCard>
        </div>
    </div>
</template>
<script>
import MoradorCard from './MoradorCard.vue';
import Morador from '../../services/moradores';
export default {
    components: { MoradorCard },
    data() {
        return {
            moradores: []
        }
    },
    mounted() {
        Morador.listar().then(resposta => {
            this.moradores = resposta.data;
        })
    },
}
</script>
<style>
    
</style>