📚 Sistema de Gerenciamento de Biblioteca em C#
Bem-vindo ao Sistema de Gerenciamento de Biblioteca! Este projeto foi desenvolvido como um exemplo prático de como implementar conceitos fundamentais de programação orientada a objetos em C#, como herança, polimorfismo e abstração, em um contexto real de gestão de biblioteca.

✨ Funcionalidades Principais
Cadastro inteligente de itens:

Livros com todos os detalhes (autor, ISBN, gênero)

Revistas com informações completas (editora, edição)

Gestão de membros:

Cadastro simples de usuários

Histórico completo de empréstimos

Sistema de empréstimos:

Controle automático de disponibilidade

Registro preciso de datas

Devolução simplificada

🛠️ Tecnologias e Conceitos Utilizados
C# como linguagem principal

POO com:

Herança (ItemBiblioteca → Livro/Revista)

Polimorfismo (método MostrarDetalhes())

Abstração (classe base abstrata)

Listas genéricas para armazenamento de dados

Console Application para interface simples

🚀 Como Executar o Projeto
1- Pré-requisitos:

.NET SDK instalado

Editor de código (VS Code, Visual Studio, etc.)

2- Clonar o repositório:

bash
git clone https://github.com/seu-usuario/sistema-biblioteca-csharp.git
cd sistema-biblioteca-csharp
3- Executar:

bash
dotnet run
🧠 Aprendizados Implementados
Este projeto foi desenvolvido para demonstrar na prática:

1- Organização de código com classes bem definidas

2- Reutilização através de herança

3- Flexibilidade com polimorfismo

4- Lógica de negócios para gestão de biblioteca

📝 Exemplo de Uso
csharp
// Criando um livro
var livro = new Livro(1, "Clean Code", "Robert C. Martin", "978-0132350884", "Programação");

// Cadastrando um membro
var membro = new Membro(1, "João Silva", "joao@email.com");

// Realizando empréstimo
var emprestimo = new Emprestimo(1, livro, membro);
