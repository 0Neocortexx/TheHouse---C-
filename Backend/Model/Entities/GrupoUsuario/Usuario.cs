using Model.Entities.GrupoMeta;
using Model.Enums.Usuario;

namespace Model.Entities.GrupoUsuario
{
    public class Usuario
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

        // Define a navegação para as metas dos usuarios
        public ICollection<Meta> Metas { get; set; }

        public Usuario() { }

        public Usuario (int id, string email, string nome, string senha, GeneroEnum genero, string cep, string bairro, string cidade, string estado, string pais)
        {
            Id = id;
            Email = email;
            Nome = nome;
            Senha = senha;
            Genero = genero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }
    }
}
