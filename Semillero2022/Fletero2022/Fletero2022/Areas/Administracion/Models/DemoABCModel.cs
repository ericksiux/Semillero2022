using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class DemoABCModel
    {
        public DemoABCModel()
        {

        }

        public int Campo1 { get; set; }

        public string Campo2 { get; set; }

        public List<string> Campo3 { get; set; }

        public bool Campo4 { get; set; }
    }
}