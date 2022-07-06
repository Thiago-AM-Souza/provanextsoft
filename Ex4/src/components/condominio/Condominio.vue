<template>
    <div class="container">
        <h1>Lista de Condominios</h1>
        <router-link to="/condominiocreate"><button class="btn btn-primary">Cadastrar novo</button></router-link>
        <div class="d-flex flex-wrap">
            <CondominioCard v-for="condominio of condominios" 
                :key="condominio.id"
                :id="condominio.id"
                :nome="condominio.nome"
                :bairro="condominio.bairro"
                :areaTotal="condominio.areaTotal"
                :valorIptu="condominio.valorIptu"
            ></CondominioCard>
        </div>
    </div>
</template>
<script>
import CondominioCard from './CondominioCard.vue';
import Condominio from '../../services/condominios';
export default {
    components: { CondominioCard },
    data() {
        return {
            condominios: []
        }
    },
    mounted() {
        Condominio.listar().then(resposta => {
            this.condominios = resposta.data;
        })
    },
}
</script>
<style>
    
</style>