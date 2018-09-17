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
    public class DetalleVentaDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarDetalleVenta()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_DETALLE_VENTA", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarDetalleVenta(DetalleVenta detalleVenta)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_INVENTARIO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PRODUCTO", SqlDbType.Int).Value = detalleVenta.ObjProducto.Id;
                cmd.Parameters.Add("@ID_VENTA", SqlDbType.Int).Value = detalleVenta.objVenta.Id;
                cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = detalleVenta.Cantidad;
                cmd.Parameters.Add("@SUBTOTAL", SqlDbType.Money).Value = detalleVenta.SubTotal;

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
