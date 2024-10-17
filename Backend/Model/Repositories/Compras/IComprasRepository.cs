using Model.Entities.Compras;

namespace Model.Repositories.Compras
{
    public interface IComprasRepository
    {
        // Aqui estarão todos os métodos que serão utilizados na Controller
        Task<IEnumerable<ListaDeCompras>> GetAllCompras();
        Task<ListaDeCompras?> GetComprasById(int id);
        Task AddCompra(ListaDeCompras compras);
        Task SaveChangesAsync();
    }   
}
