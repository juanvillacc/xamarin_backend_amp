using AmpApi.API.Data;
using AmpApi.API.Domain;
using AmpApi.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISuscripcionRepository _repoSuscripciones;   
        private readonly ApplicationDbContext _contexto;
        public UnitOfWork(ApplicationDbContext contexto ,ISuscripcionRepository repoSuscripciones) {
            _contexto = contexto;
            _repoSuscripciones = repoSuscripciones;
        }

        public int Commit()
        {
            return _contexto.SaveChanges();
        }
        public void Dispose()
        {
            //Dispose();
            GC.SuppressFinalize(this);  
        }

        public async Task IngresarSuscripcion(Suscripcion dato)
        {
            await _repoSuscripciones.IngresarSuscripcion(dato);
            Commit();
        }

        public IEnumerable<Suscripcion> ObtenerSuscripciones()
        {
            return _repoSuscripciones.ObtenerActivas();
          
        } 
    }
}
