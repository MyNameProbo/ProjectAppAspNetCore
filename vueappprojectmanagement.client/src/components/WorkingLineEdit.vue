<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_material">Material</label>
              <input id="line_material" name="Material" class="form-control" :value="workingline.materialName" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="line_qty">Qty</label>
              <input id="line_qty" name="Qty" class="form-control" :value="workingline.qty" maxlength="50" />
            </div>                        
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/workingline">Back</router-link>
              <router-link class="btn btn-primary" :to="/workinglineedit/${workingline.lineId}"">Edit</router-link>
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
  name: 'WorkingLineEdit',
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
      return Service.getLine(this.$route.params.id).then(response => {
        this.workingline = response.data
      })
    }
  }
}
</script>
