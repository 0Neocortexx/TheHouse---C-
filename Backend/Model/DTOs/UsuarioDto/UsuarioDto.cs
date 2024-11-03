using Model.Enums.Usuario;

namespace Model.DTOs.UsuarioDto
{
    public class UsuarioDto
    {
        public int? Id { get; set; }
        public string? Email { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public EGenero? Genero { get; set; }
        public string? Rua { get; set; }
        public int? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
    }

    public class UsuarioCadastroDto 
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }


    public class UsuarioLoginDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class ResponseUsuarioLogin
    {
        public string? Email { set; get; }
        public string? Token { set; get; }
    }
}
