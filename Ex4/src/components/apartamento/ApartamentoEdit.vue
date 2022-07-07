<template>
    <div class="container">
        <form @submit.prevent="atualizar">
            <div class="mb-3">                  
                    <label for="apNum" class="form-label">Numero</label>
                    <input type="number" class="form-control" id="InputNum" v-model="apartamento.numero">
                </div>
                <div class="mb-3">
                    <label for="condId" class="form-label">condominioId</label>
                    <input type="number" class="form-control" id="InputCondId" v-model="apartamento.condominioId">
                </div>
                <div class="mb-3">
                    <label for="areaTot" class="form-label">Area Total</label>
                    <input type="number" class="form-control" id="InputAreaTotal" v-model="apartamento.areaTotal">
                </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</template>
<script>
import Apartamento from '../../services/apartamentos';
export default {
    props:{
        id: Number
    },
    data(){
        return{
            apartamento: {
                id: this.$route.params.id,
                numero: '',
                condominioId: '',
                areaTotal: '',
                fracaoIdeal: 0,
                valorProporcionalIptu: 0
            },
        }
    },
    methods:{
        atualizar(){
            Apartamento.atualizar(this.apartamento).then(() => {
                alert('Atualizado com sucesso!')
            });
        }
    }
}
</script>
<style>
    
</style>