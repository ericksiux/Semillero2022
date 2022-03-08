using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class infoArchivo
    {
        public int idArchivo { get; set; }

        public Byte[] archivo { get; set; }

        public string rutaArchivo { get; set; }

        public string nombreArchivo { get; set; }

    }
}
