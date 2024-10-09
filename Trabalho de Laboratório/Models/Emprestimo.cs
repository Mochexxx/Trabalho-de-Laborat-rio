namespace Trabalho_de_Laboratório.Models
{
    public class Emprestimo
    {
        public int ID_Emprestimo { get; set; }
        public DateTime Data_Empréstimo { get; set; }
        public DateTime Data_Devolução { get; set; }
        public int ID_Leitor { get; set; }
        public int ID_Livro { get; set; }
    }
}
