using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO
{
    public class MunicipioDAO
    {
        public List<MunicipioDTO> ObtenerMunicipio(int id)
        {
            List<MunicipioDTO> lst = new List<MunicipioDTO>();

            try
            {

                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

                var ds = DALHelper.Retrive("Municipio_Consulta", parameters);
                lst = MunicipioMapper.MunicipioDSToList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst;
        }
    }
}
