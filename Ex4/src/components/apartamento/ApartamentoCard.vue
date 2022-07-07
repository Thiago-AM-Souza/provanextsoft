<template lang="">
    <div class="pt-3 col-4">
        <div class="card mt-3 me-3" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title">Numero: {{numero}}</h5>
                <h6 class="card-subtitle mb-2 text-muted">CondominioId: {{condominioId}}</h6>
                <h6 class="card-subtitle mb-2 text-muted">Area Total: {{areaTotal}}</h6>
                <h6 class="card-subtitle mb-2 text-muted">fracaoIdeal: {{fracaoIdeal}}</h6>
                <h6 class="card-subtitle mb-2 text-muted">Valor Proporcional IPTU: {{valorProporcionalIptu}}</h6>
                <router-link :to="{name: 'apartamentoedit', params:{id:id}}">
                    <button class="btn btn-primary me-2">Editar</button>
                </router-link>
                <button @click="deletar(id)" class="btn btn-primary">Deletar</button>
            </div>
        </div>
    </div>
</template>
<script>
import Apartamento from '../../services/apartamentos';
export default {
    props: {
        id: Number,
        numero: Number,
        condominioId: Number,
        areaTotal: Number,
        fracaoIdeal: Number,
        valorProporcionalIptu: Number
    },
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
    methods: {
        deletar(id) {
            Apartamento.deletar(id).then(() => {
                alert('Excluido com sucesso!')
            })
        window.location.reload()
    }
}
}

</script>
<style>
    
</style>