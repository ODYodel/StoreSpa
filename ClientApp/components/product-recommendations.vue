<template>
    <div class="col-md-12">
        <h2>Recommended</h2>
        <ProductCarousel :v-if="products != null" :items="products"></ProductCarousel>
    </div>
</template>
<script>
    import ProductCarousel from './product-carousel.vue';

    export default {
        name: "ProductRecommendations",
        components: {
            ProductCarousel
        },
        data() {
            return {
                products: null,
            }
        },
        props: {
            itemId: null,
        },
        methods: {
            getRecommendedItems: async function () {
                this.isSearching = true;
                try {
                    let response = await this.$http.get('/api/product/recommend?itemId=' + this.itemId)
                    console.log(response.data);
                    this.products = response.data;
                } catch (error) {
                    console.log(error)
                }
                this.isSearching = false;
            }
        },

        created() {
            this.getRecommendedItems();
        }
    }</script>
<style>
</style>
