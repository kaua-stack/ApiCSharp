# 🧠 API de Personagens em C# - Projeto de Estudo

Este é um projeto de **API RESTful desenvolvida em C#** com o objetivo de estudar os fundamentos do desenvolvimento backend com .NET.  
A API simula o gerenciamento de personagens (inspirados em universos como Dragon Ball Z, Marvel, etc.), permitindo operações básicas como **criar, listar, atualizar e excluir personagens**.

---

## 💡 Objetivos do Projeto

- Aprender a criar uma API com C# e ASP.NET Core
- Praticar conceitos como Controllers, Models e Rotas
- Aplicar os métodos HTTP: `GET`, `POST`, `PUT`, `DELETE`
- Estruturar um projeto com boas práticas
- Explorar testes via Swagger e Postman

---

## 🛠️ Tecnologias Utilizadas

- [.NET 6 / .NET 7](https://dotnet.microsoft.com/)
- ASP.NET Core
- C#
- Swagger (para documentação da API)
- Visual Studio Code / Visual Studio

---

## 📦 Funcionalidades da API

| Método | Rota               | Descrição                         |
|--------|--------------------|-----------------------------------|
| GET    | `/api/personagens` | Lista todos os personagens        |
| GET    | `/api/personagens/{id}` | Retorna um personagem por ID  |
| POST   | `/api/personagens` | Cria um novo personagem           |
| PUT    | `/api/personagens/{id}` | Atualiza um personagem existente |
| DELETE | `/api/personagens/{id}` | Remove um personagem por ID     |

---

## 🔍 Estrutura do Personagem

```json
{
  "id": 1,
  "nome": "Goku",
  "classe": "Sayajin",
  "nivel": 99
}
