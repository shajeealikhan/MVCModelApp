using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCModelApp.Models.DAL
{
    public static class AllRepositoryClassic 
    {

         private readonly string _connectionString;
         public AllRepositoryClassic()
            {
                _connectionString = ConfigurationManager.ConnectionStrings["ClassicConnectionString"].ConnectionString;
            }


         public TblLogin GetSingleLogin(int id)
                    {
                        // Here you are free to do whatever data access code you like
                        // You can invoke direct SQL queries, stored procedures, whatever 

                        using (var conn = new SqlConnection(_connectionString))
                        using (var cmd = conn.CreateCommand())
                        {
                            conn.Open();
                            cmd.CommandText = "SELECT id, name FROM TblLogin WHERE LoginId = @id";
                            cmd.Parameters.AddWithValue("@id", id);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    return null;
                                }
                                return new TblLogin
                                {
                                    LoginId = reader.GetInt32(reader.GetOrdinal("LoginId")),
                                    LoginName = reader.GetString(reader.GetOrdinal("LoginName")),
                                    LoginType = reader.GetString(reader.GetOrdinal("LoginType")),

                                };
                            }
                        }
                    }



         public IEnumerable<TblLogin> GetAllLogin()
        {
            // Here you are free to do whatever data access code you like
            // You can invoke direct SQL queries, stored procedures, whatever 

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM TblLogin Order by LoginName";
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    List<TblLogin> list_users = new List<TblLogin>();
                    try
                    {
                       



                        while (reader.Read())
                        {
                            list_users.Add(new TblLogin());
                        }
                    }
                    catch { /* error */ }
                    finally { conn.Close(); }

                    return list_users;
                   
                }
            }
        }


             
       }
   

}