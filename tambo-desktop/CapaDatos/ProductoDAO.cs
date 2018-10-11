using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class ProductoDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarProductos()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_PRODUCTOS",sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable ListarProductoMarca(int idMarca)
        {
            sqlConnection = conexion.GetConnection();

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_MARCA", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = idMarca;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable ListarProductoCategoria(int idCategoria)
        {
            sqlConnection = conexion.GetConnection();

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_CATEGORIA", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int).Value = idCategoria;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public int RegistrarProducto(Producto producto)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PRODUCTO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = producto.objMarca.Id;
                cmd.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int).Value = producto.ObjCategoria.Id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = producto.Nombre;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = producto.Descripcion;
                cmd.Parameters.Add("@PRECIO", SqlDbType.Money).Value = producto.Precio;
                cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = producto.Codigo;
                cmd.Parameters.Add("@FECHA_VENCIMIENTO", SqlDbType.Date).Value = producto.FechaCaducida;

                try
                {
                    int n = cmd.ExecuteNonQuery();
                    tr.Commit();
                    return n;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

        public int EliminarProducto(int id)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PRODUCTO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                try
                {
                    int n = cmd.ExecuteNonQuery();
                    tr.Commit();
                    return n;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
    }
}
