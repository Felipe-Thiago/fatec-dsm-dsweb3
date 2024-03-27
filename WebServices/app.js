const express = require('express')
const app = express()
const port = 3000

app.use(express.json())

//let names = []
let notas = []
var quantidade = 0;
var media = 0;
var maior = 0;
var menor = 0;
var soma = 0;    

app.get('/', (req, res) => {
    //res.json(names)
    res.json(`Quantidade de alunos: ${quantidade}, Média: ${media}, Notas: ${notas}, Abaixo da média: ${menor}, Acima da média: ${maior}`);
})

app.post('/', (req, res) => {
    //names.push(req.body.name)
    //res.send(`Lendo nome: ${req.body.name}`)

    //CalculaTemperatura(req.body.type, req.body.temperature);
    
    //CalculaMediaNotas(req.body.nota);
    notas.push(req.body.nota);
    res.send(`Lendo nota: ${req.body.nota}`);

    quantidade += 1;
    soma = soma + Number(req.body.nota);

    if (Number(req.body.nota) >= 60){
        maior += 1;
    } else if(Number(req.body.nota) < 60){
        menor += 1;
    }

    media = soma/quantidade;

})

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})

function CalculaTemperatura(type, temperature){
    switch(type){
        case "C", "c":
            var faren = Number((9*temperature/5) + 32);
            res.send(`A temperatura de ${temperature} °C é igual a ${faren} °F`)
        break;
        case "F", "f":
            var celsius = Number(5 * (temperature - 32)/9);
            res.send(`A temperatura de ${temperature} °F é igual a ${celsius} °C`)
            break;
        default:
            res.send("Temperatura inválida");
            break;
            
    }
}

function CalculaMediaNotas(nota){
    
    notas.push(nota);
    quantidade =+ 1;

    if(nota >= 60){
        maior =+ 1;
    } else if(nota < 60){
        menor =+ 1;
    }

    var media = notas.length/quantidade;
    return media;
    
}