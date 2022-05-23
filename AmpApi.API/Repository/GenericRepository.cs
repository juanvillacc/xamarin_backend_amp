using AmpApi.API.Data;
using AmpApi.API.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _contexto;

        public GenericRepository(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Actualizar(T entidad)
        {
            _contexto.Set<T>().Update(entidad);
        }

        public async Task Eliminar(int id)
        {
            T entidad = await _contexto.Set<T>().FindAsync(id);
            _contexto.Set<T>().Remove(entidad);
        }

        public async Task Ingresar(T entidad)
        {
            await _contexto.Set<T>().AddAsync(entidad);
        }

        public async Task<T> Obtener(int id)
        {
            return await _contexto.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObtenerTodos()
        {
            return await _contexto.Set<T>().ToListAsync();
        }
    }
}
