using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    { 
        public Usuario ObtenerUsuario ( string NombreUsuario)
        {
            return new Usuario() { Contraseña = "123", NombreUsuario = NombreUsuario };
        }
    }
}
