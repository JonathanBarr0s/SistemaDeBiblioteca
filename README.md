<h1 align="center">📚 Projeto: Biblioteca Online</h1>

## 1. Visão Geral

O projeto Biblioteca Online consiste em uma API RESTful desenvolvida em C# com ASP.NET Core, que simula a gestão de uma biblioteca digital. A aplicação permite consultar, adicionar, editar, e remover livros de um acervo armazenado em um banco de dados PostgreSQL.

## 2. Funcionalidades Principais

A API fornece as seguintes operações sobre a coleção de livros:

| Método HTTP | Rota           | Descrição                                      |
| ----------- | -------------- | ---------------------------------------------- |
| `GET`       | `/book`      | Lista todos os livros da biblioteca            |
| `GET`       | `/book/{id}` | Retorna os dados de um livro específico por ID |
| `POST`      | `/book`      | Adiciona um novo livro à coleção               |
| `PUT`       | `/book/{id}` | Substitui completamente os dados de um livro   |
| `DELETE`    | `/book/{id}` | Remove um livro da coleção                     |

## 3. Estrutura dos dados

Cada livro no banco de dados possui a seguinte estrutura:

```csharp
{
"id": 1,
"title": "A Odisséia de Jonas",
"author": "Thomas Crawling",
"year": 2001,
"numberPages": 197
},
```

## 4. Instalação

Para executar o projeto , siga os passos abaixo:

**Pré-requisitos**

- Visual Studio
- Banco de dados PostgreSQL em execução

**Passo 1: Clonar o Repositório do Projeto no GitHub**

- Abra o Git Bash ou o terminal do Git.
- Navegue até o diretório onde deseja clonar o projeto.
- Execute o comando:
    ```sh
    git clone https://github.com/JonathanBarr0s/SistemaDeBiblioteca.git
    ```

**Passo 2: Abrir o Projeto no Visual Studio**

   - Inicie o Visual Studio após a instalação.
   - Clique em "Abrir um projeto ou solução".
   - Navegue até o diretório onde você clonou o repositório.
   - Selecione o arquivo da solução (`.sln`) e clique em "Abrir".

**Passo 3: Instalando Bibliotecas**

Instale as bibliotecas:

- Microsoft.EntityFrameworkCore
- Npgsql.EntityFrameworkCore.PostgreSQL

**Passo 4: Configurar a String de Conexão**

No arquivo ConnectionContext.cs, configure a string de conexão com o seu banco de dados PostgreSQL:

```csharp
{
"Server=localhost;" +
"Port=5432;Database=Biblioteca;" +
"User Id=seu_usuario;" +
"Password=sua_senha;"
},
```
**Passo 5: Executar o Projeto**

   - Inicie o projeto apertando `F5`.