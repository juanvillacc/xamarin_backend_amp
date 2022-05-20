using System.Threading.Tasks;
using System.Collections.Generic;
namespace AmpApi.API.Domain
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> Obtener(int id);
        Task<IEnumerable<T>> ObtenerTodos();
        Task Ingresar(T entidad);
        void Borrar(T entidad);
        void Actualizar(T entidad);
    }
}
