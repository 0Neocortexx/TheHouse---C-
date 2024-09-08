using Model.Enums.Usuario;

namespace Model.DTOs.UsuarioDto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public GeneroEnum Genero { get; set; }
        public string Cep { get; set; }
        public String Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

    public class CreateUsuarioDto
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public GeneroEnum Genero { get; set; }
        public string Cep { get; set; }
        public String Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
