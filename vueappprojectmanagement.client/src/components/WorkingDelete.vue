<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="this.delete()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_id">Working Id</label>
              <input readonly id="working_id" name="Id" class="form-control" :value="working.workingId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_desc">Description</label>
              <input readonly id="working_desc" name="Description" class="form-control" :value="working.description" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_date">Date</label>
              <input readonly id="working_date" name="Date" class="form-control" :value="working.workingDate" type="datetime" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_project">Project</label>
              <input readonly id="working_project" name="Project" class="form-control" :value="working.projectId" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_worker">Worker</label>
              <input readonly id="working_worker" name="Worker" class="form-control" :value="working.workerId" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/working">Cancel</router-link>
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
  name: 'WorkingDelete',
  data() {
    return {
      working: {}
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      return Service.deleteWorking(this.$route.params.id).then(response => {
        this.working = response.data
      })
    },
    delete() {
      Service.deleteWorking(this.$route.params.id, this.worker).then(() => {
        this.$router.push('/working')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
