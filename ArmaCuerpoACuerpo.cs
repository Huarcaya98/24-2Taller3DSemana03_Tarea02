using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    public class ArmaCuerpoACuerdo : Arma
    {
        public ArmaCuerpoACuerdo(string nombre, double daño, double velocidadAtaque, double precio)
            : base(nombre, daño, velocidadAtaque, precio) { }
    }
}
