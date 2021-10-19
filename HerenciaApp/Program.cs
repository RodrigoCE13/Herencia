using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerenciaLibrary;

namespace HerenciaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            suma sum = new suma();
            sum.Valor1 = 10;
            sum.Valor2 = 5;
            sum.Calcular();
            sum.Resultado();

            resta res = new resta();
            res.Valor1 = 10;
            res.Valor2 = 5;
            res.Calcular();
            res.Resultado();

            Console.ReadKey();

        }
    }
}
