const express = require('express')
const app = express()
const port = 3000

const swaggerUI = require('swagger-ui-express')
const swaggerFile = require('./swagger-output.json')
const bodyParser = require('body-parser')

const loginRoute = require('./routes/LoginRoute')

app.use(loginRoute)

// Middlewares
app.use(bodyParser.json())
app.use('/docs', swaggerUI.serve, swaggerUI.setup(swaggerFile))

app.set('view engine', 'ejs')
app.set('views', './views/login')



app.listen(port, ()=>{
    console.log(`Aplicação rodando com sucesso na porta ${port}`)
})