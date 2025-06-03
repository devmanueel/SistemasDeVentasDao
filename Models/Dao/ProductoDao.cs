using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Models.Dao
{
    public class ProductoDao : ConnectionToSQL
    {

        public List<Producto> listarProductos(string buscar)
        {
            List<Producto> lista = new List<Producto>();
            using (var connection = GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@buscar", buscar);
                    command.CommandText = "sp_listarProductos";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                oCategoria = new Categoria
                                {
                                    IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                    Nombre = reader["NombreCategoria"].ToString(),
                                   
                                },
                                Codigo = reader["Codigo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                Activo = Convert.ToInt32(reader["Activo"])

                            });

                        }
                        reader.Close();
                        return lista;
                    }
                }
            }
        }

        public int agregarProducto(Producto producto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@IdCategoria", producto.oCategoria.IdCategoria);
                    command.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

                     command.CommandText = "sp_crearProducto";
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

        public int editarProducto(Producto producto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                    command.Parameters.AddWithValue("@IdCategoria", producto.oCategoria.IdCategoria);
                    command.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    command.Parameters.AddWithValue("@Activo", producto.Activo);


                    command.CommandText = "sp_editarProducto";
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
