<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_desc">Description</label>
              <input id="working_desc" name="Description" class="form-control" :value="working.Description" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_date">Date</label>
              <input id="working_date" name="Date" class="form-control" :value="working.Date" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_project">Project</label>
              <input id="working_project" name="Project" class="form-control" :value="working.ProjectId" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_worker">Worker</label>
              <input id="working_worker" name="worker" class="form-control" :value="working.WorkerId" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/working">Back</router-link>
              <router-link class="btn btn-primary" :to="/workingedit/${working.WorkingId}" ">Edit</router-link>
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
  name: 'WorkingEdit',
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
      return Service.getWorking(this.$route.params.id).then(response => {
        this.working = response.data
      })
    }
  }
}
</script>
