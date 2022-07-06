<template>
    <div>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <ul class="navbar-nav">
                    <img src="../../assets/logo_vetor.svg" class ="img-thumbnail me-3" width="150" height="45"  alt="logo">
                    <li><router-link to="/" class="navbar-brand">Inicio</router-link></li>
                    <li><router-link to="/condominio" class="navbar-brand">Condominios</router-link></li>
                    <li><router-link to="/apartamento" class="navbar-brand">Apartamentos</router-link></li>
                    <li><router-link to="/familia" class="navbar-brand">Familias</router-link></li>
                    <li><router-link to="/morador" class="navbar-brand">Moradores</router-link></li>
                </ul>
            </div>
        </nav>   
    </div>
</template>
<script>
export default {
    
}
</script>
<style>

</style>