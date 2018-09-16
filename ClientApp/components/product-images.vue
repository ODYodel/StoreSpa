<template>
    <div class="col-lg-4">
        <img :src="this.productImg[0].largeImage"/>
    </div>
</template>
<script>
    import ProductRecommendations from './product-recommendations.vue';

    export default {
        name: "ProductImages",
        components: {
            ProductRecommendations
        },
        props: {
            productImg: null,
        },
        methods: {
        },

        //created: async function () {
        //    this.getDetailedItem();
        //}
    }</script>
<style>
</style>
