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
    public class VentaDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarVenta()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_VENTA", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarVenta(Venta venta)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_VENTA", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_TIENDA", SqlDbType.Int).Value = venta.objTienda.Id;
                cmd.Parameters.Add("@ID_METODO_DE_ENTREGA", SqlDbType.Int).Value = venta.objMetodoEntrega.Id;
                cmd.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = venta.objCliente.Id;
                cmd.Parameters.Add("@FECHA", SqlDbType.Date).Value = venta.Fecha;
                cmd.Parameters.Add("@DESCUENTO", SqlDbType.Money).Value = venta.Descuento;
                cmd.Parameters.Add("@TOTAL", SqlDbType.Money).Value = venta.Total;

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
