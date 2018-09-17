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
    public class ClienteDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarClientes()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_CLIENTE", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarCliente(Cliente cliente)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_CLIENTE", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = cliente.Apellido;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = cliente.Direccion;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = cliente.Telefono;
                cmd.Parameters.Add("@EDAD", SqlDbType.Int).Value = cliente.Edad;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = cliente.DNI;
                
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
