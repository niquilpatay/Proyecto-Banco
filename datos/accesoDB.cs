using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace banco.datos
{
    internal class accesoDB
    {
        protected SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlTransaction transaccion;

        public accesoDB()
        {
            conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            comando = new SqlCommand();
        }
        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        public void conectar2()
        {
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Connection = conexion;
            comando.Transaction = transaccion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        public void desconectar()
        {
            conexion.Close();
        }
    }
}
