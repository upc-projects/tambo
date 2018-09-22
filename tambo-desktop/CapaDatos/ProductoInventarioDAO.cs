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
    public class ProductoInventarioDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarInventario()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_PRODUCTO_INVENTARIO", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarProductoInventario(ProductoInventario productoInventario)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PRODUCTO_INVENTARIO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PRODUCTO", SqlDbType.Int).Value = productoInventario.ObjProducto.Id;
                cmd.Parameters.Add("@ID_TIENDA", SqlDbType.Int).Value = productoInventario.ObjTienda.Id;
                cmd.Parameters.Add("@SUBTOTAL", SqlDbType.Float).Value = productoInventario.Subtotal;
                cmd.Parameters.Add("@STOCK", SqlDbType.Int).Value = productoInventario.Stock;

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
