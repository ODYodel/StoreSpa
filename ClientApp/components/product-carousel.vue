<template>
    <div class="col-md-12 carousel-view">
        <transition-group class="carousel" tag="div">
            <div v-for="item in listOfItems" class="slide" :key="item.itemId">
                <router-link class="text-center" :to="{ name: 'ViewProduct', params: { itemId: item.itemId }}"><img :src="item.thumbnailImage" /><span class="col-md-12">{{item.name}}</span></router-link>
            </div>
        </transition-group>
        <div class="carousel-controls">
            <button class="carousel-previous_button" v-on:click="previous"><span class="glyphicon glyphicon-chevron-left"></span></button>
            <button class="carousel-next_button" v-on:click="next"><span class="glyphicon glyphicon-chevron-right"></span></button>
        </div>
    </div>
</template>
<script>

    export default {
        name: "ProductCarousel",
        props: {
            items: null,
        },
        computed: {
            listOfItems: function () {
                return this.items;
            },
        },
        methods: {
            next: function () {
                const first = this.listOfItems.shift();
                this.listOfItems.push(first);
            },
            previous: function () {
                const last = this.listOfItems.pop();
                this.listOfItems.unshift(last);
            }
        },
    }
</script>
<style scoped>
    .carousel-view {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .carousel {
        display: flex;
        justify-content: center;
        align-items: center;
        overflow: hidden;
    }

    .slide {
        flex: 0 0 20em;
        display: flex;
        justify-content: center;
        align-items: center;
        transition: transform 0.3s ease-in-out;
    }

        .slide:first-of-type {
            opacity: 0;
        }

        .slide:last-of-type {
            opacity: 0;
        }
    .carousel-previous_button {
        position: absolute;
        top: 54px;
        left: -25px;
        z-index: 100;
    }
    .carousel-next_button {
        position: absolute;
        top: 54px;
        right: -25px;
        z-index: 100;
    }
</style>
