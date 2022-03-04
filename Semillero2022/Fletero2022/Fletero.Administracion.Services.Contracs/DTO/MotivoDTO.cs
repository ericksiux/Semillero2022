using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class MotivoDTO
    {
        public int idMotivo { get; set; }
        public int motivo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
    }
}
