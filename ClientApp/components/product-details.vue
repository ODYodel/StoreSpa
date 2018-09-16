<template>
    <div class="col-lg-6">
        <h2 class="col-lg-12">{{this.details.name}}</h2>
        <p class="col-lg-12"><img :src="this.details.customerRatingImage" /> {{this.details.customerRating}}</p>
        <p class="col-lg-12">{{this.details.shortDescription}}</p>
        <span class="salePrice col-lg-1">${{this.details.salePrice}}</span><span v-if="this.details.msrp !== undefined" class="msrp col-lg-1">${{this.details.msrp}}</span>
    </div>
</template>
<script>

    export default {
        name: "ProductDetails",
        props: {
            details: null,
        },
        methods: {
        },
    }</script>
<style scoped>
    .salePrice {
        font-weight: bold;
    }
    .msrp {
        color: #808080;
        text-decoration: line-through;
    }
</style>
