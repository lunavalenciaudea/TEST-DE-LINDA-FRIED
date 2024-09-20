using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
 
    public class ServicioEvaluacion :   IServicioEvaluacion
        {
            private RepositorioRegistroDeDatos repositorio;

            public ServicioEvaluacion(RepositorioRegistroDeDatos repositorio)
            {
                this.repositorio = repositorio;
            }

            public ServicioEvaluacion()
            {
                repositorio = new RepositorioRegistroDeDatos();
            }

            public void GuardarEvaluacion(Evaluacion evaluacion)
            {
                repositorio.GuadarEvaluacion(evaluacion);
            }
        }
    
}
