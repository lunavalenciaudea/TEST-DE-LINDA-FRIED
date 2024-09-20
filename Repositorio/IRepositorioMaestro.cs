using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoDocumento> ObtenerTiposDocumento();
        List<Departamento> ObtenerDepartamento();
    }
}
