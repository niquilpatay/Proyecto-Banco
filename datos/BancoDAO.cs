using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using banco.datos;

namespace banco
{
    internal class BancoDAO : accesoDB

    {
        private static BancoDAO instancia;

        public static BancoDAO obtenerInstancia()
        {
            if (instancia == null)
                instancia = new BancoDAO();
            return instancia;
        }

        public DataTable consultarBD(string nomSP)
        {
            DataTable cuentas = new DataTable();
            conectar();
            comando.Parameters.Clear();
            comando.CommandText = nomSP;
            cuentas.Load(comando.ExecuteReader());
            desconectar();
            return cuentas;
        }
        public bool actualizarBD_SP(string nomSP, int cbu, int dni, double saldo, int id_tipo_cuenta, DateTime ultimoMovimiento)
        {
            bool ok = true;

            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@id_tipo_cuenta", SqlDbType.Int).Value = id_tipo_cuenta;
                comando.Parameters.AddWithValue("@ultimoMovimiento", SqlDbType.DateTime).Value = ultimoMovimiento;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
        public bool actualizarBD_SP_cuenta(string nomSP, int cbu, double saldo,DateTime ultimoMovimiento)
        {
            bool ok = true;

            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@ultimoMovimiento", SqlDbType.DateTime).Value = ultimoMovimiento;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
        public bool actualizarBD_SP2(string nomSP, int dni, string nombre, string apellido)
        {

            bool ok = true;

            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
        public bool actualizarBD_SP3(string nomSP,int cbu)
        {
            bool ok = true;

            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
        public bool actualizarBD_SP4(string nomSP, int dni)
        {
            bool ok = true;
            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
        public bool actualizarBD(string nomSP, List<Parametro> parametros)
        {

            bool ok = true;

            try
            {
                conectar2();
                comando.Parameters.Clear();
                comando.CommandText = nomSP;
                foreach (Parametro p in parametros)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }  

        public bool desactivarCuenta(string nomSP,int cbu,int estado)
        {
            bool ok = true;

            try
            {
                conectar2();
                comando.CommandText = nomSP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                comando.Parameters.AddWithValue("@estado", SqlDbType.Bit).Value = estado;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return ok;
        }
    }
}
