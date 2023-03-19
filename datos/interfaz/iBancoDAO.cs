using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using banco.datos;

namespace banco.datos
{
    internal interface iBancoDAO
    {
        DataTable getConsultarBD(string nomSP);
        bool getActualizarBD_SP(string nomSP, int cbu, int dni, double saldo, int id_tipo_cuenta, DateTime ultimoMovimiento);
        bool getActualizarBD_SP_cuenta(string nomSP, int cbu, double saldo, DateTime ultimoMovimiento);
        bool getActualizarBD_SP2(string nomSP, int dni, string nombre, string apellido);
        bool getActualizarBD_SP3(string nomSP, int cbu);
        bool getActualizarBD_SP4(string nomSP, int dni);
        bool getActualizarBD(string nomSP, List<Parametro> parametros);
        bool getDesactivarCuenta(string nomSP, int cbu, int estado);

    }
}
