# PrimeiraAPI

Este projeto é uma API desenvolvida em **ASP.NET Core** como parte da minha formação como **Desenvolvedor .NET**. O objetivo é aplicar conceitos fundamentais de **desenvolvimento de APIs RESTful**.

## 🚀 Tecnologias Utilizadas

- **C#**
- **ASP.NET Core**
- **Entity Framework Core**
- **SQL Server/MySQL**
- **Swagger** (para documentação da API)
- **Postman** (para testes de requisições)
- **Git/GitHub** (para versionamento de código)

## 📌 Funcionalidades

- Criar, ler, atualizar e deletar (CRUD) registros.
- Autenticação e autorização com **JWT**.
- Documentação interativa da API com **Swagger**.
- Integração com banco de dados relacional usando **Entity Framework Core**.

## 📋 Pré-requisitos

Antes de rodar a aplicação, certifique-se de ter instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server ou MySQL](https://www.mysql.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
- [Postman](https://www.postman.com/) (opcional, para testar a API)

## ⚙️ Como Executar o Projeto

1. **Clone este repositório:**
   ```sh
   git clone https://github.com/Jeferson-Naressi/PrimeiraAPI.git
   ```

2. **Acesse a pasta do projeto:**
   ```sh
   cd PrimeiraAPI
   ```

3. **Configure o banco de dados no `appsettings.json`**:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=SEU_USUARIO;Password=SUA_SENHA;"
   }
   ```

4. **Aplique as migrações do banco de dados:**
   ```sh
   dotnet ef database update
   ```

5. **Execute a aplicação:**
   ```sh
   dotnet run
   ```

6. **Acesse a API via Swagger:**
   - Abra no navegador: `http://localhost:5000/swagger`

## 🛠 Estrutura do Projeto

```bash
PrimeiraAPI/
│-- Controllers/   # Controladores da API
│-- Models/        # Modelos de dados
│-- Services/      # Lógica de negócios
│-- Data/          # Configuração do banco de dados
│-- Program.cs     # Arquivo de inicialização da API
```

## 📌 Endpoints da API

| Método  | Rota            | Descrição                 |
|---------|----------------|---------------------------|
| GET     | /api/itens      | Retorna todos os itens   |
| GET     | /api/itens/{id} | Retorna um item pelo ID |
| POST    | /api/itens      | Adiciona um novo item   |
| PUT     | /api/itens/{id} | Atualiza um item        |
| DELETE  | /api/itens/{id} | Remove um item         |

## 🚀 Melhorias Futuras

- Implementação de testes unitários.
- Deploy em um servidor na nuvem.
- Integração com serviços externos.

## 🤝 Contribuição

Se quiser contribuir com o projeto, siga os passos:
1. **Faça um fork** do repositório.
2. **Crie uma branch** (`git checkout -b feature/nova-feature`).
3. **Commit suas mudanças** (`git commit -m 'Adicionando nova feature'`).
4. **Envie para o repositório** (`git push origin feature/nova-feature`).
5. **Abra um Pull Request**.

---

📌 **Criado por [Jeferson Naressi](https://github.com/Jeferson-Naressi)**

🛠 **Projeto em evolução!** 🚀

