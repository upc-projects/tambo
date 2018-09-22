﻿using System;
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
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_INVENTARIO", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int RegistrarInventario(Inventario inventario)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_INVENTARIO", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TOTAL", SqlDbType.Float).Value = inventario.Total;

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
