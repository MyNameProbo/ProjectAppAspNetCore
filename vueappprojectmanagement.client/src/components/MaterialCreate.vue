<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <form method="post" @submit.prevent="create()">
          <div class="row">
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_desc">Description</label>
              <input id="material_desc" name="Description" class="form-control" v-model="material.Description" maxlength="300" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_spec">Specification</label>
              <input id="material_spec" name="Job" class="form-control" v-model="material.Spec" maxlength="50" />
            </div>
            <div class="mb-3 col-md-6 col-lg-4">
              <label class="form-label" for="material_qty">Quantity</label>
              <input id="material_qty" name="Quantity" class="form-control" v-model="material.Quantity" maxlength="50" />
            </div>
            <div class="col-12">
              <router-link class="btn btn-secondary" to="/material">Cancel</router-link>
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
  name: 'MaterialCreate',
  data() {
    return {
      material: {}
    }
  },
  methods: {
    create() {
      Service.createMaterial(this.material).then(() => {
        this.$router.push('/material')
      }).catch((e) => {
        alert(e.response.data)
      })
    }
  }
}
</script>
