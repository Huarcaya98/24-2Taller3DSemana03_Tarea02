using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    public class Proyectil
    {
        private string nombre;
        private double danio;

        public Proyectil(string nombre , double danio)
        {
            this.nombre = nombre;
            this.danio = danio;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public double ObtenerDanio()
        {
            return danio;
        }

        public void EstablecerDanio(double nuevoDanio)
        {
             danio= nuevoDanio;
        }




    }
}
