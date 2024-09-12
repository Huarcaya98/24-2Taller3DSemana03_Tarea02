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

            List<Arma> armasDisponibles = new List<Arma>() 
            { espada,
              arco,
              pistola,
            };

            Inventario inventario = new Inventario();

            bool continuar = true;

            while(continuar)
            {
                Console.WriteLine("Que deseas hacer ?");
                Console.WriteLine("1. Ver armas disponibles");
                Console.WriteLine("2. Seleccionar arma y agregar al inventario");
                Console.WriteLine("3. Ver inventario");
                Console.WriteLine("4. Eliminar arma del inventario");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Elige una opcion");
                string opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        Console.WriteLine("Armas disponibles");
                        for(int i = 0; i< armasDisponibles.Count;i++)
                        {
                            Console.WriteLine($"{i + 1}. {armasDisponibles[i].ObtenerNombre()}");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Elige el número del arma que deseas agregar al inventario:");
                        for (int i = 0; i < armasDisponibles.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {armasDisponibles[i].ObtenerNombre()}");
                        }
                        int indice = int.Parse(Console.ReadLine()) - 1;
                        if (indice >= 0 && indice < armasDisponibles.Count)
                        {
                            inventario.AgregarArma(armasDisponibles[indice]);
                        }
                        else
                        {
                            Console.WriteLine("Índice no válido.");
                        }
                        break;

                    case "3":
                        inventario.MostrarArmas();
                        break;

                    case "4":
                        Console.WriteLine("Escribe el nombre del arma que deseas eliminar del inventario:");
                        string nombreArma = Console.ReadLine();
                        inventario.EliminarArma(nombreArma);
                        break;

                    case "5":
                        continuar = false;
                        Console.WriteLine("¡Gracias por jugar!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }



        }


    }


            
 }
    

