using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Fletero.Administracion.Integration.DAO.Helper
{
    public static class DALHelper
    {
        static string conStr = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static void Create(string storedProcedure, IList<IDbDataParameter> parameters)
        {
            using (SqlConnection myCon = new SqlConnection(conStr))
            using (SqlCommand sqlcomm = myCon.CreateCommand())
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        if (parameters != null)
                            foreach (var param in parameters)
                            {
                                sqlcomm.Parameters.AddWithValue(param.ParameterName, param.Value);
                            }

                        sqlcomm.CommandText = storedProcedure;
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                    }
                }
                catch (SEHException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        public static DataSet Retrive(string storedProcedure, IList<IDbDataParameter> parameters = null)
        {
            using (SqlConnection myCon = new SqlConnection(conStr))
            using (SqlCommand sqlcomm = myCon.CreateCommand())
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        // This will be your input parameter and its value
                        if (parameters != null)
                            foreach (var param in parameters)
                            {
                                sqlcomm.Parameters.AddWithValue(param.ParameterName, param.Value);
                            }

                        sqlcomm.CommandText = storedProcedure;
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
                catch (SEHException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return new DataSet();
        }
    }
}
