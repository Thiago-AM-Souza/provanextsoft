
import { http } from './config';

export default {
    listar: () => {
        return http.get('apartamentos');
    },

    salvar: (apartamento) => {
        return http.post('apartamentos', apartamento);
    },

    atualizar: (apartamento) => {
        return http.put(`apartamentos/${apartamento.id}`, apartamento);
    },

    deletar: (id) => {
        return http.delete(`apartamentos/${id}`);
    }
}