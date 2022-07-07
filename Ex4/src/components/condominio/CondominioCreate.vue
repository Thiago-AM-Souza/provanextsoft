<template lang="">
    <div class="container">
            <form @submit.prevent="salvar">
                <div class="mb-3">                  
                    <label for="condNome" class="form-label">Nome</label>
                    <input type="text" class="form-control" id="InputNome" v-model="condominio.nome">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Bairro</label>
                    <input type="text" class="form-control" id="InputBairro" v-model="condominio.bairro">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Area Total</label>
                    <input type="number" class="form-control" id="InputAreaTotal" v-model="condominio.areaTotal">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Valor do IPTU</label>
                    <input type="number" class="form-control" id="InputValorIptu" v-model="condominio.valorIptu">
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
    </div>
</template>
<script>
import Condominio from '../../services/condominios';
export default {
    data(){
        return{
            condominio: {
                nome: '',
                bairro: '',
                apartamentos: [],
                areaTotal: '',
                valorIptu: ''
            },
        }
    },
    methods:{
        salvar(){
            Condominio.salvar(this.condominio).then(() => {
                alert('Salvo com sucesso!')
            });
        }
    }
}
</script>
<style lang="">
    
</style>