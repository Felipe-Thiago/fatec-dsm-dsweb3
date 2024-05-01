## Comandos ao baixar:
```
npm init
npm install express --save -dev
npm install -g nodemon
npm install ejs
npm install swagger-autogen swagger-ui-express
```

### Modificar o arquivo package.json:
```json
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1",
    "start": "nodemon app.js", //incluir
    "swagger": "node swagger.js" //incluir
  },
```

## Para iniciar o app:
```
npx nodemon app.js
```

## Para acessar o swagger:
```
npx npm run swagger
```


