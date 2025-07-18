# 📚 BiblioTech

Sistema de gerenciamento de biblioteca, com foco em praticidade, organização e visual moderno.

---

## 🚀 Sobre o Projeto

O **BiblioTech** é um sistema desktop feito em C# com MySQL, voltado para bibliotecas de pequeno e médio porte.  
A proposta é facilitar a administração do acervo e melhorar a experiência de quem deseja visualizar ou reservar livros.

---

## 👥 Público-alvo

- Leitores que querem visualizar, reservar e acompanhar seus livros.
- Equipe da biblioteca que precisa cadastrar e gerenciar livros, reservas e usuários.

---

## ⚙️ Funcionalidades

✔️ Cadastro e login de usuários  
✔️ Visualização dos livros com capa, descrição e detalhes  
✔️ Reserva de livros com envio de email automático  
✔️ Sistema de avisos internos  
✔️ Cadastro em duas etapas (dados pessoais e endereço)  
✔️ Área administrativa com CRUD completo (livros, usuários, reservas)  
✔️ Histórico de empréstimos e ações (log)  
✔️ Gêneros favoritos para recomendações  
✔️ Contador de empréstimos por usuário  
✔️ Avaliação dos livros por nota  
✔️ Envio de email no momento da reserva e um dia antes da devolução  
✔️ Controle de estoque com entradas e saídas  
✔️ Backup manual do banco de dados  

---

## 🧱 Tecnologias

- **Linguagem**: C# (.NET)
- **Banco de Dados**: MySQL
- **UI Framework**: WinForms com Guna.UI
- **APIs**: ViaCEP (busca de endereço por CEP)
- **Email**: SMTP

---

## 🖼️ Protótipo (UI)

A interface conta com layout moderno e intuitivo:  
- FlowLayoutPanel para listagem dinâmica dos livros  
- Telas separadas para reservas, avisos, histórico e gerenciamento  
- Design responsivo para desktop

---

## 💾 Banco de Dados

O banco foi estruturado com foco em integridade e desempenho.  
Possui tabelas como:

- `livros`, `editoras`, `autores`, `generos`
- `usuarios`, `enderecos`, `reservas`, `estoque`, `controle_estoque`, `avaliacoes`, `logs`

