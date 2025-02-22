<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="create()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_name">Name</label>
              <input id="worker_name" name="Name" class="form-control" v-model="worker.Name" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="worker_job">Job</label>
              <input id="worker_job" name="Job" class="form-control" v-model="worker.Job" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/worker">Cancel</router-link>
              <button class="btn btn-primary">Submit</button>
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
  name: 'WorkerCreate',
  data() {
    return {
      worker: {}
    }
  },
  methods: {
    create() {
      Service.createWorker(this.worker).then(() => {
        this.$router.push('/worker')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
