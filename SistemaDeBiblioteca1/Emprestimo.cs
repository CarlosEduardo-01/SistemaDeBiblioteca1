using System;
using SistemaDeBiblioteca1;

namespace SistemaDeBiblioteca1
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public ItemBiblioteca1 Item { get; set; }
        public Membro Membro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public Emprestimo(int id, ItemBiblioteca1 item, Membro membro)
        {
            Id = id;
            Item = item;
            Membro = membro;
            DataEmprestimo = DateTime.Now;
        }

        public void RegistrarDevolucao()
        {
            DataDevolucao = DateTime.Now;
            Item.Disponivel = true;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"ID Empréstimo: {Id}");
            Console.WriteLine($"Item: {Item.Titulo} (ID: {Item.Id})");
            Console.WriteLine($"Membro: {Membro.Nome} (ID: {Membro.Id})");
            Console.WriteLine($"Data Empréstimo: {DataEmprestimo}");
            Console.WriteLine($"Data Devolução: {DataDevolucao?.ToString() ?? "Não devolvido"}");
        }
    }
}