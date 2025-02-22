<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_id">Material Code</label>
              <input readonly id="material_id" name="Id" class="form-control" :value="material.MaterialId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_desc">Description</label>
              <input readonly id="material_desc" name="Description" class="form-control" :value="material.Description" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_spec">Specification</label>
              <input readonly id="material_spec" name="Specification" class="form-control" :value="material.Spec" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_qty">Quantity</label>
              <input readonly id="material_qty" name="Quantity" class="form-control" :value="material.Quantity" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_unit">Unit</label>
              <input readonly id="material_unit" name="Unit" class="form-control" :value="material.Unit" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/material">Back</router-link>
              <router-link class="btn btn-primary" :to="'/materialedit/${material.MaterialId}'">Edit</router-link>
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
  name: 'MaterialDetail',
  data() {
    return {
      material: {}
    }
  },
  mounted() {
    this.get()
  },
  methods: {
    get() {
      return Service.getMaterial(this.$route.params.id).then(response => {
        this.material = response.data
      })
    }
  }
}
</script>
