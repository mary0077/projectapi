# WebApiDemo

Projeto ASP.NET Razor Pages que consome uma API externa (`https://jsonplaceholder.typicode.com/users`) e exibe uma lista de usuários em uma página web.

## 🚀 Tecnologias utilizadas

- .NET 6 (ou superior)
- ASP.NET Core Razor Pages
- HttpClient
- JsonSerializer

## 📦 Estrutura do projeto

WebApiDemo/ │ ├── Models/ │ └── Usuario.cs # Modelo de dados do usuário │ ├── Services/ │ └── UsuarioService.cs # Serviço para buscar os dados da API externa │ ├── Pages/ │ ├── Index.cshtml # Página principal (HTML + Razor) │ └── Index.cshtml.cs # Código da página com lógica C# │ ├── Program.cs # Configuração e inicialização da aplicação └── WebApiDemo.csproj # Arquivo de projeto .NET


## 💻 Como rodar o projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/WebApiDemo.git
cd WebApiDemo
