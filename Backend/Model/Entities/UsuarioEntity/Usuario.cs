using Model.Entities.CompraEntity;
using Model.Entities.GrupoMeta;
using Model.Enums.Usuario;

namespace Model.Entities.GrupoUsuario
{
    public class Usuario
    {
        public int? Id { get; set; }
        public string Email { get; set; }
        public string? Nome { get; set; }
        public string Senha { get; set; }
        public EGenero? Genero { get; set; }
        public string? Rua { get; set; }
        public int? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        // Define a navegação para as metas dos usuarios
        public List<Meta>? Metas { get; set; }

        // Define a nevagação para as compras do usuario
        public List<Compra>? Compras { get; set; }

        public Usuario() { }

        public Usuario(int? id, string email, string? nome, string senha, EGenero? genero, string? rua, int? numero, string? cep, string? bairro, string? cidade)
        {
            Id = id;
            Email = email;
            Nome = nome;
            Senha = senha;
            Genero = genero;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
