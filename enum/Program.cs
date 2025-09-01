using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Estaciones alergia = Estaciones.Primaveta;

            String La_alergia = alergia.ToString(); 
            Console.WriteLine(alergia);
            */

            /*
            Bonus Antonio = Bonus.bueno;

            double bonusAntonio = (double)Antonio;

            double salarioAntonio = 1500 + bonusAntonio;

            Console.WriteLine(salarioAntonio);
            */

            Empleado Juan = new Empleado(Bonus.extra, 1900.50);

            Console.WriteLine("El salario de empleado es: " + Juan.getSalario());

        }
    }
    /*
    enum Estaciones { Primaveta, Verano, Otoño, Invierno};
    */

    //enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000};

}
