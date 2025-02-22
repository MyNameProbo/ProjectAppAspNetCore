<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table table-striped table-hover">
          <thead>
            <tr>
              <th>Working Id</th>
              <th>Description</th>
              <th>Date</th>
              <th>Project</th>
              <th>Worker</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="project in projects" :key="project">
              <td class="text-center">{{working.WorkingId}}</td>
              <td>{{working.Description}}</td>
              <td class="text-center">{{working.Date}}</td>
              <td class="text-center">{{working.ProjectId}}</td>
              <td class="text-center">{{working.WorkerId}}</td>
              <td class="text-center">
                <router-link class="btn btn-secondary" :to="'/working/${working.WorkingId}'" title="View"><i class="fa fa-eye"></i></router-link>
                <router-link class="btn btn-primary" :to="'/workingedit'" title="Edit"><i class="fa fa-pencil"></i></router-link>
                <router-link class="btn btn-danger" :to="'/workingdelete/${working.WorkingId}'" title="Delete"><i class="fa fa-times"></i></router-link>
              </td>
            </tr>
          </tbody>
        </table>
        <router-link class="btn btn-primary" to="/workingcreate">Create</router-link>
      </div>
    </div>
  </div>
</template>
<script>
import Service from './Service'

export default {
  name: 'WorkingIndex',
  data() {
    return {
      workings: []
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      Service.get().then(response => {
        this.workings = response.data
      }).catch(e => {
        alert(e.response.data)
      })
    }
  }
}
</script>
