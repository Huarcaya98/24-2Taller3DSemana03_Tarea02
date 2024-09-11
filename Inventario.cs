using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2Taller3DSemana03Tarea02
{
    public class Inventario
    {
        private List<Arma> armas = new List<Arma>();

        public void AgregarArma(Arma arma)
        {
            armas.Add(arma);
            Console.WriteLine($"Has agregado: {arma.ObtenerNombre()}");
        }

        public void MostrarArmas()
        {
            Console.WriteLine("Armas en el inventario:");
            foreach(var arma in armas)
            {
                arma.MostrarInfo();
            }
        }

        public void EliminarArma(string nombreArma)
        {
            armas.RemoveAll(a => a.ObtenerNombre() == nombreArma);
            Console.WriteLine($"Has eliminado el arma : {nombreArma}");
        }

    }
}
