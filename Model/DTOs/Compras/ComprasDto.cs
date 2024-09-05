namespace Model.DTOs.Compras
{
    public class ComprasDto
    {
        public int Id { get; set; }

        public string Produto { get; set; }

        public int Quantidade { get; set; }

        public string PrecoUnitario { get; set; }

        public bool PossuiNoEstoque { get; set; }
    }

    public class CreateComprasDto {

        public string Produto { get; set; }

        public int Quantidade { get; set; }

        public string PrecoUnitario { get; set; }

        public bool PossuiNoEstoque { get; set; }
    }

}
