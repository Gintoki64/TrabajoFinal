using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TrabajoFinal
{
    public static class Conexion
    {
        const string ConnectionString = @"Data Source=DESKTOP-L0L08PD;Initial Catalog=BBDDVideojuegos;User ID=pepe;Password=burrinai";
        public static SqlConnection Conectar()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            return cnn;
        }

        public static List<object> queryF(string query) {

            SqlCommand cmd = new SqlCommand(query, Conectar());
            
            SqlDataReader dr = cmd.ExecuteReader();
            List<object> queryFunction= new List<object>();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    queryFunction.Add(dr[i]);
                }
                
            }
            return queryFunction; 
        }

    }
    
    
}