# BuscaCEP

[![NPM](https://img.shields.io/npm/l/react)](https://github.com/StalinLamarca/BuscaCEP/blob/master/LICENSE.txt)

# Sobre o Projeto:
BUSCACEP é uma aplicação full stack desktop construída durante processo seletivo organizado pela evento AeC Centro de Contatos.  https://www.aec.com.br

A aplicação consiste em uma pesquisa de endereços, quando inserido o CEP e depois retornados os dados como : Rua, Cidade, Bairro, Estado via API (VIACEP) e da a posibilidade do usuário salvar e editar esses dados através de SQL, com intuito de demonstrar conceitos CRUD.

Cada usuário possui seu login e senha que é atribuído a uma chave estrangeira, sendo assim impossibilitado de alterar/ver dados de outros usuários. Caso não possua login, o usuário pode cria-lo.

Para testes, o usuário padrão da aplicação ao iniciar é:
- User: admin
- Senha: admin1234

```C#
 //Cria o banco de dados com a senha "senhasenha" e a criptografa
        SqlCeEngine criar = new SqlCeEngine("Data source="+Variaveis.Db+ "; Password=senhasenha; Encrypt Database=True");
                criar.CreateDatabase();

                
                //cria a tabela "usuários" com campos ID, NOME USUARIO E SENHA
                //ID DE INTEIRO E SE AUTO INCREMENTA
                string valores = "CREATE TABLE [Usuarios]"
                  + "( " +
                  "[ID] INT PRIMARY KEY IDENTITY(1,1), " +
                  "[NOME] nvarchar(100), " +
                  "[USUARIO] nvarchar(15)," +
                  "[SENHA] nvarchar(11))";
                dados.Executar(valores);

              
                //string para inserir o usuario padrão na tabela criada
                dados.Executar("INSERT INTO Usuarios (Nome,usuario,senha) VALUES" +
                     " ('Administrador', 'admin', 'admin1234' )");
               

               
                


                // cria tabela de Endereços
                //a chave ID_USUÁRIO É a chave estrangeira, isso faz ela ter relação com a chave ID da tabela usuário
                //isso controla o que o usuário pode ver na tabela sendo de acordo com seu ID
                valores = "CREATE TABLE [Enderecos]"
                + "( " +
                "[ID] INT PRIMARY KEY IDENTITY(1,1), " +
                "[CEP] nvarchar(10)," +
                "[LOGRADOURO] nvarchar(50)," +
                "[COMPLEMENTO] nvarchar(30), " +
                "[BAIRRO] nvarchar(50), " +
                "[NUMERO] INT, " +
                "[CIDADE] nvarchar(50), " +
                "[UF] nvarchar(2), " +
                "[ID_USUARIO] int, " +
                "FOREIGN KEY([ID_USUARIO]) REFERENCES Usuarios([ID]));";

                dados.Executar(valores);

```
## Layout Desktop

### Tela de Login:
![Desktop](https://github.com/StalinLamarca/assets/blob/main/Login.png)

### Tela de cadastro usuário:
![Desktop](https://github.com/StalinLamarca/assets/blob/main/cadastro1.png)

### Tela de consulta de dados:
![Desktop](https://github.com/StalinLamarca/assets/blob/main/cadatrofrm.png)


## Tecnologias utilizadas:
- C#
- SQL

## Front end
- C#
- Windows Form


## Banco de dados

- SQL Compact Edition

## Como executar o projeto:

- Pré-requisitos: .Net Core 8.0

## clonar repositório
```bash
git clone https://github.com/StalinLamarca/BuscaCEP.git
```
## Instalar dependências
```bash
dotnet add package Microsoft.SqlServer.Compact --version 4.0.8876.1
```

## Executar o projeto

- Abrir BuscaCEP.sln
- Pré-requisitos: Visual Studio Commnunity


# Autor:

Stalin Lamarca Soares

https://www.linkedin.com/in/stalin-lamarca

# Agradecimentos:

A AeC e aos recrutadores, pois a experiência foi incrível!
