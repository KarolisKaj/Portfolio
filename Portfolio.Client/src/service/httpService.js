import Axios from 'axios'

export default httpService = Axios.create({
    url: 'http://localhost:50746/api'
})