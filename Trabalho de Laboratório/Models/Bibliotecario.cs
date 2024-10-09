namespace Trabalho_de_Laboratório.Models
{
    public class Bibliotecario
    {
        public int ID_Bibliotecário { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Contacto { get; set; }

        // falta aqui uma string que faça a diferenciação entre um leitor comum e um empregado bibliotecário
    }
}
