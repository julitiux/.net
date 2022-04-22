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
                    con.Open();

                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = con;
                        comando.CommandText = @"SZ_BFQ_REGISTRATION.f_obtener_holds_nativo";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;

                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = Int32.Parse(Pidm),
                            Direction = ParameterDirection.Input,
                            Size = 10
                        });

                        comando.Parameters.Add(new OracleParameter("P_NOVISIBLES", OracleDbType.Varchar2)
                        {
                            Size = 200,
                            Direction = ParameterDirection.Output
                        });

                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });

                        comando.ExecuteNonQuery();

                        try
                        {
                            // Revisamos si se pudo ejecutar la consulta
                            OracleDataReader lector = ((OracleRefCursor)comando.Parameters["salida"].Value).GetDataReader();

                            // Revisamos cada contacto
                            while (lector.Read())
                            {
                                try
                                {
                                    /*Bloqueos bloqueo = new Bloqueos
                                    {
                                        Pidm = Pidm,
                                        CODIGO = lector["CODIGO"]?.ToString(),
                                        MOTIVO = lector["MOTIVO"]?.ToString(),
                                        MONTO = lector["MONTO"]?.ToString(),
                                        SPRHOLD_USER = lector["SPRHOLD_USER"]?.ToString(),
                                        BLOQUEA_INSCRIPCION = lector["BLOQUEA_INSCRIPCION"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_PAGO = lector["BLOQUEA_PAGO"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_TRANSCRIPT = lector["BLOQUEA_TRANSCRIPT"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_GRADUACION = lector["BLOQUEA_GRADUACION"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_CALIF = lector["BLOQUEA_CALIF"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_ENROLL = lector["BLOQUEA_ENROLL"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_APPL = lector["BLOQUEA_APPL"]?.ToString() == "N" ? false : true,
                                        BLOQUEA_EVALUA = lector["BLOQUEA_EVALUA"]?.ToString() == "N" ? false : true,
                                        SPRHOLD_DATA_ORIGIN = lector["SPRHOLD_DATA_ORIGIN"]?.ToString()
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
                            con.Close();
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