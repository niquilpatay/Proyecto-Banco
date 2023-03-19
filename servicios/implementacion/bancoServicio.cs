using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco.servicios.interfaz;
using banco.datos;
using banco.datos.implementacion;
using System.Data;

namespace banco.servicios.implementacion
{
    internal class bancoServicio : iServicio
    {
        iBancoDAO dao;
        public bancoServicio()
        {
            dao = new gestorDB();
        }

        public DataTable consultarBD(string nomSP)
        {
            return dao.getConsultarBD(nomSP);
        }
        public bool actualizarBD_SP(string nomSP, int cbu, int dni, double saldo, int id_tipo_cuenta, DateTime ultimoMovimiento)
        {
            return dao.getActualizarBD_SP(nomSP, cbu, dni, saldo, id_tipo_cuenta, ultimoMovimiento);
        }
        public bool actualizarBD_SP_cuenta(string nomSP, int cbu, double saldo, DateTime ultimoMovimiento)
        {
            return dao.getActualizarBD_SP_cuenta(nomSP, cbu, saldo, ultimoMovimiento);
        }
        public bool actualizarBD_SP2(string nomSP, int dni, string nombre, string apellido)
        {
            return dao.getActualizarBD_SP2(nomSP, dni, nombre, apellido);
        }
        public bool actualizarBD_SP3(string nomSP, int cbu)
        {
            return dao.getActualizarBD_SP3(nomSP, cbu);
        }
        public bool actualizarBD_SP4(string nomSP, int dni)
        {
            return dao.getActualizarBD_SP4(nomSP, dni);
        }
        public bool actualizarBD(string nomSP, List<Parametro> parametros)
        {
            return dao.getActualizarBD(nomSP, parametros);
        }
        public bool desactivarCuenta(string nomSP, int cbu, int estado)
        {
            return dao.getDesactivarCuenta(nomSP,cbu,estado);
        }

    }
}
