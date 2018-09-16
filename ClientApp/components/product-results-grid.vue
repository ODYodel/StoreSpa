<template>
    <div class="container">
        <div v-if="products">
            <div class="product row" v-for="i in rowCount">
                <div class="col-md-3 product" v-for="product in rowOfProducts(i)">
                    <router-link :to="{ name: 'ViewProduct', params: { itemId: product.itemId }}">
                        <img :src="product.mediumImage" class="text-center" />
                        <h4>{{product.name}}</h4>
                    </router-link>
                    <p><img :src="product.customerRatingImage" /> {{product.customerRating}}</p>
                    <p>${{product.salePrice}} <span v-if="product.msrp !== null"style="text-decoration:line-through;">${{product.msrp}}</span></p>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        name: "ProductResultsGrid",
        props: {
            products: null
        },
        computed: {
            rowCount: function () {
                return Math.ceil(this.products.length / 4);
            },
        },
        methods: {
            rowOfProducts: function (i) {
                return this.products.slice((i - 1) * 4, i * 4);
            }
        },
    }</script>
<style scoped>
    .product.row {
        border-top: solid #eee;
        padding: 1rem;
    }
    .product {
        padding:0 1rem 0 1rem 0;
    }
</style>
