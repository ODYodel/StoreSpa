import SearchProduct from 'components/search-product'
import ViewProduct from 'components/view-product'
import ProductResults from 'components/product-results-grid'

export const routes = [
    { path: '/', component: SearchProduct, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/search-product', component: SearchProduct, display: 'Search Products', style: 'glyphicon glyphicon-th-list' },
    { path: '/view-product/:itemId', name: 'ViewProduct', component: ViewProduct, props: true },
    { path: '/view-results/:searchTerms', name: 'ViewResults', component: ProductResults, props: true },
]
