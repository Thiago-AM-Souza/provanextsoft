import Vue from 'vue';
import App from './App.vue';
import router from './router';

import bootstrap from './plugins/bootstrap';

Vue.config.productionTip = false

Vue.use(bootstrap);

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
