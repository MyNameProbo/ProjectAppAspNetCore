<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table table-striped table-hover">
          <thead>
            <tr>
              <th>Worker Id</th>
              <th>Name</th>
              <th>Job</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="worker in workers" :key="project">
              <td class="text-center">{{worker.workerId}}</td>
              <td>{{worker.name}}</td>
              <td class="text-center">{{worker.job}}</td>
              <td class="text-center">
                <router-link class="btn btn-secondary" :to="'/worker/${worker.workerId}'" title="View"><i class="fa fa-eye"></i></router-link>
                <router-link class="btn btn-primary" :to="'/workeredit'" title="Edit"><i class="fa fa-pencil"></i></router-link>
                <router-link class="btn btn-danger" :to="'/workerdelete/${worker.workerId}'" title="Delete"><i class="fa fa-times"></i></router-link>
              </td>
            </tr>
          </tbody>
        </table>
        <router-link class="btn btn-primary" to="/workercreate">Create</router-link>
      </div>
    </div>
  </div>
</template>
<script>
import Service from './Service'

export default {
  name: 'WorkerIndex',
  data() {
    return {
      workers: []
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      Service.getWorker().then(response => {
        this.workers = response.data
      }).catch(e => {
        alert(e.response.data)
      })
    }
  }
}
</script>
