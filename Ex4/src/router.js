import Vue from 'vue';
import Router from 'vue-router';
import InicioVue from './components/Inicio.vue';
import CondominioVue from './components/condominio/Condominio.vue';
import FamiliaVue from './components/familia/Familia.vue';
import MoradorVue from './components/morador/Morador.vue';
import ApartamentoVue from './components/apartamento/Apartamento.vue';
//import CondominioEditVue from './components/condominio/CondominioEdit.vue';
import CondominioCreateVue from './components/condominio/CondominioCreate.vue';
import CondominioEditVue from './components/condominio/CondominioEdit.vue';


Vue.use(Router)

export default new Router({
    mode: 'history',
    routes: [{
        path: '/', 
        component: InicioVue
    }, {
        path: '/condominio',
        component: CondominioVue        
    },{
        path: '/condominio/:id',
        component: CondominioEditVue,
        name: 'editar' 
    },{
        path: '/condominiocreate',
        component: CondominioCreateVue,
        name: 'condominiocreate'
    }, {
        path: '/familia',
        component: FamiliaVue,
        name: 'familia'
    }, {
        path: '/morador',
        component: MoradorVue,
        name: 'morador'
    }, {
        path: '/apartamento',
        component: ApartamentoVue,
        name: 'apartamento'
    }]
})