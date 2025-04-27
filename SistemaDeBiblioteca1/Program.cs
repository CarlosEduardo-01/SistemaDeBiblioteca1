using System;
using System.Collections.Generic;
using SistemaDeBiblioteca1;

namespace SistemaDeBiblioteca1
{
    class Program
    {
        static List<ItemBiblioteca1> itens = new List<ItemBiblioteca1>();
        static List<Membro> membros = new List<Membro>();
        static List<Emprestimo> emprestimos = new List<Emprestimo>();

        static void Main(string[] args)
        {
            // Adicionando alguns dados de exemplo
            itens.Add(new Livro(1, "Dom Casmurro", "Machado de Assis", "978-85-01-00001-1", "Literatura"));
            itens.Add(new Revista(2, "Veja", "Abril", 2567));

            while (true)
            {
                Console.WriteLine("\nSistema de Gerenciamento de Biblioteca");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Adicionar Revista");
                Console.WriteLine("3. Listar Itens");
                Console.WriteLine("4. Adicionar Membro");
                Console.WriteLine("5. Listar Membros");
                Console.WriteLine("6. Emprestar Item");
                Console.WriteLine("7. Devolver Item");
                Console.WriteLine("8. Listar Empréstimos");
                Console.WriteLine("9. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarLivro();
                        break;
                    case "2":
                        AdicionarRevista();
                        break;
                    case "3":
                        ListarItens();
                        break;
                    case "4":
                        AdicionarMembro();
                        break;
                    case "5":
                        ListarMembros();
                        break;
                    case "6":
                        EmprestarItem();
                        break;
                    case "7":
                        DevolverItem();
                        break;
                    case "8":
                        ListarEmprestimos();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void AdicionarLivro()
        {
            Console.Write("ID do Livro: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();

            itens.Add(new Livro(id, titulo, autor, isbn, genero));
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        static void AdicionarRevista()
        {
            Console.Write("ID da Revista: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Editora: ");
            string editora = Console.ReadLine();
            Console.Write("Número da Edição: ");
            int edicao = int.Parse(Console.ReadLine());

            itens.Add(new Revista(id, titulo, editora, edicao));
            Console.WriteLine("Revista adicionada com sucesso!");
        }

        static void ListarItens()
        {
            Console.WriteLine("\nItens da Biblioteca:");
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
                Console.WriteLine();
            }
        }

        static void AdicionarMembro()
        {
            Console.Write("ID do Membro: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            membros.Add(new Membro(id, nome, email));
            Console.WriteLine("Membro adicionado com sucesso!");
        }

        static void ListarMembros()
        {
            Console.WriteLine("\nMembros Cadastrados:");
            foreach (var membro in membros)
            {
                membro.MostrarDetalhes();
                Console.WriteLine();
            }
        }

        static void EmprestarItem()
        {
            Console.Write("ID do Item: ");
            int itemId = int.Parse(Console.ReadLine());
            Console.Write("ID do Membro: ");
            int membroId = int.Parse(Console.ReadLine());

            var item = itens.Find(i => i.Id == itemId);
            var membro = membros.Find(m => m.Id == membroId);

            if (item == null || membro == null)
            {
                Console.WriteLine("Item ou membro não encontrado!");
                return;
            }

            if (!item.Disponivel)
            {
                Console.WriteLine("Item já emprestado!");
                return;
            }

            int emprestimoId = emprestimos.Count + 1;
            emprestimos.Add(new Emprestimo(emprestimoId, item, membro));
            item.Disponivel = false;
            Console.WriteLine("Item emprestado com sucesso!");
        }

        static void DevolverItem()
        {
            Console.Write("ID do Empréstimo: ");
            int emprestimoId = int.Parse(Console.ReadLine());

            var emprestimo = emprestimos.Find(e => e.Id == emprestimoId);
            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo não encontrado!");
                return;
            }

            emprestimo.RegistrarDevolucao();
            Console.WriteLine("Item devolvido com sucesso!");
        }

        static void ListarEmprestimos()
        {
            Console.WriteLine("\nEmpréstimos Ativos:");
            foreach (var emp in emprestimos)
            {
                emp.MostrarDetalhes();
                Console.WriteLine();
            }
        }
    }
}

