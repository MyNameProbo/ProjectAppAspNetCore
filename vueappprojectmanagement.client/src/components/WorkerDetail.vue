<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_id">Worker id</label>
              <input readonly id="worker_id" name="Id" class="form-control" :value="worker.WorkerId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_name">Name</label>
              <input readonly id="worker_name" name="Name" class="form-control" :value="worker.Name" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_cust">Job</label>
              <input readonly id="worker_job" name="Job" class="form-control" :value="worker.Job" maxlength="50" />
            </div>            
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/worker">Back</router-link>
              <router-link class="btn btn-primary" :to="'/workeredit/${worker.WorkerId}'">Edit</router-link>
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
  name: 'WorkerDetail',
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
      return Service.getWorker(this.$route.params.id).then(response => {
        this.worker = response.data
      })
    }
  }
}
</script>
