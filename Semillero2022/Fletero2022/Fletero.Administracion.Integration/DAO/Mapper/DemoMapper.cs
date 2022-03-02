using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public static class DemoMapper
    {
        public static List<DemoDTO> DemoDStoList(DataSet ds)
        {
            List<DemoDTO> demos= new List<DemoDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var demo = new DemoDTO();

                demo.CampoID = Convert.ToInt32(row["CampoID"]);
                demo.Campo2 = Convert.ToString(row["Campo2"]);
                demo.Campo4 = Convert.ToBoolean(row["Campo4"]);

                demos.Add(demo);
            }

            return demos;
        }


        public static DemoDTO DemoDStoDTO(DataSet ds)
        {
            DemoDTO demo = new DemoDTO();

            if(ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                demo.CampoID = Convert.ToInt32(ds.Tables[0].Rows[0]["CampoID"]);
                demo.Campo2 = Convert.ToString(ds.Tables[0].Rows[0]["Campo2"]);
                demo.Campo4 = Convert.ToBoolean(ds.Tables[0].Rows[0]["Campo4"]);
            }

            return demo;
        }

        public static int DemoDStoDemoID(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["CampoID"]);
            }

            return 0;
        }
    }
}
