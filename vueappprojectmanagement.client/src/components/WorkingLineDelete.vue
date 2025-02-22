<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="this.delete()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_id">Line Id</label>
              <input readonly id="line_id" name="Id" class="form-control" :value="workingline.lineId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_material">Material</label>
              <input readonly id="line_material" name="Material" class="form-control" :value="workingline.materialName" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_qty">Qty</label>
              <input readonly id="line_qty" name="Qty" class="form-control" :value="workingline.qty" maxlength="50" />
            </div>            
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/workingline">Cancel</router-link>
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
  name: 'WorkingLineDelete',
  data() {
    return {
      workingline: {}
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      return Service.deleteLine(this.$route.params.id).then(response => {
        this.workingline = response.data
      })
    },
    delete() {
      Service.deleteLine(this.$route.params.id, this.workingline).then(() => {
        this.$router.push('/ProjectIndex')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
