# 🏛️ Atlas IT

> Plataforma para gerenciamento e controle de ativos de TI.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![C#](https://img.shields.io/badge/C%23-.NET-blue)
![Projeto](https://img.shields.io/badge/projeto-pessoal-purple)

## 👨‍💻 Sobre o projeto

O **Atlas IT** é um projeto pessoal desenvolvido por **Lucas Gabriel** com o objetivo
de criar uma plataforma para centralizar o gerenciamento de ativos, colaboradores
e recursos de tecnologia da informação.

A ideia surgiu a partir de uma necessidade real observada no ambiente de TI:
a dificuldade de manter informações sobre equipamentos, usuários, licenças e
outros recursos organizadas e facilmente acessíveis.

O projeto também faz parte da minha jornada de estudos em **desenvolvimento
backend com C#**, servindo como um projeto de portfólio para aplicar, na prática,
conceitos de desenvolvimento de software, banco de dados, arquitetura e
organização de sistemas.

---

## 🎯 Objetivo

O Atlas tem como objetivo centralizar informações relacionadas ao ambiente de TI
em um único sistema.

Entre os principais objetivos estão:

- Gerenciar colaboradores;
- Controlar equipamentos;
- Associar equipamentos aos colaboradores;
- Controlar informações de notebooks, celulares e impressoras;
- Gerenciar ativos de TI;
- Controlar licenças e softwares;
- Facilitar consultas e localização de informações;
- Gerar informações para acompanhamento e tomada de decisão.

---

## 💡 O problema

Em muitos ambientes de TI, informações importantes acabam espalhadas entre
planilhas, documentos, sistemas diferentes e anotações.

Isso pode dificultar perguntas simples como:

> "Quem está utilizando este notebook?"

> "Qual equipamento está vinculado a determinado colaborador?"

> "Quais licenças estão sendo utilizadas?"

> "Qual é o patrimônio deste equipamento?"

> "Quais equipamentos estão disponíveis?"

O Atlas nasceu com a proposta de transformar essas informações em uma estrutura
centralizada e organizada.

---

## 🏗️ Visão do sistema

A estrutura do Atlas está sendo pensada para trabalhar com diferentes áreas
do ambiente de TI.

### 👥 Colaboradores

Cadastro e gerenciamento dos colaboradores da organização.

Informações planejadas:

- ID do colaborador
- Nome
- E-mail
- Cargo
- Telefone

### 💻 Equipamentos

Controle dos equipamentos utilizados pelos colaboradores.

Atualmente estão sendo considerados:

- Notebooks
- Computadores
- Celulares
- Impressoras
- Switches
- Firewalls
- Servidores
- Nobreaks

### 📦 Ativos

Cada ativo poderá possuir informações como:

- ID do ativo
- Patrimônio
- Fabricante
- Modelo
- Situação
- Colaborador responsável

### 🧩 Softwares e licenças

Controle de softwares e licenças utilizados no ambiente corporativo.

Exemplos:

- Microsoft 365
- Power BI
- SQL Server
- Active Directory
- PROTHEUS
- Outras ferramentas utilizadas pela organização

---

## 🛠️ Tecnologias

O projeto está sendo desenvolvido utilizando principalmente:

- **C#**
- **.NET**
- **SQL Server**
- **Git**
- **GitHub**

A stack pode evoluir conforme o projeto avança e novas necessidades surgem.

---

## 📐 Arquitetura

O projeto está sendo desenvolvido de forma incremental.

A ideia é começar pela construção das regras de negócio e modelagem das
informações e evoluir posteriormente para uma aplicação completa.

### Estrutura planejada

```text
Atlas IT
│
├── Colaboradores
│
├── Ativos
│   ├── Notebooks
│   ├── Celulares
│   ├── Impressoras
│   └── Outros equipamentos
│
├── Softwares
│
├── Licenças
│
├── Movimentações
│
└── Relatórios
