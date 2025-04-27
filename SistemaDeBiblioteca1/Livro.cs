

using System;

namespace SistemaDeBiblioteca1
{
    public class Livro : ItemBiblioteca1
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }

        public Livro(int id, string titulo, string autor, string isbn, string genero)
            : base(id, titulo)
        {
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"LIVRO - ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}