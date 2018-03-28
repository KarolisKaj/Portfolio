import Axios from 'axios'

let httpService = Axios.create({
  baseURL: 'http://localhost:50746/api/v1'
})

export default httpService
