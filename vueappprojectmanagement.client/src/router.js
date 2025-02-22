import { createWebHistory, createRouter } from 'vue-router'

const routes = [
  {
    path: '/',
    redirect: '/project'
  },
  {
    path: '/project',
    name: 'project',
    component: () => import('./components/ProjectIndex.vue')
  },
  {
    path: '/projectcreate',
    component: () => import('./components/ProjectCreate.vue')
  },
  {
    path: '/project/:id/',
    component: () => import('./components/ProjectDetail.vue')
  },
  {
    path: '/projectedit',
    component: () => import('./components/ProjectEdit.vue')
  },
  {
    path: '/projectdelete/:id/',
    component: () => import('./components/ProjectDelete.vue')
  },
  {
    path: '/worker',
    name: 'worker',
    component: () => import('./components/WorkerIndex.vue')
  },
  {
    path: '/workercreate',
    component: () => import('./components/WorkerCreate.vue')
  },
  {
    path: '/worker/:id/',
    component: () => import('./components/WorkerDetail.vue')
  },
  {
    path: '/workeredit',
    component: () => import('./components/WorkerEdit.vue')
  },
  {
    path: '/workerdelete/:id/',
    component: () => import('./components/WorkerDelete.vue')
  },
  {
    path: '/material',
    name: 'material',
    component: () => import('./components/MaterialIndex.vue')
  },
  {
    path: '/materialcreate',
    component: () => import('./components/MaterialCreate.vue')
  },
  {
    path: '/material/:id/',
    component: () => import('./components/MaterialDetail.vue')
  },
  {
    path: '/materialedit',
    component: () => import('./components/MaterialEdit.vue')
  },
  {
    path: '/materialdelete/:id/',
    component: () => import('./components/MaterialDelete.vue')
  },
  {
    path: '/working',
    name: 'working',
    component: () => import('./components/WorkingIndex.vue')
  },
  {
    path: '/workingcreate',
    component: () => import('./components/WorkingCreate.vue')
  },
  {
    path: '/working/:id/',
    component: () => import('./components/WorkingDetail.vue')
  },
  {
    path: '/workingedit',
    component: () => import('./components/WorkingEdit.vue')
  },
  {
    path: '/workingdelete/:id/',
    component: () => import('./components/WorkingDelete.vue')
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router
