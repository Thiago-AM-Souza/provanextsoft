
import { http } from './config';

export default {
    listar: () => {
        return http.get('moradores');
    },

    salvar: (morador) => {
        return http.post('moradores', morador);
    },

    atualizar: (morador) => {
        return http.put(`moradores/${morador.id}`, morador);
    },

    deletar: (id) => {
        return http.delete(`moradores/${id}`);
    }
}