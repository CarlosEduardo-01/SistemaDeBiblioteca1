using System;

namespace SistemaDeBiblioteca1
{
    public class Membro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Membro(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
