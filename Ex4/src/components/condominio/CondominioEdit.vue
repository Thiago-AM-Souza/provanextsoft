<template>
    <div class="container">
        <form @submit.prevent="atualizar">
            <div class="mb-3">                  
                <label for="condNome" class="form-label">Nome</label>
                <input type="text" class="form-control" id="InputNome" v-model="condominio.nome">
            </div>
            <div class="mb-3">
                <label for="condBairro" class="form-label">Bairro</label>
                <input type="text" class="form-control" id="InputBairro" v-model="condominio.bairro">
            </div>
            <div class="mb-3">
                <label for="condArea" class="form-label">Area Total</label>
                <input type="number" class="form-control" id="InputAreaTotal" v-model="condominio.areaTotal">
            </div>
            <div class="mb-3">
                <label for="condValor" class="form-label">Valor do IPTU</label>
                <input type="number" class="form-control" id="InputValorIptu" v-model="condominio.valorIptu">
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</template>
<script>
import Condominio from '../../services/condominios';
export default {
    props:{
        id: Number
    },
    data(){
        return{
            condominio: {
                id: this.$route.params.id,
                nome: '',
                bairro: '',
                areaTotal: '',
                valorIptu: ''
            },
        }
    },
    methods:{
        atualizar(){
            Condominio.atualizar(this.condominio).then(() => {
                alert('Atualizado com sucesso!')
            });
        }
    }
}
</script>
<style>
    
</style>