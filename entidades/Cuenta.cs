using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Cuenta
    {
        private int cbu, id_tipo_cuenta, estado, dni;
        private double saldo;
        private DateTime ultimoMovimiento;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public int Cbu
        {
            get { return cbu; }
            set { cbu = value; }
        }
        public int Id_tipo_cuenta
        {
            get { return id_tipo_cuenta; }
            set { id_tipo_cuenta = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public DateTime UltimoMovimiento
        {
            get { return ultimoMovimiento; }
            set { ultimoMovimiento = value; }
        }

        public Cuenta()
        {
            cbu = 0;
            dni = 0;
            id_tipo_cuenta = 0;
            saldo = 0;
            ultimoMovimiento = DateTime.Today;
            estado = 1;
        }
        public Cuenta(int cbu, int dni, int id_tipo_cuenta, double saldo, DateTime ultimoMovimiento, int estado)
        {
            this.cbu = cbu;
            this.dni = dni;
            this.id_tipo_cuenta = id_tipo_cuenta;
            this.saldo = saldo;
            this.ultimoMovimiento = ultimoMovimiento;    
            this.estado = estado;
        }
    }
}
