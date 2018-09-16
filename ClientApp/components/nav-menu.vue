<template>
    <div class="main-nav">
        <div class="navbar navbar-inverse navbar-static-top navbar-custom-walmart">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" v-on:click="toggleCollapsed">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/">A Store Prototype</a>
            </div>
            <transition name="slide">
                <div class="navbar-collapse collapse in" v-show="!collapsed">
                    <ul class="nav navbar-nav navbar-custom-nav-walmart">
                        <li v-for="route in routes">
                            <router-link :to="route.path">
                                <span :class="route.style"></span> {{ route.display }}
                            </router-link>
                        </li>
                    </ul>
                </div>
            </transition>
        </div>
    </div>
</template>
<script>
    import { routes } from '../routes'

    export default {
        data() {
            return {
                routes,
                collapsed: true
            }
        },
        methods: {
            toggleCollapsed: function (event) {
                this.collapsed = !this.collapsed;
            }
        }
    }
</script>
<style>
    .navbar-custom-walmart {
        background-color: #0071ceff;
    }

    .navbar-inverse .navbar-brand {
        color: #fff;
    }

    .navbar-inverse .navbar-brand:hover {
        color: #ffc220;
    }

    .navbar-inverse .navbar-nav > li > a {
        color: #fff;
    }

    .navbar-inverse .navbar-nav > li > a:focus, .navbar-inverse .navbar-nav > li > a:hover {
        color: #ffc220;
    }

    .slide-enter-active, .slide-leave-active {
        transition: max-height .35s
    }

    .slide-enter, .slide-leave-to {
        max-height: 0px;
    }

    .slide-enter-to, .slide-leave {
        max-height: 20em;
    }
</style>
