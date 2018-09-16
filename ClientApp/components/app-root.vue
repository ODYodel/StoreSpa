<template>
    <div id="app" class="container-fluid">
        <div class="row">
                <nav-menu params="route: route"></nav-menu>
            <div class="col-sm-12">
                <router-view></router-view>
            </div>
        </div>

    </div>

</template>

<script>
import Vue from 'vue'
import NavMenu from './nav-menu'

Vue.component('nav-menu', NavMenu);

export default {
    data() {
        return {
        }
    }
}
</script>

<style scoped>
    #app {
        padding: 0px, 0px, 0px, 0px; 
    }
</style>
