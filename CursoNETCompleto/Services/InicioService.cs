using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace CursoNETCompleto.Services
{
    public class InicioService
    {
        public void Test(string Pidm, int noMatricula)
        {

            try
            {
                using (OracleConnection oracleConnection = new OracleConnection(ConfigurationManager.ConnectionStrings["Banner"].ConnectionString))
                {
                    oracleConnection.Open();

                    using (OracleCommand oracleCommand = new OracleCommand())
                    {
                        oracleCommand.Connection = oracleConnection;
                        oracleCommand.CommandText = @"PK_JRR.P_FIND_ALL";
                        oracleCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        oracleCommand.BindByName = true;

                        oracleCommand.Parameters.Add(new OracleParameter("OUT_INFO", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });

                        oracleCommand.ExecuteNonQuery();

                        try
                        {
                            // Revisamos si se pudo ejecutar la consulta
                            OracleDataReader oracleDataReader = ((OracleRefCursor)oracleCommand.Parameters["salida"].Value).GetDataReader();

                            // Revisamos cada contacto
                            while (oracleDataReader.Read())
                            {
                                try
                                {
                                    /*Bloqueos bloqueo = new Bloqueos
                                    {
                                        Pidm = Pidm,
                                        CODIGO = oracleDataReader["CODIGO"]?.ToString(),
                                        MOTIVO = oracleDataReader["MOTIVO"]?.ToString(),
                                        MONTO = oracleDataReader["MONTO"]?.ToString(),
                                        SPRHOLD_USER = oracleDataReader["SPRHOLD_USER"]?.ToString(),
                                        BLOQUEA_INSCRIPCION = oracleDataReader["BLOQUEA_INSCRIPCION"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_PAGO = oracleDataReader["BLOQUEA_PAGO"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_TRANSCRIPT = oracleDataReader["BLOQUEA_TRANSCRIPT"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_GRADUACION = oracleDataReader["BLOQUEA_GRADUACION"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_CALIF = oracleDataReader["BLOQUEA_CALIF"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_ENROLL = oracleDataReader["BLOQUEA_ENROLL"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_APPL = oracleDataReader["BLOQUEA_APPL"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_EVALUA = oracleDataReader["BLOQUEA_EVALUA"]?.ToString() == "N" ? false : true,
                                        SPRHOLD_DATA_ORIGIN = oracleDataReader["SPRHOLD_DATA_ORIGIN"]?.ToString()
                                    };
                                    bloqueos.Add(bloqueo);*/
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            //resp.Bloqueos = bloqueos;

                        }
                        finally
                        {
                            oracleConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}