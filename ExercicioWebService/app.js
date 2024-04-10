const express = require('express')
const app = express()
const port = 4000


const cursos = ["Álgebra Linear", "NOSQL", "DSWEB", "SCRUM"]
let alunos = [
    {"ra": 123, "nome": "Felipe", "turma": "2A"},
    {"ra": 213, "nome": "Thiago", "turma": "1A"},
    {"ra": 312, "nome": "Silva", "turma": "1B", "cursos": ["Álgebra", "Banco de Dados"]}
]



app.get('/', (req, res) => {
    res.json(cursos);
    res.json(alunos);
    //res.json(alunos)
})

app.post('/', (req, res) => {
    
    alunos.push(req.body.ra)
    alunos.push(req.body.nome)
    alunos.push(req.body.turma)
    alunos.push(
        cursos.push(req.body.curso)
    )

    res.send(`Aluno: ${req.body.ra}, ${req.body.nome}, ${req.body.turma}, ${req.body.cursos}`)

})

app.post('/', (req, res)=>{
    cursos
})


app.listen(port, () =>{
    console.log(`Aplicação rodando na porta: ${port}`)
})