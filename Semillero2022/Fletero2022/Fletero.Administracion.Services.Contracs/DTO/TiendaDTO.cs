using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class TiendaDTO
    {
        public int IDSTORE { get; set; }
        public string STORENAME { get; set; }
        public int IDDISTRICTFK { get; set; }
    }
}
