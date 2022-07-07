import Vue from 'vue';
import Router from 'vue-router';
import InicioVue from './components/Inicio.vue';
import CondominioVue from './components/condominio/Condominio.vue';
import FamiliaVue from './components/familia/Familia.vue';
import MoradorVue from './components/morador/Morador.vue';
import ApartamentoVue from './components/apartamento/Apartamento.vue';
import ApartamentoCreateVue from './components/apartamento/ApartamentoCreate.vue';
import ApartamentoEditVue from './components/apartamento/ApartamentoEdit.vue';
import CondominioCreateVue from './components/condominio/CondominioCreate.vue';
import CondominioEditVue from './components/condominio/CondominioEdit.vue';
import FamiliaCreateVue from './components/familia/FamiliaCreate.vue';
import FamiliaEditVue from './components/familia/FamiliaEdit.vue';
import MoradorEditVue from './components/morador/MoradorEdit.vue';
import MoradorCreateVue from './components/morador/MoradorCreate.vue';


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
        name: 'condominioedit' 
    },{
        path: '/condominiocreate',
        component: CondominioCreateVue,
        name: 'condominiocreate'
    }, {
        path: '/familia',
        component: FamiliaVue,
        name: 'familia'
    }, {
        path: '/familia/:id',
        component: FamiliaEditVue,
        name: 'familiaedit'
    }, {
        path: '/familiacreate',
        component: FamiliaCreateVue,
        name: 'familiacreate'
    }, {
        path: '/morador',
        component: MoradorVue,
        name: 'morador'
    }, {
        path: '/morador/:id',
        component: MoradorEditVue,
        name: 'moradoredit'
    }, {
        path: '/moradorcreate',
        component: MoradorCreateVue,
        name: 'moradorcreate'
    }, {
        path: '/apartamento',
        component: ApartamentoVue,
        name: 'apartamento'
    }, {
        path:'/apartamentocreate',
        component:  ApartamentoCreateVue,
        name:'apartamentocreate'
    },{
        path:'/apartamento/:id',
        component: ApartamentoEditVue,
        name: 'apartamentoedit'
    }]
})