using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2) 
        {

            BigInteger n1 = BigInteger.Parse(num1);
            BigInteger n2 = BigInteger.Parse(num2);
            BigInteger Suma = n1 + n2;
            return Suma.ToString();
        }
    }
}
