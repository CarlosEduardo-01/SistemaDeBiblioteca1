namespace SistemaDeBiblioteca1
{
    public abstract class ItemBiblioteca1
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Disponivel { get; set; } = true;

        public ItemBiblioteca1(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }

        public abstract void MostrarDetalhes();
    }
}