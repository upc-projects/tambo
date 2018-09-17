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
    public class ProveedorDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarProveedores()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_PROVEEDOR", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarProveedor(Proveedor proveedor)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PROVEEDOR", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = proveedor.Nombre;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = proveedor.Descripcion;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = proveedor.Telefono;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = proveedor.Direccion;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = proveedor.Email;

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
