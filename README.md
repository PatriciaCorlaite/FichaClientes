📋 FichaClientes  
Um sistema simples em **ASP.NET Core MVC** para cadastro de clientes. Ele permite adicionar, listar, editar e excluir registros de clientes de forma prática.  

---

🚀 Funcionalidades  
✅ Adicionar clientes  
✅ Listar clientes cadastrados  
✅ Editar informações dos clientes  
✅ Excluir clientes  

---

🛠️ Tecnologias Utilizadas  
- C#  
- .NET Core (ASP.NET Core MVC)  
- Entity Framework Core (InMemory Database para testes)  
- Bootstrap (para layout básico)  

---

💻 Como Executar o Programa  
1. Clone o repositório (caso esteja no GitHub):  

   ```bash
   git clone https://github.com/SEU-USUARIO/FichaClientes.git
Abra o projeto no Visual Studio.

Restaure os pacotes NuGet (caso necessário):

bash
Copiar código
dotnet restore
Execute o programa:

bash
Copiar código
dotnet run
Abra no navegador:

arduino
Copiar código
https://localhost:5001
🛠️ Estrutura do Código

O projeto segue o padrão MVC (Model-View-Controller):

Model → Classe Cliente.cs (representa os dados do cliente).

Controller → ClientesController.cs (controla as ações e rotas do sistema).

Views → Páginas Razor (Index.cshtml, Create.cshtml, Edit.cshtml, Delete.cshtml).

📌 Exemplo de Uso

Página inicial (Index) → lista todos os clientes cadastrados.

Clique em Criar Novo Cliente → insira nome, e-mail e telefone.

makefile
Copiar código
Nome: Ana Silva
Email: ana@email.com
Telefone: (31) 99999-9999
Cliente cadastrado com sucesso!

Na tela de listagem, é possível Editar ou Excluir o cliente.
