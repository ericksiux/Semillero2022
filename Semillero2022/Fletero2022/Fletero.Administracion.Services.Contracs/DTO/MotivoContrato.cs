using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class MotivoContrato
    {
        public int idMotivo { get; set; }
        public int idTituloMotivo { get; set; }

        public string descripcion { get; set; }

        public DateTime fechaMotivo { get; set; }

    }
}
