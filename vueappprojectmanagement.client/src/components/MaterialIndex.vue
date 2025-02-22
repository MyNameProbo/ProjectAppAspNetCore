<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table table-striped table-hover">
          <thead>
            <tr>
              <th>Material Code</th>
              <th>Description</th>
              <th>Specification</th>
              <th>Quantity</th>
              <th>Unit</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="project in projects" :key="project">
              <td class="text-center">{{material.MaterialId}}</td>
              <td>{{material.Description}}</td>
              <td class="text-center">{{material.Spec}}</td>
              <td class="text-center">{{material.Quantity}}</td>
              <td class="text-center">{{material.Unit}}</td>
              <td class="text-center">
                <router-link class="btn btn-secondary" :to="'/project/${material.MaterialId}'" title="View"><i class="fa fa-eye"></i></router-link>
                <router-link class="btn btn-primary" :to="'/projectedit'" title="Edit"><i class="fa fa-pencil"></i></router-link>
                <router-link class="btn btn-danger" :to="'/projectdelete/${material.MaterialId}'" title="Delete"><i class="fa fa-times"></i></router-link>
              </td>
            </tr>
          </tbody>
        </table>
        <router-link class="btn btn-primary" to="/projectcreate">Create</router-link>
      </div>
    </div>
  </div>
</template>
<script>
import Service from './Service'

export default {
  name: 'MaterialIndex',
  data() {
    return {
      materials: []
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      Service.getMaterial().then(response => {
        this.materials = response.data
      }).catch(e => {
        alert(e.response.data)
      })
    }
  }
}
</script>
