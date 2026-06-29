# Relatório Técnico - Sistema Biblioteca MVC

## Introdução

Este relatório tem como objetivo explicar o funcionamento da base tecnológica utilizada no sistema Biblioteca MVC, desenvolvido com ASP.NET Core MVC, Entity Framework Core e SQLite. O objetivo é apresentar de forma simples como essas tecnologias trabalham juntas para criar uma aplicação organizada, segura e fácil de manter.
## 1. ASP.NET Core MVC

O ASP.NET Core MVC é um framework da Microsoft utilizado para desenvolver aplicações web. Ele organiza o projeto em três partes principais:

- **Model:** representa os dados e as regras de negócio.
- **View:** responsável pela interface apresentada ao usuário.
- **Controller:** recebe as requisições do usuário, processa as informações e envia os dados para a View.

Essa separação facilita a organização do código, torna a manutenção mais simples e permite que diferentes desenvolvedores trabalhem em partes distintas do sistema.

---

## 2. Entity Framework Core

O Entity Framework Core (EF Core) é um ORM (Object-Relational Mapping). Ele permite que o desenvolvedor trabalhe com objetos C# em vez de escrever comandos SQL manualmente.

Suas principais vantagens são:

- Menor quantidade de código.
- Maior produtividade.
- Facilidade para criar e alterar tabelas do banco.
- Redução de erros em consultas SQL.

No projeto Biblioteca MVC, o EF Core é responsável por realizar toda a comunicação entre a aplicação e o banco de dados SQLite.

---

## 3. SQLite

O SQLite é um banco de dados leve que funciona através de um único arquivo (.db). Ele não necessita de instalação de servidor, sendo ideal para projetos acadêmicos, pequenos sistemas e aplicações em desenvolvimento.

Suas principais características são:

- Fácil instalação.
- Baixo consumo de recursos.
- Alta velocidade.
- Portabilidade.
- ---

## 4. Fluxo de Funcionamento da Aplicação

O funcionamento da aplicação ocorre da seguinte forma:

1. O usuário acessa uma página pelo navegador.
2. A requisição chega ao Controller.
3. O Controller consulta ou grava informações utilizando o Entity Framework Core.
4. O Entity Framework Core se comunica com o banco SQLite.
5. Os dados retornam para o Controller.
6. O Controller envia essas informações para a View.
7. A View apresenta o resultado ao usuário.

Esse fluxo garante uma boa organização da aplicação e facilita futuras manutenções.

---

## Conclusão

Após analisar a arquitetura utilizada no sistema Biblioteca MVC, foi possível compreender como o ASP.NET Core MVC, o Entity Framework Core e o SQLite trabalham em conjunto para desenvolver aplicações organizadas, rápidas e de fácil manutenção. Essa separação entre interface, regras de negócio e banco de dados torna o sistema mais escalável e facilita o trabalho em equipe, sendo uma arquitetura muito utilizada no mercado de desenvolvimento de software.