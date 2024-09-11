using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    public class Arma
    {
        private string nombre;
        private double danio;
        private double velocidadAtaque;
        private double precio;

        public Arma(string nombre, double danio, double velocidadAtaque, double precio )
        {
            this.nombre = nombre;
            this.danio = danio;
            this.velocidadAtaque = velocidadAtaque;
            this.precio = precio;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }
        public double ObtenerDanio()
        {
            return danio;
        }
        public void EstableverDanio(double nuevoDanio)
        {
            danio = nuevoDanio;
        }
        public double ObtenerVelocidadAtaque()
        {
            return velocidadAtaque;
        }
        public void EstablecerVelocidadAtaque(double NuevoVelocidadAtaque)
        {
            velocidadAtaque = NuevoVelocidadAtaque;
        }
        public double ObtenerPrecio()
        {
            return precio;
        }
        public void EstablecerPrecio(double NuevoPrecio)
        {
            precio = NuevoPrecio;
        }

        public virtual double CalcularDPS()
        {
            return danio * velocidadAtaque;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"{nombre} - Daño: {danio}, VelocidadXAtaque{velocidadAtaque}, Precio: {precio}");
        }

    }
}
