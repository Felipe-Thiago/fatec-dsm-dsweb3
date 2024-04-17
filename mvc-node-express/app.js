const express = require('express')
const app = express()
const port = 3000
const loginRoute = require('./routes/LoginRoute')

app.set('view engine', 'ejs')
app.set('views', './views/login')

app.use(loginRoute)

app.listen(port, ()=>{
    console.log(`Aplicação rodando com sucesso na porta ${port}`)
})