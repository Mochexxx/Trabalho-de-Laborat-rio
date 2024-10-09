namespace Trabalho_de_Laboratório.Models
{
    public class Livro
    {
        public int ID_Livro { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public string Género { get; set; }
        public decimal Preço { get; set; }
        public string ISBN { get; set; }
        public int Número_de_Exemplares { get; set; }
    }
}
