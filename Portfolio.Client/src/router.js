import Vue from 'vue'
import Router from 'vue-router'
import Home from './components/Home.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  fallback: false,
  scrollBehavior: () => ({ y: 0 }),
  routes: [
    {
      path: '/',
      component: Home,
      children: [
        { path: '/index', component: Home },
        { path: '/home', component: Home }
      ]
    },
    { path: '/about', name: 'About', component: () => import('./components/About.vue') },
    { path: '/article/:id', name: 'Article', component: () => import('./components/ViewArticle.vue') },
    { path: '/contact', name: 'Contact', component: () => import('./components/Contact.vue') },
    { path: '/*', name: 'Not Found', component: () => import('./components/NotFound.vue') },
  ]
})


