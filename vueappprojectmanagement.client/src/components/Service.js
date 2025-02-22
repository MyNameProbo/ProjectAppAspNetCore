import http from '../http'

export default {  
  get(id) {
    if (id) {
      return http.get("/ProjectTable/${id}")
    }
    else {
      return http.get('/ProjectTable')
    }
  },
  create(data) {
    if (data) {
      return http.post('/ProjectTable', data)
    }
    else {
      return http.get('/ProjectTable/create')
    }
  },
  edit(data) {
    if (data) {
      return http.post('/ProjectTable/update', data)
    }
    else {
      return http.get('/ProjectTable')
    }
  },
  delete(id, data) {
    if (data) {
      return http.delete('/ProjectTable/${id}')
    }
    else {
      return http.get('/ProjectTable/${id}')
    }
  },
  getWorker(id) {
    if (id) {
      return http.get("WorkerTable/${id}")
    }
    else {
      return http.get('/WorkerTable')
    }
  },
  createWorker(data) {
    if (data) {
      return http.post('/WorkerTable', data)
    }
    else {
      return http.get('/WorkerTable/create')
    }
  },
  editWorker(data) {
    if (data) {
      return http.post('/WorkerTable/update', data)
    }
    else {
      return http.get('/WorkerTable')
    }
  },
  deleteWorker(id, data) {
    if (data) {
      return http.delete('/WorkerTable/${id}')
    }
    else {
      return http.get('/WorkerTable/${id}')
    }
  },
  getMaterial(id) {
    if (id) {
      return http.get("MaterialTable/${id}")
    }
    else {
      return http.get('/MaterialTable')
    }
  },
  createMaterial(data) {
    if (data) {
      return http.post('/MaterialTable', data)
    }
    else {
      return http.get('/MaterialTable/create')
    }
  },
  editMaterial(data) {
    if (data) {
      return http.post('/MaterialTable/update', data)
    }
    else {
      return http.get('/MaterialTable')
    }
  },
  deleteMaterial(id, data) {
    if (data) {
      return http.delete('/MaterialTable/${id}')
    }
    else {
      return http.get('/MaterialTable/${id}')
    }
  },
  getWorking(id) {
    if (id) {
      return http.get("WorkingTable/${id}")
    }
    else {
      return http.get('/WorkingTable')
    }
  },
  createWorking(data) {
    if (data) {
      return http.post('/WorkingTable', data)
    }
    else {
      return http.get('/WorkingTable/create')
    }
  },
  editWorking(data) {
    if (data) {
      return http.post('/MWorkingTable/update', data)
    }
    else {
      return http.get('/WorkingTable')
    }
  },
  deleteWorking(id, data) {
    if (data) {
      return http.delete('/WorkingTable/${id}')
    }
    else {
      return http.get('/WorkingTable/${id}')
    }
  },
  getLine(id) {
    if (id) {
      return http.get("WorkingLineTable/${id}")
    }
    else {
      return http.get('/WorkingLineTable')
    }
  },
  createLine(data) {
    if (data) {
      return http.post('/WorkingLineTable', data)
    }
    else {
      return http.get('/WorkingLineTable/create')
    }
  },
  editLine(data) {
    if (data) {
      return http.post('/WorkingLineTable/update', data)
    }
    else {
      return http.get('/WorkingLineTable')
    }
  },
  deleteLine(id, data) {
    if (data) {
      return http.delete('/WorkingLineTable/${id}')
    }
    else {
      return http.get('/WorkingLineTable/${id}')
    }
  }
}
