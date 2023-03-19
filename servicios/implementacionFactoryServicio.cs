using banco.servicios.implementacion;
using banco.servicios.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.servicios
{
    internal class implementacionFactoryServicio : factoryServicio
    {
        public override iServicio crearServicio()
        {
            return new bancoServicio();
        }
    }
}
