<template lang="">
    <div class="pt-3 col-4">
        <div class="card mt-3 me-3" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title">Nome: {{nome}}</h5>
                <h6 class="card-subtitle mb-2 text-muted">Apartamento Id: {{apartamentoId}}</h6>
                <router-link :to="{name: 'familiaedit', params:{id:id}}">
                    <button class="btn btn-primary me-2">Editar</button>
                </router-link>
                <button @click="deletar(id)" class="btn btn-primary">Deletar</button>
            </div>
        </div>
    </div>
</template>
<script>
import Familia from '../../services/familias';
export default {
    props: {
        id: Number,
        nome: String,
        apartamentoId: Number,
        moradores: Array,
    },
    data() {
        return {
            familias: []
        }
    },
    mounted() {
        Familia.listar().then(resposta => {
            this.familias = resposta.data;
        })
    },
    methods: {
        deletar(id) {
            Familia.deletar(id).then(() => {
                alert('Excluido com sucesso!')
            })
            window.location.reload()
    }
}
}

</script>
<style>
    
</style>