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
    public class InventarioDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarInventario()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_INVENTARIOS", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public Inventario ListarInventarioDireccion(string descripcion)
        {
            sqlConnection = conexion.GetConnection();

            SqlCommand cmd = new SqlCommand("SP_LISTAR_INVENTARIO_DIRECCION", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = descripcion;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            Inventario objInventario = new Inventario();
            objInventario.Id = int.Parse(dt.Rows[0][0].ToString());
            objInventario.Descripcion = dt.Rows[0][1].ToString();

            return objInventario;
        }

        public int RegistrarInventario(Inventario inventario)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_INVENTARIO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = inventario.Descripcion;

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
