const loginModel = require('../models/LoginModel')
const login = new loginModel()
const logged = login.isLogged()

exports.getLogin = ((req, res) =>{ 
    /*
        #swagger.tag = ['Login']
        #swagger.description = 'Mostra mensagem logado'
        #swagger.summary = 'Chama função is logged'
    */

    res.send(`<h1>${logged}</h1>`)
})

exports.getLogged = ((req, res)=>{
    //#swagger.ignore = true
    res.render("LoginView", {logged: logged})
})

exports.createUser = ((req, res)=>{
    const {email, password} = req.body
    req.status(200).json("User add sucessfully")
})

exports.getById = ((req, res) => {
    const filter = req.query.filter
    const version = req.headers.version
    return res.status(200).send("Getting user")
})