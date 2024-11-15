using Model.Enums.Usuario;

namespace Model.DTOs.UsuarioDto
{
    public class UsuarioDto
    {
        public Guid? Id { get; set; }
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
}