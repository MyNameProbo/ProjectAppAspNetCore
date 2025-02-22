<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="this.delete()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_id">Material Code</label>
              <input readonly id="material_id" name="Id" class="form-control" :value="material.materialId" type="text" required />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_desc">Description</label>
              <input readonly id="material_desc" name="Description" class="form-control" :value="material.description" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_spec">Specification</label>
              <input readonly id="material_spec" name="Specification" class="form-control" :value="material.spec" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_qty">Quantity</label>
              <input readonly id="material_qty" name="Quantity" class="form-control" :value="material.quantity" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_unit">Unit</label>
              <input readonly id="material_unit" name="Unit" class="form-control" :value="material.unit" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/material">Cancel</router-link>
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
  name: 'MaterialDelete',
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
      return Service.deleteMaterial(this.$route.params.id).then(response => {
        this.material = response.data
      })
    },
    delete() {
      Service.deleteMaterial(this.$route.params.id, this.worker).then(() => {
        this.$router.push('/material')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
