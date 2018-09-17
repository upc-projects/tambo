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
    class MetodoEntregaDAO
    {

        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarMetodoEntrega()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_METODO_ENTREGA", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarMetodoEntrega(MetodoEntrega metodoEntrega)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_METODO_ENTREGA", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_MOTORIZADO", SqlDbType.Int).Value = metodoEntrega.objMotorizado.Id;
                cmd.Parameters.Add("@DIRECCION_ENTREGA", SqlDbType.VarChar).Value = metodoEntrega.DireccionEntrega;
                cmd.Parameters.Add("@DIRECCION_TIENDA", SqlDbType.VarChar).Value = metodoEntrega.DireccionTienda;
                cmd.Parameters.Add("@HORA_MAX", SqlDbType.VarChar).Value = metodoEntrega.HoraMax;

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
