using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class FleteroModel
    {
        public FleteroModel()
        {
        }
        public List<TiendaDTO> Stores { get; set; }
        public List<DistritoDTO> Districts { get; set; }
        public List<FleteroDTO> TodosFleteros { get; set; }

    }
}