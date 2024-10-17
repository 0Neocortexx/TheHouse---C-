import { createRouter, createWebHistory } from 'vue-router';
import Entretenimento from '@/views/Entretenimento/Entretenimento.vue';
import Home from '@/views/Home.vue';
import Filmes from '@/views/Entretenimento/FIlmes.vue'
import Visitas from '@/views/Entretenimento/Visitas.vue';
import Metas from '@/views/Metas/Metas.vue';

const routes = [
  { path: '/', name: 'Home', component: Home},
  {path: '/entretenimento', name: 'Entretenimento', component: Entretenimento},
  {path: '/entretenimento/filmes', name: 'Filmes', component: Filmes},
  {path: '/entretenimento/visitas', name: 'Visitas', component: Visitas},
  {path: '/metas', name: 'Metas', component: Metas}
  // Adicione outras rotas aqui
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;