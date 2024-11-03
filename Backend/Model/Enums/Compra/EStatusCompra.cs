using System.ComponentModel;

namespace Model.Enums.Compras
{
    public enum EStatusCompra
    {
        [Description("Compra não Realizada")]
        NaoRealizada = 0,
        [Description("Compra realizada")]
        Realizada = 1,
        [Description("Compra Cancelada")]
        Cancelada = 2
    }
}
