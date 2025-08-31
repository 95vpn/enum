using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primaveta;
            Console.WriteLine(alergia);
        }
    }
    enum Estaciones { Primaveta, Verano, Otoño, Invierno};
}
