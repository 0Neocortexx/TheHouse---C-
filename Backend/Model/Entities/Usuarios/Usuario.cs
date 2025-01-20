using Model.Entities.Compras;
using Model.Entities.Metas;
using Model.Enums.Usuarios;

namespace Model.Entities.Usuarios
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
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

        // Define a navegação para as ListaDeCompras do usuario
        public List<ListaCompra>? ListaCompra { get; set; }

        public Usuario() { }

        public Usuario(Guid id, string email, string? nome, string senha, EGenero? genero, string? rua, int? numero, string? cep, string? bairro, string? cidade)
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
