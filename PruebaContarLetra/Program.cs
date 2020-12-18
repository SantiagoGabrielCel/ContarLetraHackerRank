using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace PruebaContarLetra
{
    class Program
    {
        static string contarLetra(string cadena)
        {
            //Hecho con LINQ
            int iBlanco = 0;

            string sResultado = string.Empty;
            cadena = cadena.Replace(" ", "");
            for (int i = 0; i < cadena.Length; i++)
            {

                if (cadena[i].Equals(".") || cadena[i].Equals(",") || cadena[i].Equals(", "))
                {
                    iBlanco++;

                }

                else
                {
                    var Agrupar = cadena
                       .GroupBy(c => char.ToLowerInvariant(c))
                       .OrderByDescending(g => g.Count())
                       .First();

                    sResultado = $" La letra que más se repite es {Agrupar.Key} con  {Agrupar.Count()} repeticiones";


                }

            }
            return sResultado;

        }

        public static void Main()
        {

            string cadena = Console.ReadLine();

            string res = contarLetra(cadena);
            Console.WriteLine(res);

        }
    }
}
