<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table table-striped table-hover">
          <thead>
            <tr>
              <th>Project Code</th>
              <th>Name</th>
              <th>Customer</th>
              <th>Stage</th>
              <th>Start date</th>
              <th>End date</th>
              <th>Project manager</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="project in projects" :key="project">
              <td class="text-center">{{project.projectId}}</td>
              <td>{{project.name}}</td>
              <td class="text-center">{{project.customer}}</td>
              <td class="text-center">{{project.stage}}</td>
              <td class="text-center">{{project.startDate}}</td>
              <td class="text-center">{{project.endDate}}</td>
              <td class="text-center">{{project.projectManager}}</td>
              <td class="text-center">
                <router-link class="btn btn-secondary" :to="'/project/${project.projectId}'" title="View"><i class="fa fa-eye"></i></router-link>
                <router-link class="btn btn-primary" :to="'/projectedit'" title="Edit"><i class="fa fa-pencil"></i></router-link>
                <router-link class="btn btn-danger" :to="'/projectdelete/${project.projectId}'" title="Delete"><i class="fa fa-times"></i></router-link>
              </td>
            </tr>
          </tbody>
        </table>
        <router-link class="btn btn-primary" to="/projectcreate">Create</router-link>
      </div>
    </div>
  </div>
</template>

<script lang="js">
import Service from './Service'

export default {
  name: 'ProjectIndex',
  data() {
    return {
      projects: []
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      Service.get().then(response => {
        this.projects = response.data
      }).catch(e => {
        alert(e.response.data)
      })
    }
  }
}
</script>
