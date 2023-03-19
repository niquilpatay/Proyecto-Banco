using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.servicios.interfaz
{
    internal interface iServicio
    {
        DataTable consultarBD(string nomSP);
        bool actualizarBD_SP(string nomSP, int cbu, int dni, double saldo, int id_tipo_cuenta, DateTime ultimoMovimiento);
        bool actualizarBD_SP_cuenta(string nomSP, int cbu, double saldo, DateTime ultimoMovimiento);
        bool actualizarBD_SP2(string nomSP, int dni, string nombre, string apellido);
        bool actualizarBD_SP3(string nomSP, int cbu);
        bool actualizarBD_SP4(string nomSP, int dni);
        bool actualizarBD(string nomSP, List<Parametro> parametros);
        bool desactivarCuenta(string nomSP, int cbu, int estado);
    }
}
