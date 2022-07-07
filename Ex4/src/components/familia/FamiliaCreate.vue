<template lang="">
    <div class="container">
            <form @submit.prevent="salvar">
                <div class="mb-3">                  
                    <label for="famNome" class="form-label">Nome</label>
                    <input type="text" class="form-control" id="InputNome" v-model="familia.nome">
                </div>
                <div class="mb-3">
                    <label for="apId" class="form-label">ApartamentoId</label>
                    <input type="number" class="form-control" id="ApId" v-model="familia.apartamentoId">
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
    </div>
</template>
<script>
import Familia from '../../services/familias';
export default {
    data(){
        return{
            familia: {
                nome: '',
                apartamentoId: '',
                moradores: []
            },
        }
    },
    methods:{
        salvar(){
            Familia.salvar(this.familia).then(() => {
                alert('Salvo com sucesso!')
            });
        }
    }
}
</script>
<style lang="">
    
</style>