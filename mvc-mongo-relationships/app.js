const express = require('express')
const bodyParser = require('body-parser')
const app = express()
const port = 3000

const userRoute = require('./src/routes/userRoute')
const projectRoute = require('./src/routes/projectRoute')
app.use(userRoute)
app.use(projectRoute)

//Configurando a conexão
const mongoose = require('mongoose')
let url = 'mongodb://127.0.0.1:27017/'
let mongoDb = process.env.MONGODB_URI || url
mongoose.connect(mongoDb)
mongoose.Promise = global.Promise
let db = mongoose.connection
db.on('error', console.error.bind(console, 'Erro ao conectar com o banco de dados'))

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({extended: false}))


app.listen(port, () => {
    console.log(`Servidor em execução na porta ${port}`)
})

