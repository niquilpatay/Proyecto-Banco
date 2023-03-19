using banco.servicios.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.servicios
{
    abstract class factoryServicio
    {
        public abstract iServicio crearServicio();
    }
}
