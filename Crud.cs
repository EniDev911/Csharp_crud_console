using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Crud
    {  
        List<Libros> dataset = new List<Libros>();
        int id;
        string titulo, description;
        DateTime lanzamiento; 


        public void Crear_Libro()
        {
            Console.WriteLine("\tCrear nuevo registro");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese un identificador :");
            id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese un título :");
            titulo = Console.ReadLine();

            Console.WriteLine("Ingrese un descripción :");
            description = Console.ReadLine();

            Console.WriteLine("Ingrese fecha lanzamiento en el siguiente formaro :");
            Console.WriteLine("MM/DD/AA");
            lanzamiento = DateTime.Parse(Console.ReadLine());

            dataset.Add(new Libros(id, titulo, description, lanzamiento));
        }

        private bool lista_vacia()
        {
            if(dataset.Count == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void lista()
        {
            if(lista_vacia() == true)
            {
                System.Console.WriteLine("Lista se encuentra sin registro");
            }else
            {   
                System.Console.WriteLine("Total de registros: ", dataset.Count);
                System.Console.WriteLine("---------------Lista----------");

                foreach (Libros item in dataset)
                {
                    
                }
            }
        }

        private void mostrar(Libros datos)
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("id  : {0}", datos.idLibro);
            System.Console.WriteLine("título  : {1}", datos.Titulo);
            System.Console.WriteLine("descripción  : {2}", datos.Descripcion);
            System.Console.WriteLine("lanzamiento  : {3}", datos.Lanzaminto);
        }
    }
        

}