using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proyectil flecha = new Proyectil("Flecha", 10);
            Proyectil bala = new Proyectil("Bala", 20);

            Arma espada = new ArmaCuerpoACuerdo("Espada",15,1.2,100);
            Arma arco = new ArmaADistancia("Arco", 12, 1.0, 150, flecha);
            Arma pistola = new ArmaADistancia("Pistola",25,0.8,200,bala);

            Inventario inventario = new Inventario();
            inventario.AgregarArma(espada);
            inventario.AgregarArma(arco);
            inventario.AgregarArma(pistola);

            inventario.MostrarArmas();

            inventario.EliminarArma("Espada");
            inventario.MostrarArmas();

            Console.WriteLine($"DPS del Arco: {arco.CalcularDPS()}");
            Console.WriteLine($"DPS de la Pistola: {pistola.CalcularDPS()}");
        }
    }
}
