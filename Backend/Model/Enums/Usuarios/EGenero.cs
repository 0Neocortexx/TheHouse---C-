using System.ComponentModel;

namespace Model.Enums.Usuarios
{
    public enum EGenero
    {
        [Description("Masculino")]
        Masculino = 0,
        [Description("Feminino")]
        Femino = 1,
        [Description("Genero Não Informado")]
        NaoInformado = 2
    }
}
