# API de Receitas :cake:
  
<details>
<summary><strong>🧑‍💻 O que foi desenvolvido</strong></summary>

Uma empresa desenvolveu um aplicativo de Receitas que está totalmente funcional 😉.
Agora, ela quer expandir esse negócio, criando uma **api de receitas** que retorna todas as receitas disponíveis, adiciona, remove e atualiza as mesmas. Além disso, a empresa desejou que fosse possível cadastrar, remover, consultar e atualizar dados de usuários do app e permitir o cadastro e consulta de comentários nessas receitas.

Você recebeu a atribuição de desenvolver essa api de receitas com ASP.NET. Todos os services com os modelos de dados já estão disponíveis.

</details>
  
<details>
  <summary><strong>📝 Habilidades trabalhadas </strong></summary>

Neste projeto, foram trabalhadas as seguintes habilidades:

- Entender do funcionamento do ASP.NET e como ele se integra ao C#.
- Entender da arquitetura MVC.
- Criar controllers que recebam dados pelo corpo e pela URL da requisição.
- Lançar códigos de retorno que respeitem o padrão do HTTP Status Code.


</details>


## Orientação do projeto
---
  ### Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`
---
## Organização das rotas do projeto

| Nome da Rota | Tipo da Rota |
| --- | --- |
| `/recipe` | GET |
| `/recipe/:name` | GET |
| `/recipe` | POST |
| `/recipe` | PUT |
| `/recipe/:name` | DELETE |
| `/user/:email` | GET |
| `/user` | POST |
| `/user/:email` | PUT |
| `/user/:email` | DELETE |

---
## Exemplos de retorno:

### /recipe (GET):
```json
[
 {
 "name": "Bolo de cenoura",
 "recipeType": 1,
 "preparationTime": 0.4,
 "ingredients": [
 "1/2 xícara (chá) de óleo",
 "..."
 ],
 "directions": "Em um liquidificador, ...",
 "rating": 10
 },
 /*...*/
]
```

### /recipe/:name (GET):

```json
{
 "name": "Bolo de cenoura",
 "recipeType": 1,
 "preparationTime": 0.4,
 "ingredients": [
 "1/2 xícara (chá) de óleo",
 "..."
 ],
 "directions": "Em um liquidificador, ...",
 "rating": 10
}

```
### /recipe (POST):
```json

{
 "Name": "Mousse de maracuja",
 "RecipeType": 0,
 "PreparationTime": "0.2",
 "Ingredients": [
 "1 lata de leite condensado"
 ],
 "Directions": "Em um liquidificador, ...",
 "Rating": "9"
}

```
### /recipe (PUT):

```json

{
 "status": "HTTP 204 sem conteúdo"
}
```
### /recipe/:name (DELETE):
```json

{
 "status": "HTTP 204 sem conteúdo"
}
```
### /user/:email (GET):
```json

{
 "email": "pessoa@betrybe.com",
 "name": "Pessoa tryber",
 "password": "senhaTryber"
}
```
### /user (POST):
```json

{
 "email": "pessoa.nova@betrybe.com",
 "name": "Pessoa Nova",
 "password": "senhaDaPessoaNova"
}
```
### /user/:email (PUT):
```json

{
 "email": "pessoa.nova@betrybe.com",
 "name": "Pessoa Nova",
 "password": "senhaDaPessoaNova"
}
```
### /user/:email (DELETE):
```json

{
 "status": "HTTP 204 sem conteúdo"
}
```
---
## Arquivos Trabalhados:

```css
.
├── recipes-api
│ ├── appsettings.Development.json
│ ├── appsettings.json
│ ├── bin
│ ├── Comment.cs
│ ├── compiler-diagnostics.sarif
│ ├── Controllers
│ │ ├── 🔸HomeController.cs
│ │ ├── 🔸AccountController.cs
│ │ └── 🔸RecipeController.cs
│ ├── Models
│ ├── obj
│ ├── Program.cs
│ ├── Properties
│ ├── Recipe.cs
│ ├── recipes-api.csproj
│ ├── Services
│ └── User.cs
├── recipes-api.Test.Test
│ ├── bin
│ ├── obj
│ ├── recipes-api.Test.Test.csproj
│ └── Test.cs
└── src.sln
```
## Atenção: Todos os outros arquivos foram desenvolvidos pela Trybe!

