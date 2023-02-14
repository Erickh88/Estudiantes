using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
   
      class Calculadora

    {
        /** delimitadores de acceso Public  Private Protected */
        /** static */

        public static string nombre;
        public static int edad;
        void sumar() { Console.WriteLine(5 + 3); }
        public  void restar()
        {
            
            Console.WriteLine(5 - 3); 
        }
        public  void dividir() { Console.WriteLine(5 / 3); }
        public static void multiplicar() { Console.WriteLine(5 * 3); }

        private static void calculos() { }

    }
}
