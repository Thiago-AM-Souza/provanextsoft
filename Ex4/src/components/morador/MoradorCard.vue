<template lang="">
    <div class="pt-3 col-4">
        <div class="card mt-3 me-3" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title">Nome: {{nome}}</h5>
                <h6 class="card-subtitle mb-2 text-muted">Idade: {{idade}}</h6>
                <h6 class="card-subtitle mb-2 text-muted">Familia Id: {{familiaId}}</h6>
                <router-link :to="{name: 'moradoredit', params:{id:id}}">
                    <button class="btn btn-primary me-2">Editar</button>
                </router-link>
                <button @click="deletar(id)" class="btn btn-primary">Deletar</button>
            </div>
        </div>
    </div>
</template>
<script>
import Morador from '../../services/moradores';
export default {
    props: {
        id: Number,
        nome: String,
        idade: Number,
        familiaId: Number,
    },
    data() {
        return {
            moradores: []
        }
    },
    mounted() {
        Morador.listar().then(resposta => {
            this.moradores = resposta.data;
        })
    },
    methods: {
        deletar(id) {
            Morador.deletar(id).then(() => {
                alert('Excluido com sucesso!')
            })
            window.location.reload()
    }
}
}

</script>
<style>
    
</style>