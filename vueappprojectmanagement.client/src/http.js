import axios from 'axios'

let http = axios.create({
  baseURL: 'https://localhost:7108',
  headers: {
    'Content-type': 'application/json'
  }
})

export default http
