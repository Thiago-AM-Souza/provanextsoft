<template lang="">
    <div class="container">
            <form @submit.prevent="salvar">
                <div class="mb-3">                  
                    <label for="morNome" class="form-label">Nome</label>
                    <input type="text" class="form-control" id="InputNome" v-model="morador.nome">
                </div>
                <div class="mb-3">
                    <label for="morIdade" class="form-label">Idade</label>
                    <input type="number" class="form-control" id="InputIdade" v-model="morador.idade">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Familia Id</label>
                    <input type="number" class="form-control" id="InputFamId" v-model="morador.familiaId">
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
    </div>
</template>
<script>
import Morador from '../../services/moradores';
export default {
    data(){
        return{
            morador: {
                nome: '',
                idade: '',
                familiaId: ''
            },
        }
    },
    methods:{
        salvar(){
            Morador.salvar(this.morador).then(() => {
                alert('Salvo com sucesso!')
            });
        }
    }
}
</script>
<style lang="">
    
</style>