using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDePalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Vamos a jugar con las palabras, Ok?");

            Console.WriteLine("Ingrese la cantidad de palabras");

            int CantidadDePalabras = Convert.ToInt32(Console.ReadLine());

            //string[] CantidadDeCaracteres = new string[CantidadDePalabras];

            List<string> conteoDepalabras = new List<string>();
            int Caracteres = 0;

            Console.WriteLine("Ahora Ingrese las palabras:");

            for (int i = 0; i < CantidadDePalabras; i++)
            {
                string PalabraIngresada = Console.ReadLine();

                conteoDepalabras.Add(PalabraIngresada);
            }

            for (int j = 0; j < conteoDepalabras.Count; j++)
            {
                conteoDepalabras[j].Count();
                Caracteres += conteoDepalabras[j].Length;
            }

            Console.WriteLine("Las palabras ingresadas son: " + conteoDepalabras.Count);
            Console.WriteLine("La cantidad de caracteres utilizados es de: " + Caracteres);
            Console.ReadKey();
        }
    }
}
