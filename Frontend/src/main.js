import { createApp } from 'vue'; // Importa a função CreateApp do vue
import App from './App.vue';
import router from './router/index'; // Ajuste o caminho para o arquivo do roteador// Ajuste o caminho para a configuração do Vuetify (se estiver usando Vuetify)
import vuetify from './plugins/vuetify'; // Importa o plugin do vuetify
import './assets/index.css';

// Crie a aplicação Vue
const app = createApp(App);

// Use o Vue Router
app.use(router);

app.use(vuetify);

// Monte o aplicativo no elemento com id 'app'
app.mount('#app');
