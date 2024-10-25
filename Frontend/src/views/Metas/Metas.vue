<script setup>
import { ref, onMounted } from 'vue';

// Criando referência reativa para os dados e a lista de objetos
const dados = ref("");
const objlist = ref([]);

// Função para buscar a API
const fetchApi = async () => { 
    try {
        const response = await fetch(`http://localhost:7198/api/meta`);
        const data = await response.json();

        // Preenche a lista de objetos reativamente
        objlist.value = data.map(item => ({
            Id: item.id,
            NomeMeta: item.nomeMeta,
            DataObjetivo: item.dataObjetivo,
            ValorAdquirido: item.valorAdquirido,
            ValorTotalMeta: item.valorTotalMeta,
            MetaStatus: item.metaStatus
        }));
        
    } catch (erro) {
        console.log(erro);
    }
};

// Chamar fetchApi quando o componente for montado
onMounted(() => {
    fetchApi();
});
</script>

<template>
    <div>
      <h1>Metas</h1>
      <p>Bem-vindo à página de Metas</p>
    </div>

    <!-- Exibindo o resultado da API -->
    <div id="dados">{{ dados }}</div>

    <!-- Exibindo a lista de objetos -->
    <div>
        <ul>
            <li v-for="(value, index) in objlist" :key="index">
                ID: {{ value.Id }}, Nome: {{ value.NomeMeta }}, Data Objetivo: {{ value.DataObjetivo }}, Valor Adquirido: {{ value.ValorAdquirido }}, Valor Total Meta: {{ value.ValorTotalMeta }}, Status: {{ value.MetaStatus }}
            </li>
        </ul>
    </div>
</template>

<style scoped>
#btn-go {
    border: 1px solid black;
    padding: 10px;
    cursor: pointer;
}

#dados {
    margin-top: 10px;
    font-weight: bold;
}

ul {
    list-style-type: none;
    padding: 0;
}

li {
    margin: 5px 0;
    background-color: #f9f9f9;
    padding: 10px;
    border-radius: 5px;
}
</style>
