<script setup>
  import '@/assets/index.css';
</script>

<template>
    <div>
      <h1>Entretenimento</h1>
      <p>Bem-vindo à página de entretenimento!</p>
    </div>
    <div>
        <div class="box-item"><RouterLink to="/entretenimento/filmes" class="routerlink">Filmes</RouterLink></div>
        <div class="box-item"><RouterLink to="/entretenimento/visitas" class="routerlink">Visitas</RouterLink></div>
    </div>
  </template>
  
  <script setup>
  </script>
  
  <style scoped>
  /* Adicione seus estilos aqui */
  </style>