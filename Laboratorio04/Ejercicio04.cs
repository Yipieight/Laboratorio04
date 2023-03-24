using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad, int[] billetes)
        {
            int[] suma = new int[billetes.Length];
            int disponible = 0;
            int resta = cantidad;
            string resultado = "";
            for (int i = 0; i < billetes.Length; i++)
            {
                resta = resta - disponible;
                suma[i] = resta / billetes[i];
                disponible = suma[i] * billetes[i];
                resultado = suma[0]+","+ suma[1]+ "," + suma[2]+ "," + suma[3]+ "," + suma[4];
            }

            return new int[resultado];
        }
    }
}