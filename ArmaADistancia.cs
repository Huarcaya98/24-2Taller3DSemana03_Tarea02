using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    public class ArmaADistancia : Arma
    {
        private Proyectil proyectil;

        public ArmaADistancia(string nombre, double danio, double velocidadAtaque, double precio,Proyectil proyectil)
            :base(nombre,danio,velocidadAtaque,precio)
        {
            this.proyectil = proyectil;
        }

        public void EstablecerProyectil(Proyectil nuevoProyectil)
        {
            proyectil = nuevoProyectil;
        }

        public override double CalcularDPS()
        {
            return (ObtenerDanio() + proyectil.ObtenerDanio()) * ObtenerVelocidadAtaque();
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"{ObtenerNombre()} - Daño: {ObtenerDanio()}, VelocidadXAtaque: {ObtenerVelocidadAtaque()}, Precio: {ObtenerPrecio()}, Proyectil: {proyectil.ObtenerNombre()} (Danio: {proyectil.ObtenerDanio()})");
        }

    }
}
