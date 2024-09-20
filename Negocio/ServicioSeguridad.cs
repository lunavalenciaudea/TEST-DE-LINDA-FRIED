using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private IRepositorioSeguridad repositorio;

        public ServicioSeguridad(RepositorioSeguridad repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioSeguridad()
        {
            repositorio = new RepositorioSeguridad();
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            var usuarioActual = repositorio.ObtenerUsuario(usuario.NombreUsuario);
            if (usuarioActual != null)
            {
                return usuarioActual.Contraseña == usuario.Clave;
            }

            return false;
        }
    }
}
