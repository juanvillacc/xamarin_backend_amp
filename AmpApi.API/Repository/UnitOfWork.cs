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
        private readonly ICiudadRepository _repoCiudades;
        public UnitOfWork(ApplicationDbContext contexto ,
            ISuscripcionRepository repoSuscripciones,
            ICiudadRepository repoCiudades
            ) {
            _contexto = contexto;
            _repoSuscripciones = repoSuscripciones;
            _repoCiudades = repoCiudades;
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

        public void ActualizarSuscripcion(Suscripcion dato)
        {
            _repoSuscripciones.ActualizarSuscripcion(dato);
            Commit();
        }

        public async Task<IEnumerable<Suscripcion>> ObtenerSuscripcionesAsync()
        {
            return await _repoSuscripciones.Obtener();
        }

        public async Task EliminarSuscripcion(int id)
        {
            await _repoSuscripciones.EliminarSuscripcion(id);
            Commit();
        }

        public async Task<IEnumerable<Ciudad>> ObtenerCiudades()
        {
            return await _repoCiudades.Obtener();
        }

        public async Task IngresarCiudad(Ciudad dato)
        {
            await _repoCiudades.IngresarCiudad(dato);
            Commit();
        }

        public void ActualizarCiudad(Ciudad dato)
        {
            _repoCiudades.ActualizarCiudad(dato);
            Commit();
        }

        public async Task EliminarCiudad(int id)
        {
            await _repoCiudades.EliminarCiudad(id);
            Commit();
        }
    }
}
