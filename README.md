<div align="right">

  ![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
  ![API Status](https://img.shields.io/badge/status-online-success)
  ![Docker](https://img.shields.io/badge/docker-ready-blue)
  ![Swagger](https://img.shields.io/badge/Swagger-Enabled-brightgreen)
  ![Environment](https://img.shields.io/badge/environment-production-red)

</div>

<h1 align="center">📚 Projeto: Biblioteca Online</h1>

## Descrição Geral

O projeto **Biblioteca Online** consiste em uma **API RESTful** desenvolvida em **C#** com **ASP.NET Core**, que simula a gestão de uma **biblioteca digital**. A aplicação permite **consultar, adicionar, editar, e remover** livros de um acervo armazenado em um banco de dados PostgreSQL.

🔗 **Acesse a API em produção:**

<div align="center">

👉  **https://sistemadebiblioteca-zko7.onrender.com**  👈


</div>

###### *Nota: Esta API pode levar até 50 segundos para inicializar na primeira requisição. Isso ocorre porque ela está hospedada no plano gratuito do Render, que hiberna a aplicação quando fica inativa.*

---

<br>

## Sumário

- [Tecnologias Utilizadas](#1-tecnologias-utilizadas)
- [Como Rodar](#2-como-rodar)
- [Endpoints da API](#3-endpoints-da-api)
- [Utilizando Postman](#4-utilizando-postman)
- [Acompanhe Meu Trabalho](#5-acompanhe-meu-trabalho)

<br>

## 1. Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL
- Docker
- Swagger
- Postman
- Render

<br>

## 2. Como Rodar

A API pode ser executada de diferentes maneiras dependendo do seu ambiente. Abaixo estão as três formas recomendadas:

### 2.1 Render (online, já hospedado)

A maneira mais simples é acessar a API diretamente no ambiente publicado:

🔗 **API rodando no Render:** *https://sistemadebiblioteca-zko7.onrender.com*

Não é necessário instalar nada, o Swagger já estará disponível para testes imediatamente após acessar o link.

###### *Nota: Esta API pode levar até 50 segundos para inicializar na primeira requisição. Isso ocorre porque ela está hospedada no plano gratuito do Render, que hiberna a aplicação quando fica inativa.*

### 2.2 Rodar com Docker (localmente)

Para rodar a API dentro de containers Docker, basta seguir os passos:

1. Baixe deste repositório **somente** o arquivo `docker-compose.yml`.
2. Suba a API e o banco Postgres com Docker Compose executando o comando abaixo no PowerShell, no mesmo diretório do arquivo `docker-compose.yml` que você baixou:

```bash
docker compose up -d
```

O Compose irá:

- Baixar a imagem da API do Docker Hub.
- Criar o container do Postgres.
- Subir os dois containers conectados em uma rede interna.
- Aplicar automaticamente as migrations do banco.

3. Acesse o Swagger para testar os endpoints:


[http://localhost:8080/index.html](http://localhost:8080/index.html)

###### *Nota: não é necessário ter Visual Studio ou PostgreSQL local instalado.*

### 2.3 Rodar via Visual Studio (modo desenvolvedor)

#### **Pré-requisitos recomendados**

* .NET 8 SDK.
* Visual Studio.
* PostgreSQL.

#### **Passo a passo**

1. Abra a solução `SistemaDeBiblioteca.slnx`.
2. Garanta que a connection string do *appsettings.Development.json* aponte para um banco local.
3. Pressione **F5** para rodar. Na primeira execução, o Entity Framework executará automaticamente todas as migrations, criando todo o banco de dados estruturado.
4. Acesse o Swagger para testar os endpoints:

[http://localhost:8080/index.html](http://localhost:8080/index.html)

<br>

## 3. Endpoints da API

Abaixo estão todos os endpoints disponíveis na API **Biblioteca Online**, separados por recurso:

### 3.1 Livros (`BookController`)

<div align="center">

| Método HTTP | Rota           | Descrição                                      |
| ----------- | -------------- | ---------------------------------------------- |
| `GET`       | `/book`      | Lista todos os livros da biblioteca            |
| `GET`       | `/book/{id}` | Retorna os dados de um livro específico por ID |
| `POST`      | `/book`      | Adiciona um novo livro à coleção               |
| `PUT`       | `/book/{id}` | Substitui completamente os dados de um livro   |
| `DELETE`    | `/book/{id}` | Remove um livro da coleção                     |

</div>

<br>

## 4. Utilizando Postman

Você pode testar todos os endpoints da API utilizando o **Postman**, importando dois arquivos na pasta `/Postman/` deste repositório, sendo: 

`BibliotecaOnline.postman_collection.json` → contém todos os endpoints organizados por recursos.

`BibliotecaOnline Environment.postman_environment.json` → armazena as variáveis de ambiente.

### 4.1 Como importar a coleção no Postman

1. Abra o Postman.
2. Clique em **Import** (canto superior esquerdo).
3. Arraste e solte o arquivo `BibliotecaOnline.postman_collection.json` para dentro do pop-up do Postman.
4. Clique em **Continue** → **Import**.
5. Faça o mesmo processo para `BibliotecaOnline Environment.postman_environment.json`.

O Postman irá gerar automaticamente:

* A rota principal
* Todos os métodos (GET, POST, PUT, DELETE)
* Corpo das requisições (JSON) prontos para uso

### 4.2 URLs para importar a API

Abaixo estão as URLs conforme o ambiente que você deseja consumir. Altere em Environments > BibliotecaOnline Environment.

#### 4.2.1 Render (produção)

Use esta URL para importar e testar a API hospedada no Render:

```
https://sistemadebiblioteca-zko7.onrender.com
```

#### 4.2.2 Via Docker

Se você estiver rodando a API em um container Docker local, o Swagger ficará acessível através de:

```
http://localhost:8080/index.html
```

#### 4.2.3 Localmente via Visual Studio

Quando você roda o projeto localmente, o Swagger fica disponível em:

```
http://localhost:8080/index.html
```

### 4.3 Testando as rotas

Após importar a coleção, basta:

* Selecionar o método desejado
* Alterar o JSON no corpo da requisição (somente quando necessário)
* Clicar em **Send**

<br>

## 5. Acompanhe Meu Trabalho

Me encontre em outras redes:

- **Docker Hub:** [hub.docker.com/u/jonathanbarr0s](https://hub.docker.com/u/jonathanbarr0s)
- **LinkedIn:** [linkedin.com/in/jonathansbarros/](https://www.linkedin.com/in/jonathansbarros/)
