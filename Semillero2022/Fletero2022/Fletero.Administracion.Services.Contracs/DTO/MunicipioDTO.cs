using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class MunicipioDTO
    {
        public int ID_MUNICIPIO { get; set; }
        public string NOMBRE { get; set;}
        public int ID_ESTADOFK { get; set; }
    }
}
