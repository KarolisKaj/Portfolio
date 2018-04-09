import Vue from 'vue'
import Home from '@/components/Home'
import About from '@/components/About'
import NotFound from '@/components/NotFound'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

export default new VueRouter({
  mode: 'history',
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
    { path: '/about', component: About },
    { path: '*', component: NotFound }
  ]
})
