<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_id">Project code</label>
              <input readonly id="project_id" name="Id" class="form-control" :value="project.ProjectId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_name">Name</label>
              <input readonly id="project_name" name="Name" class="form-control" :value="project.Name" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_cust">Customer</label>
              <input readonly id="project_cust" name="Customer" class="form-control" :value="project.Customer" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_stage">Stage</label>
              <input readonly id="project_stage" name="Stage" class="form-control" :value="project.Stage" type="number" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_start">Start date</label>
              <input readonly id="project_start" name="Start" class="form-control" :value="project.StartDate" type="datetime" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_end">End date</label>
              <input readonly id="project_end" name="End" class="form-control" :value="project.EndDate" type="datetime" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_pm">Project manager</label>
              <input readonly id="project_pm" name="ProjectManager" class="form-control" :value="project.ProjectManager" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/project">Back</router-link>
              <router-link class="btn btn-primary" :to="'/projectedit/${project.ProjectId}'">Edit</router-link>
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
  name: 'ProjectDetail',
  data() {
    return {
      project: {}
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      return Service.get(this.$route.params.id).then(response => {
        this.project = response.data
      })
    }
  }
}
</script>
