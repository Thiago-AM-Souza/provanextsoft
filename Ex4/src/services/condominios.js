
//import { get } from 'core-js/core/dict';
import { http } from './config';

export default {
    listar: () => {
        return http.get('condominios');
    },

    salvar: (condominio) => {
        return http.post('condominios', condominio);
    },

    atualizar: (condominio) => {
        return http.put(`condominios/${condominio.id}`, condominio);
    },

    deletar: (id) => {
        return http.delete(`condominios/${id}`);
    }
}