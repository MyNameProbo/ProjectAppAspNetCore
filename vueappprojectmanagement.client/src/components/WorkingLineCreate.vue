<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="create()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_material">Material</label>
              <input id="line_material" name="Material" class="form-control" v-model="workingline.materialName" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_qty">Qty</label>
              <input id="line_qty" name="Qty" class="form-control" v-model="workingline.qty" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_working">Working</label>
              <input id="line_working" name="Qty" class="form-control" v-model="workingline.workingId" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/workingline">Cancel</router-link>
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
  name: 'WorkingLineCreate',
  data() {
    return {
      workingline: {}
    }
  },
  methods: {
    create() {
      Service.createLine(this.workingline).then(() => {
        this.$router.push('/workingline')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
