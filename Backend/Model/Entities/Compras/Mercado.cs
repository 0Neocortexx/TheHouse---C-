namespace Model.Entities.Compras
{
    public class Mercado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Rua { get; set; }
        public int? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        public Mercado() { }

        public Mercado(int id, string nome, string? rua, int? numero, string? cep, string? bairro, string? cidade)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
