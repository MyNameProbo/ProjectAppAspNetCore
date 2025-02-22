<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="this.delete()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_id">Worker ID</label>
              <input readonly id="worker_id" name="Id" class="form-control" :value="worker.workerId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_name">Name</label>
              <input readonly id="project_name" name="Name" class="form-control" :value="worker.name" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_cust">Job</label>
              <input readonly id="project_cust" name="Job" class="form-control" :value="worker.job" maxlength="50" />
            </div>            
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/worker">Cancel</router-link>
              <button class="btn btn-danger">Delete</button>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>
<script>
import Service from './Service'

export default {
  name: 'WorkerDelete',
  data() {
    return {
      worker: {}
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      return Service.deleteWorker(this.$route.params.id).then(response => {
        this.worker = response.data
      })
    },
    delete() {
      Service.deleteWorker(this.$route.params.id, this.worker).then(() => {
        this.$router.push('/worker')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
