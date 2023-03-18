using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio02
    {
        public double[] Calcular(int[] nums)
        {
            double suma = 0.0;

            foreach (int num in nums)
            {
                suma = suma + num;
            }

            double promedio = suma / nums.Length;

            return new double[] {suma, promedio};
        }
    }
}
