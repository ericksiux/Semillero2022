﻿using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.Manager
{
    public interface ITipoUnidadManager
    {
        List<TipoUnidadDTO> ObtenerTipoUnidad(int id);
    }
}
