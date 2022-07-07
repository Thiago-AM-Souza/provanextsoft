
import { http } from './config';

export default {
    listar: () => {
        return http.get('familias');
    },

    salvar: (familia) => {
        return http.post('familias', familia);
    },

    atualizar: (familia) => {
        return http.put(`familias/${familia.id}`, familia);
    },

    deletar: (id) => {
        return http.delete(`familias/${id}`);
    }
}