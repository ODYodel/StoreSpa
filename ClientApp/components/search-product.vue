<template>
    <div>
        <div class="row">
            <div class="col-md-3 col-md-offset-5">
                <form class="col-md-8 input-group" v-on:submit="search">
                    <input type="text" class="form-control" v-model="searchTerm" placeholder="Search for an Item..." />
                    <span class="input-group-btn">
                        <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
                    </span>
                </form>
            </div>
        </div>
        <div v-if="requestError">A problem occured please try your request again.</div>
        <div class="col-md-12 text-center" v-if="isSearching"><img class="loader-container" src="../resources/walmart-loader.gif" /></div>
        <ProductResultsGrid v-if="products" :products="this.products.items"></ProductResultsGrid>

    </div>
</template>
<script>
    import ProductResultsGrid from './product-results-grid.vue';

    export default {
    name: "SearchProduct",
    data() {
        return {
            searchTerm: '',
            isSearching: false,
            products: null,
            requestError: false,
        }
        },
        beforeRouteEnter(to, from, next) {
            next(vm => {
                vm.products = null;
                vm.searchTerm = '';
            })
            next();
        },
    components: {
        ProductResultsGrid
    },

    methods: {
        search: async function (event) {
            event.preventDefault();
            if (this.searchTerm !== "") {
                this.isSearching = true;
                this.products = null;
                try {
                    let response = await this.$http.get('/api/product/search?product=' + this.searchTerm)
                        .catch(function (error) {
                            this.requestError = true;
                        });
                    this.products = response.data;
                } catch (error) {
                    console.log(error)
                }
                this.isSearching = false;
            }
        }
    },
}</script>
<style>
    form {
        padding-bottom: 2rem;
    }
    .loader-container {
        max-width: 250px;
    }
</style>
