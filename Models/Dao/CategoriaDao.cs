﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Models.Dao
{
   public class CategoriaDao : ConnectionToSQL
    {
        public List<Categoria> listarCategorias(string buscar)
        {
            List<Categoria> lista = new List<Categoria>();
            using (var connection = GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@buscar", buscar); 
                    command.CommandText = "sp_listarCategorias";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                IdCategoria =Convert.ToInt32(reader["IdCategoria"]),
                                Nombre = reader["CategoriaNombre"].ToString(),
                                oMedida = new Medida
                                {
                                    IdMedida = Convert.ToInt32(reader["IdMedida"]),
                                    Nombre = reader["MedidaNombre"].ToString()
                                },
                                Activo = Convert.ToInt32(reader["Activo"])
                            });

                        }
                        reader.Close();
                        return lista;
                    }
                }
            }
        }

        public int agregarCategoria(Categoria categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    command.Parameters.AddWithValue("@idMedida", categoria.oMedida.IdMedida);
                    command.CommandText = "sp_crearCategoria";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    //obtengo el parametro de retorno 
                    SqlParameter parameter = new SqlParameter();
                    parameter.Direction = System.Data.ParameterDirection.ReturnValue;
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    //devuelvo el valor del parametro de retorno
                    int resultado = (int)parameter.Value;

                    command.Parameters.Clear();
                    return resultado;
                }
            }
        }

        public int editarCategoria(Categoria categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idCategoria", categoria.IdCategoria);

                    command.Parameters.AddWithValue("@nombre", categoria.Nombre);

                    command.Parameters.AddWithValue("@idMedida", categoria.oMedida.IdMedida);

                    command.Parameters.AddWithValue("@activo", categoria.Activo);

                    command.CommandText = "sp_editarCategoria";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //obtengo el parametro de retorno 
                    SqlParameter parameter = new SqlParameter();
                    parameter.Direction = System.Data.ParameterDirection.ReturnValue;
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                    //devuelvo el valor del parametro de retorno
                    int resultado = (int)parameter.Value;

                    command.Parameters.Clear();
                    return resultado;
                }
            }
        }


    }
}
