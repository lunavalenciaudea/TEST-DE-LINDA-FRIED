﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioRegistroDeDatos
    {
        public void GuardarRegistroDeDatos(RegistroDeDatos registroDeDatos);

    }
}
