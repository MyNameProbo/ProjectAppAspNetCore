<template>
  <div>
    <router-link to="/project">Project</router-link>
    <router-link to="/worker">Worker</router-link>
    <router-link to="/material">Material</router-link>
    <router-link to="/working">Working</router-link>
  </div>
    <router-view />
</template>

<script>
  export default {
    name: 'App'
  }
</script>
