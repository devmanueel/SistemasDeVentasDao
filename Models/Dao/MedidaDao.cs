using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Models.Dao
{
    public class MedidaDao: ConnectionToSQL
    {
        public List<Medida> listarMedidas()
        {
            List<Medida> lista = new List<Medida>();
            using (var connection = GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_listarMedidas";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Medida
                            {
                                IdMedida = Convert.ToInt32(reader["IdMedida"]),
                                Nombre = reader["Nombre"].ToString(),
                                Abreviatura = reader["Abreviatura"].ToString(),
                                Equivalente = reader["Equivalente"].ToString(),
                                Valor = reader["Valor"].ToString()
                            });
                        }
                        reader.Close();
                        return lista;
                    }
                }
            }
        }
    }
}
