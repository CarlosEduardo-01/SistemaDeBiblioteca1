using System;
using SistemaDeBiblioteca1;
namespace SistemaDeBiblioteca1
{
    public class Revista : ItemBiblioteca1
    {
        public string Editora { get; set; }
        public int NumeroEdicao { get; set; }

        public Revista(int id, string titulo, string editora, int numeroEdicao)
            : base(id, titulo)
        {
            Editora = editora;
            NumeroEdicao = numeroEdicao;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"REVISTA - ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Editora: {Editora}");
            Console.WriteLine($"Edição: {NumeroEdicao}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}