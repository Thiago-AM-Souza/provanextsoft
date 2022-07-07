<template lang="">
    <div class="container">
            <form @submit.prevent="atualizar">
                <div class="mb-3">                  
                    <label for="famNome" class="form-label">Nome</label>
                    <input type="text" class="form-control" id="InputNome" v-model="familia.nome">
                </div>
                <div class="mb-3">
                    <label for="apId" class="form-label">ApartamentoId</label>
                    <input type="number" class="form-control" id="InputAp" v-model="familia.apartamentoId">
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
                id: this.$route.params.id,
                nome: '',
                apartamentoId: '',
                moradores: []
            },
        }
    },
    methods:{
        atualizar(){
            Familia.atualizar(this.familia).then(() => {
                alert('Atualizado com sucesso!')
            });
        }
    }
}
</script>
<style lang="">
    
</style>