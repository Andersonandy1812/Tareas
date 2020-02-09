using System;
using System.Collections.Generic;

namespace Contactos
{
    class Program
    {
        private struct junto

        //            Realizar una aplicación que permita registrar contactos telefónicos, también editarlo , listarlo y eliminarlo.Del contacto se debe pedir los siguientes datos: su nombre,

        //apellido y numero telefónico.

        //El sistema debe de validar que el contacto que se este ingresado no tenga un numero de teléfono que ya este registrado, si existe alguien con ese numero de teléfono debe indicarle que existe y enviarlo al menu principal, en caso de que sea valido pues lo permite agregar, solo se validara los teléfonos al momento de agregar un nuevo contacto para el editar no lo tomaremos en cuenta por cuestiones de tiempo.

        //Consideraciones: Se Deben utilizar metodos para simplificar los proceso y tenerlo cada uno bien segmentado dentro del codigo.
        {
            public static string Nombredecontacto { get; set; }
            public static string numero { get; set; }
        }
        private static List<string> contacto = new List<string>();

        private static List<int> numero = new List<int>();
        static void Main(string[] args)
        {
            Menu();

        }
        private static void nombrecontacto()
        {


        }

        private static void Menu()
        {
            Console.WriteLine("Escriba que desea: \n1-agregar contacto \n2-editar contacto \n3-eliminar contacto \n4-lista de contactos \n5-salir del programa");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        agregarcontacto();
                        break;
                    }
                case 2:
                    {
                        editarcontacto();
                        break;
                    }
                case 3:
                    {
                        eliminarcontacto();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Lista(contacto, false);
                        Menu();
                        break;
                    }
                case 5:
                    {

                        break;
                    }
            }


        }
        private static void agregarcontacto()
        {
            Console.Clear();
            Console.WriteLine("Nombre del contacto:");
            string nombre = Console.ReadLine();
            Add(contacto, nombre);
            Menu();
        }
        private static void editarcontacto()
        {
            Console.Clear();
            Lista(contacto, true);
            Console.WriteLine("seleccione el contacto que desea editar:");
            int contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dijite el nuevo nombre que desea ponerle al contacto:");
            string nombre = Console.ReadLine();
            Editar(contacto, (contact - 1) + nombre);
        }


        private static void eliminarcontacto()
        {
            Console.Clear();
            Lista(contacto, true);
            Console.WriteLine("Seleccione el contacto que desea eliminar:");            
            int indi = Convert.ToInt32(Console.ReadLine());
            eliminar(contacto, (indi - 1));
            Menu();
        }

        private static void Add<T>(List<T> listado, T contac)
        {
            listado.Add(contac);
        }
        private static void Editar<T>(List<T> listado, int indi, T value)
        {
            listado[indi] = value;
        }
        private static void eliminar<T>(List<T> listado, int indi)
        {
            listado.RemoveAt(indi);
        }
        private static void Lista<T>(List<T> listado,bool islist)
        {
            int contador = 1;
            foreach (T contac in listado)
            {
                Console.WriteLine(contador + "-" + contac);
                contador++;
                
            }

            if (!islist)
            {
                Console.ReadKey();
            }
            // listado.Add(contac);
            Console.ReadKey();
        }

    }


}
