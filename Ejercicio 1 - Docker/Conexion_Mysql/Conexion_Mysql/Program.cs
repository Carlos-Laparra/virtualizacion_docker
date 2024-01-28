using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_Mysql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {

                int opcionElgida = 0;

                while (opcionElgida != 6) {
                    Clases.CConexion objConexion = new Clases.CConexion();
                    Console.WriteLine("El menú es el siguiente: " +
                    "\r\n1. Testear conexión a la base datos" +
                    "\r\n2. Leer datos" +
                    "\r\n3. Insertar un dato" +
                    "\r\n4. Actualizar un dato" +
                    "\r\n5. Borrar un dato" +
                    "\r\n6. Salir del programa" +
                    "\r\n \r\nEleja el número de la opción que desea realizar:");

                    opcionElgida = Convert.ToInt32(Console.ReadLine()); ;

                    /*PARA HACER UNA CONSULTA*/
                    if (opcionElgida == 1)
                    {
                        Console.Clear();
                        objConexion.establecerConexion();
                        opcionElgida = Salir();
                    }
                    /*PARA HACER UNA CONSULTA*/
                    else if (opcionElgida == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("- SELECT");
                        string cadena = objConexion.Select();


                        if (cadena == "")
                        {
                            Console.WriteLine("No hay datos almacenados.");
                        }
                        else
                        {
                            Console.WriteLine("Estos son los datos actuales:" +
                                "\r\n" + cadena);
                        }
                        Salir();
                    }
                    /*PARA HACER UNA INSERCION*/

                    else if (opcionElgida == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("- INSERT");
                        Console.WriteLine("\r\nElija el nombre que desea insertar: ");
                        string nombre = Console.ReadLine();
                        objConexion.Insertar(nombre);
                        opcionElgida = Salir();
                    }


                    else if (opcionElgida == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("- UPDATE");
                        Console.WriteLine("\r\nElija el id que desea actualziar: ");
                        int idAct = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\r\nElija el nuevo nombre: ");
                        string nombre = Console.ReadLine();
                        objConexion.Actualizar(idAct, nombre);
                        opcionElgida = Salir();
                    }

                    else if (opcionElgida == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("- DELETE");
                        Console.WriteLine("\r\nElija el id que desea borrar: ");
                        int idAct = Convert.ToInt32(Console.ReadLine());
                        objConexion.Borrar(idAct);
                        opcionElgida = Salir();
                    }

                    else if (opcionElgida == 6)
                    {
                        Console.WriteLine("Fin del programa, adios :)");
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida, ingresar nuevamente.");
                    }
                    Console.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static int Salir()
        {
            Console.WriteLine("Si desea salir del programa presione el número 6, de lo contrario presione cualquier número");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 6)
            {
                Console.WriteLine("Fin del programa, adios :)");
            }
            return num;

        }

    }
}
