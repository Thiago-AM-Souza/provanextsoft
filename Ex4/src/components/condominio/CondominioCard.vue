<template lang="">
    <div class="container pt-3">
        <div class="card mt-3 me-3" style="width: 18rem;">
            <div class="card-body">
                <h1>{{id}}</h1>
                <h5 class="card-title">{{nome}}</h5>
                <h6 class="card-subtitle mb-2 text-muted">Bairro: {{bairro}}</h6>
                <h6 class="card-subtitle mb-2 text-muted">Area Total: {{areaTotal}}</h6>
                <router-link :to="{name: 'editar', params:{id:id}}">
                    <button class="btn btn-primary me-2">Editar</button>
                </router-link>
                <button @click="deletar(id)" class="btn btn-primary">Deletar</button>
            </div>
        </div>
    </div>
</template>
<script>
import Condominio from '../../services/condominios';
export default {
    props: {
        id: Number,
        nome: String,
        bairro: String,
        apartamentos: Array,
        areaTotal: Number,
        valorIptu: Number
    },
    data() {
        return {
            condominios: []
        }
    },
    mounted() {
        Condominio.listar().then(resposta => {
            this.condominios = resposta.data;
        })
    },
    methods: {
        deletar(id) {
            Condominio.deletar(id).then(() => {
                alert('Excluido com sucesso!')
            })
    }
}
}

</script>
<style lang="">
    
</style>