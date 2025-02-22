<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="create()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_desc">Description</label>
              <input id="working_desc" name="Description" class="form-control" v-model="working.Description" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_date">Date</label>
              <input id="working_date" name="Date" class="form-control" v-model="working.Date" type="datetime" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_project">Project</label>
              <input id="working_project" name="Project" class="form-control" v-model="working.ProjectId" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="working_worker">Worker</label>
              <input id="working_worker" name="Worker" class="form-control" v-model="working.WorkerId" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/working">Cancel</router-link>
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
  name: 'WorkingCreate',
  data() {
    return {
      working: {}
    }
  },
  methods: {
    create() {
      Service.createWorking(this.working).then(() => {
        this.$router.push('/working')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
