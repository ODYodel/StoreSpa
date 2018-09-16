<template>
    <div id="Product">
        <div :v-if="product">
            <product-images  :productImg="product.imageEntities.filter(entity => entity.entityType === 'PRIMARY')"></product-images>
            <product-details :details="itemDetails()"></product-details>
        </div>
        <ProductRecommendations :key="keything" :itemId="itemId"></ProductRecommendations>
    </div>
</template>
<script>
    import ProductRecommendations from './product-recommendations.vue';
    import ProductImages from './product-images.vue';
    import ProductDetails from './product-details.vue';

    export default {
        name: "ViewProduct",
        data() {
            return {
                product: null,
                keything: null,
            }
        },
        beforeRouteUpdate(to, from, next) {
            this.itemId = to.params.itemId;
            this.getDetailedItem();
            this.keything = Date.now();
            next();
        },
        components: {
            ProductRecommendations,
            ProductImages,
            ProductDetails,
        },
        props: {
            itemId: null,
        },
        methods: {
            getDetailedItem: async function () {
                console.log(this.itemId)
                try {
                    let response = await this.$http.get('/api/product/lookup?itemId=' + this.itemId)
                    console.log(response.data);
                    this.product = response.data;
                } catch (error) {
                    console.log(error)
                }
            },
            imageEntity: function () {
                if (this.product !== null) {
                    return {
                        thumbnailImage: this.product.thumbnailImage,
                        mediumImage: this.product.mediumImage,
                        largeImage: this.product.largeImage
                    };
                }
            },
            itemDetails: function () {
                if (this.product !== null) {
                    return {
                        name: this.product.name,
                        shortDescription: this.product.shortDescription,
                        customerRatingImage: this.product.customerRatingImage,
                        customerRating: this.product.customerRating,
                        salePrice: this.product.salePrice,
                        msrp: this.product.msrp
                    };
                }
            }
        },

        created: function () {
            this.getDetailedItem();
        }
    }</script>
<style scoped>
    #Product {
        padding: 1rem;
    }
</style>
