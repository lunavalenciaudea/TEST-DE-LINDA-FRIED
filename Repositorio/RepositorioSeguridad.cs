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
       
            private Modelo.DBTestsDeLindaFried dbTestsDeLindaFried;

            public RepositorioSeguridadEF()
            {
                dbTestsDeLindaFried = new Modelo.DBTestsDeLindaFried();
            }

            public Usuario ObtenerUsuario(string nombreUsuario)
            {
                var usuarioActual = dbTestsDeLindaFried.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

                if (usuarioActual != null)
                {
                    return new Usuario() { NombreUsuario = usuarioActual.NombreUsuario, Contraseña = usuarioActual.Contraseña };
                }

                return null;
            }
        }
    }

