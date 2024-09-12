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
            Console.WriteLine($"Has agregado: {arma.ObtenerNombre()} al inventario.");
        }

        public void MostrarArmas()
        {
            if (armas.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
            }
            else
            {
                Console.WriteLine("Armas en el inventario:");
                foreach (var arma in armas)
                {
                    arma.MostrarInfo();
                }
            }
        }

        public void EliminarArma(string nombreArma)
        {
            Arma armaAEliminar = armas.Find(a => a.ObtenerNombre() == nombreArma);
            if (armaAEliminar != null)
            {
                armas.Remove(armaAEliminar);
                Console.WriteLine($"Has eliminado el arma: {nombreArma}");
            }
            else
            {
                Console.WriteLine($"El arma {nombreArma} no se encuentra en el inventario.");
            }
        }

    }
}
