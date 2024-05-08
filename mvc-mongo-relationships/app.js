const express = require('express')
const bodyParser = require('body-parser')
const app = express()
const port = 3000

const userRoute = require('./src/routes/userRoute')
app.use(userRoute)

//Configurando a conexão
const mongoose = require('mongoose')
let url = 'mongodb+srv://felipesilva581:F4t3cV0t0r4nt1m@fatecvotorantim.kzodpb6.mongodb.net/?retryWrites=true&w=majority&appName=FatecVotorantim'
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

