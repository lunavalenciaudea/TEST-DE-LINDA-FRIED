using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        private Modelo.DBTestsDeLindaFried dbTestsDeLindaFried;

        public RepositorioMaestro()
        {
            dbTestsDeLindaFried = new Modelo.DBTestsDeLindaFried();
        }

        public List<Ciudad> ObtenerCiudades()
        {
            var ciudades = dbTestsDeLindaFried.Ciudades
                .Select(c => new Ciudad() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return ciudades;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = dbTestsDeLindaFried.TiposDeDocumentos
                .Select(c => new TipoDocumento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return tiposDocumento;
        }
        public List<Departamento> ObtenerDepartamento()
        {
            var departamentos = dbTestsDeLindaFried.Departamentos
                .Select(c => new TipoDocumento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return departamentos;
        }
    }
}
