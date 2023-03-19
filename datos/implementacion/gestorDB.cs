using banco.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.datos.implementacion
{
    internal class gestorDB : iBancoDAO
    {
        public DataTable getConsultarBD(string nomSP)
        {
            return BancoDAO.obtenerInstancia().consultarBD(nomSP);
        }
        
        public bool getActualizarBD_SP(string nomSP, int cbu, int dni, double saldo, int id_tipo_cuenta, DateTime ultimoMovimiento)
        {
            return BancoDAO.obtenerInstancia().actualizarBD_SP(nomSP, cbu, dni, saldo, id_tipo_cuenta, ultimoMovimiento);
        }
        
        public bool getActualizarBD_SP_cuenta(string nomSP, int cbu, double saldo, DateTime ultimoMovimiento)
        {
            return BancoDAO.obtenerInstancia().actualizarBD_SP_cuenta(nomSP, cbu, saldo, ultimoMovimiento);
        }
        
        public bool getActualizarBD_SP2(string nomSP, int dni, string nombre, string apellido)
        {
            return BancoDAO.obtenerInstancia().actualizarBD_SP2(nomSP, dni, nombre, apellido);
        }
        
        public bool getActualizarBD_SP3(string nomSP, int cbu)
        {
            return BancoDAO.obtenerInstancia().actualizarBD_SP3(nomSP, cbu);
        }
        
        public bool getActualizarBD_SP4(string nomSP, int dni)
        {
            return BancoDAO.obtenerInstancia().actualizarBD_SP4(nomSP, dni);
        }
        
        public bool getActualizarBD(string nomSP, List<Parametro> parametros)
        {
            return BancoDAO.obtenerInstancia().actualizarBD(nomSP, parametros);
        }
        
        public bool getDesactivarCuenta(string nomSP, int cbu, int estado)
        {
            return BancoDAO.obtenerInstancia().desactivarCuenta(nomSP, cbu, estado);
        }
    }
}
