using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Menu
    {
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
            Console.WriteLine("1 [C]rear registro   | 3 [E]liminar registro");
            Console.WriteLine("2 [L]istar registros | 4 [M]odificar registro");
            Console.WriteLine("0 [S]alir");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menu(opcion_menu);
        }
        private void seleccion_menu(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                default:
                    break;
            }
        }

        private void retornar_menu()
        {
            string op;
            Console.WriteLine("presione [r] para retornar al menu principal");
            op = Console.ReadLine();
            seleccion_menu(op);
        }
    }
}