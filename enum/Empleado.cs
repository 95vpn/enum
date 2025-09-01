using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  @enum
{
    public class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = bonusEmpleado;

            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + (double)bonus;
        }


        private double salario;
        private Bonus bonus;
    }
    public enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000}
}
