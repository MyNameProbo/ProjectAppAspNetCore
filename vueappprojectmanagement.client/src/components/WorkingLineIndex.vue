<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table table-striped table-hover">
          <thead>
            <tr>
              <th>Line Id</th>
              <th>Material</th>
              <th>Qty</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="project in projects" :key="project">
              <td class="text-center">{{workingline.LineId}}</td>
              <td>{{workingline.MaterialName}}</td>
              <td class="text-center">{{workingline.Qty}}</td>
              <td class="text-center">
                <router-link class="btn btn-secondary" :to="'/working/${workingline.WorkingId}'" title="View"><i class="fa fa-eye"></i></router-link>
                <router-link class="btn btn-primary" :to="'/workingedit'" title="Edit"><i class="fa fa-pencil"></i></router-link>
                <router-link class="btn btn-danger" :to="'/workingdelete/${workingline.WorkingId}'" title="Delete"><i class="fa fa-times"></i></router-link>
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
  name: 'WorkingLineIndex',
  data() {
    return {
      workinglines: []
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      Service.getLine().then(response => {
        this.workinglines = response.data
      }).catch(e => {
        alert(e.response.data)
      })
    }
  }
}
</script>
