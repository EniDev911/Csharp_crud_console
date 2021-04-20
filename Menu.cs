using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Menu
    {
        Crud objCrud = new Crud();
        string opcion_menu = "";
        public void iniciar()
        {
            do
            {
                Principal();
            } while(opcion_menu != "0");
        }
        private void Principal()
        {
            Console.Write("\n");
            Console.WriteLine("\tControl de Biblioteca");
            Console.WriteLine("---------------Menu Principal---------------");
            Console.WriteLine("[C]rear registro   | [E]liminar registro");
            Console.WriteLine("[L]istar registros | [M]odificar registro");
            Console.WriteLine("[S]alir");
            Console.WriteLine("Seleccione una opción ingresando un carácter entre corchetes");
            opcion_menu = Console.ReadLine();
            seleccion_menu(opcion_menu);
        }
        private void seleccion_menu(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "C":
                    Console.Clear();
                    objCrud.Crear_Libro();
                    Console.ReadLine();
                    break;
                case "L":
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case "E":
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case "M":
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case "S":
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case "R":
                    Console.Clear();
                    Principal();
                    Console.ReadLine();
                    break;                                                            
                default:
                    System.Console.WriteLine("Selección Inválida");
                    break;
            }
        }

        private void retornar_menu()
        {
            string op;
            Console.WriteLine("presione [R] para retornar al menu principal");
            op = Console.ReadLine();
            seleccion_menu(op);
        }
    }
}