<template>
    <div class="container flex">
        <h1>Lista de Familias</h1>
        <router-link to="/familiacreate"><button class="btn btn-primary">Cadastrar novo</button></router-link>
        <div class="row">
            <FamiliaCard v-for="familia of familias" 
                :key="familia.id"
                :id="familia.id"
                :nome="familia.nome"
                :apartamentoId="familia.apartamentoId"
            ></FamiliaCard>
        </div>
    </div>
</template>
<script>
import FamiliaCard from './FamiliaCard.vue';
import Familia from '../../services/familias';
export default {
    components: { FamiliaCard },
    data() {
        return {
            familias: []
        }
    },
    mounted() {
        Familia.listar().then(resposta => {
            this.familias = resposta.data;
        })
    },
}
</script>
<style>
    
</style>