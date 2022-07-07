<template>
    <div class="container flex">
        <h1>Lista de Apartamentos</h1>
        <router-link to="/apartamentocreate"><button class="btn btn-primary">Cadastrar novo</button></router-link>
        <div class="row">
            <ApartamentoCard v-for="apartamento of apartamentos" 
                :key="apartamento.id"
                :id="apartamento.id"
                :numero="apartamento.numero"
                :condominioId="apartamento.condominioId"
                :area-total="apartamento.areaTotal"
                :fracao-ideal="apartamento.fracaoIdeal"
                :valor-proporcional-iptu="apartamento.valorProporcionalIptu"
            ></ApartamentoCard>
        </div>
    </div>
</template>
<script>
import ApartamentoCard from './ApartamentoCard.vue';
import Apartamento from '../../services/apartamentos';
export default {
    components: { ApartamentoCard },
    data() {
        return {
            apartamentos: []
        }
    },
    mounted() {
        Apartamento.listar().then(resposta => {
            this.apartamentos = resposta.data;
        })
    },
}
</script>
<style>
    
</style>