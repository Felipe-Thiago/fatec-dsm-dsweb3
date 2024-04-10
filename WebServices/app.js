const express = require('express')
const app = express()
const port = 3000



//let names = []
let items = []
const veiculos = [
    {id: 1, name: "Fiat"},
    {id: 2, name: "Celta"}, 
    {id: 3, name: "Marea"}
];

app.get('/', (req, res) => {
    res.json(items)
})

app.post('/', (req, res)=> {
    items.push(req.body.name)
    res.send(`Post ${req.body.name}`)
})

app.put('/', (req, res)=> {
    const index = veiculos.findIndex(x => x.id == req.query.id);
    veiculos[index] = {id: req.query.id, name: req.body.name}
    res.send(JSON.stringify(veiculos))
})

app.delete('/', (req, res) => {
    const index = veiculos.findIndex(x => x.id == req.query.id);
    veiculos.splice(index, i);
    res.send(JSON.stringify(veiculos))
})

app.listen(port, () =>{
    console.log(`Example app listening on port ${port}`)
})





//exercícios aula 26/04
app.post('/calculaMedias', (req, res) => {
   res.send(CalculaMediaNotasCorrecao(req.query.total, req.body.grades))
})

app.post('/converteTemperatura', (req, res) =>{
    CalculaTemperatura(req.body.type, req.body.temperature);
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

//correção
function CalculaMediaNotasCorrecao(total, nota){
    if(total == nota.length){
        let soma = nota.reduce((acum, x) => acum + x, 0)
        let media = soma / total
        let abaixo = nota.filter(x => x < 6);
        let acima = nota.filter(x => x >= 6);

        return `Média: ${media} \n; Abaixo da Média: ${abaixo.length}; Acima da Média: ${acima.length}`
    }
    return "A média total não bate com a quantidade de notas"
}