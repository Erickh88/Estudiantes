using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
    internal class Estudiante
    {
        static string[] nombre = new string[3];  // variable global
        static float[] notas = new float[3];     // variabl global
        static byte indice = 0;                 // variable global para la posicion del arreglo

        private static void CrearEstudiantes()
        {
            if (indice == nombre.Length)
            {
                Console.WriteLine("No se pueden agregar más estudiantes.");
                return;
            }
            string continuar = "s";
            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0}):", (indice + 1));
                nombre[indice] = Console.ReadLine();
                indice++;
                if (indice == nombre.Length)
                {
                    Console.WriteLine("No se pueden agregar más estudiantes.");
                    break;
                }
                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();
            } while (!continuar.Equals("n") && indice < nombre.Length);
        }


        private static void BuscarEstudiante() 
        {
            Console.WriteLine("Digite el nombre:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Estudiante Existe");
                }
            }
        }
        private static void ImprimirEstudiantesConNotas()
        {
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine("Nombre: {0}, Nota: {1}", nombre[i], notas[i]);
            }
        }

        private static void ModificarEstudiante()
        {
            Console.WriteLine("Digite el nombre del estudiante:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < indice; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Digite el nuevo nombre:");
                    string nuevoNombre = Console.ReadLine();
                    Estudiante.nombre[i] = nuevoNombre;
                    Console.WriteLine("Estudiante modificado correctamente.");
                    return;
                }
            }

            Console.WriteLine("No se encontró ningún estudiante con ese nombre.");
        }

        private static void BorrarEstudiante()
        {
            Console.WriteLine("Digite el nombre del estudiante:");
            string nombre = Console.ReadLine();

            int index = Array.IndexOf(Estudiante.nombre, nombre);
            if (index == -1)
            {
                Console.WriteLine("No se encontró ningún estudiante con ese nombre.");
                return;
            }

            // Mueve todos los elementos hacia la izquierda una posision
            for (int i = index; i < indice - 1; i++)
            {
                Estudiante.nombre[i] = Estudiante.nombre[i + 1];
                Estudiante.notas[i] = Estudiante.notas[i + 1];
            }

            // limpia el ultimo elemento
            Estudiante.nombre[indice - 1] = null;
            Estudiante.notas[indice - 1] = 0;
            indice--;

            Console.WriteLine("Estudiante borrado correctamente.");
        }

        private static void AsignarNota()
        {
            Console.WriteLine("Digite el nombre del estudiante:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < indice; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Digite la nota:");
                    float nota = float.Parse(Console.ReadLine());
                    notas[i] = nota;
                    Console.WriteLine("Nota asignada correctamente.");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún estudiante con ese nombre.");
        }

        public static void menu() // Menu
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiante");
                Console.WriteLine("3 - Asignar nota al estudiante");
                Console.WriteLine("4 - Imprimir Estudiante con sus notas");
                Console.WriteLine("5 - Modificar estudiante.");
                Console.WriteLine("6 - Borrar estudiante.");
                Console.WriteLine("7 - salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();// Llama el metodo agregar 
                        break;
                    case 2:
                        BuscarEstudiante(); // Llama el metodo buscar 
                        break;
                    case 3:
                        AsignarNota(); // Llama el metodo asignar nota 
                        break;
                    case 4:
                        ImprimirEstudiantesConNotas();// Llama el metodo imprimir 
                        break;
                    case 5:
                        ModificarEstudiante(); // Llama el metodo modificar 
                        break;
                    case 6:   
                        BorrarEstudiante(); // Llama el metodo borrar 
                        break;
                    case 7:
                       return; // cierra el programa
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 4); // true

        }


    }
}
