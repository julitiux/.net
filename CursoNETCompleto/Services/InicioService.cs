using CursoNETCompleto.Models;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace CursoNETCompleto.Services
{
    public class InicioService
    {
        public List<Person> Test()
        {

            List<Person> personList = new List<Person>();

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

                                    personList.Add(
                                        new Person
                                        {
                                            Id = (long)oracleDataReader["ID"],
                                            Name = oracleDataReader["NAME"].ToString(),
                                            Mail = oracleDataReader["MAIL"].ToString(),
                                            DateCreate = (DateTime)oracleDataReader["DATE_CREATED"]
                                        }
                                    );

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }

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
                Console.WriteLine(ex.Message);
            }
            return personList;
        }
    }
}