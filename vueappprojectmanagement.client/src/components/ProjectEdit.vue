<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="edit()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_name">Name</label>
              <input id="project_name" name="Name" class="form-control" v-model="project.name" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_cust">Customer</label>
              <input id="project_cust" name="Customer" class="form-control" v-model="project.customer" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_start">Start date</label>
              <input id="project_start" name="StartDate" class="form-control" v-model="project.startDate" type="datetime" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_end">End date</label>
              <input id="project_end" name="EndDate" class="form-control" v-model="project.endDate" type="datetime" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="project_pm">Project manager</label>

              <input id="project_pm" name="Manager" class="form-control" v-model="project.projectManager" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/project">Back</router-link>
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
  name: 'ProjectEdit',
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
    },
    edit() {
      Service.edit(this.$route.params.id, this.project).then(() => {
        this.$router.push('/project')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
