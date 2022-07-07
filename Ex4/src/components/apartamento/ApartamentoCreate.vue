<template lang="">
    <div class="container">
            <form @submit.prevent="salvar">
                <div class="mb-3">                  
                    <label for="apNum" class="form-label">Numero</label>
                    <input type="number" class="form-control" id="InputNum" v-model="apartamento.numero">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">condominioId</label>
                    <input type="number" class="form-control" id="InputCondId" v-model="apartamento.condominioId">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Area Total</label>
                    <input type="number" class="form-control" id="InputAreaTotal" v-model="apartamento.areaTotal">
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
    </div>
</template>
<script>
import Apartamento from '../../services/apartamentos';
export default {
    data(){
        return{
            apartamento: {
                numero: '',
                condominioId: '',
                areaTotal: '',
                fracaoIdeal: 0,
                valorProporcionalIptu: 0
            },
        }
    },
    methods:{
        salvar(){
            Apartamento.salvar(this.apartamento).then(() => {
                alert('Salvo com sucesso!')
            });
        }
    }
}
</script>
<style>
    
</style>