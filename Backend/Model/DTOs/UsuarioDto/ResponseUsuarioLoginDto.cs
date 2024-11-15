namespace Model.DTOs.UsuarioDto
{
    public class ResponseUsuarioLoginDto
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { set; get; }
        public string? Token { set; get; }
    }
}
