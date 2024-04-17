const loginModel = require('../models/LoginModel')
const login = new loginModel()
const logged = login.isLogged()

exports.getLogin = ((req, res) =>{ 
    res.send(`<h1>${logged}</h1>`)
})

exports.getLogged = ((req, res)=>{
    res.render("LoginView", {logged: logged})
})