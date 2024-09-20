using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioMaestro : IServicioMaestro
    {
        private IRepositorioMaestro repositorio;

        public ServicioMaestro(IRepositorioMaestro repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioMaestro()
        {
            repositorio = new RepositorioMaestro();
        }

        public List<Ciudad> ObtenerCiudades()
        => repositorio.ObtenerCiudades();

        public List<TipoDocumento> ObtenerTiposDocumento()
        => repositorio.ObtenerTiposDocumento();
        public List<Departamento> ObtenerDepartamento()
        => repositorio.ObtenerDepartamento();
    }
}
