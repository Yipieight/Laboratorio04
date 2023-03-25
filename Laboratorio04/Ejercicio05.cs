using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio05
    {
        public int[] CalcularBilletes(int cantidad, int[,] billetes)
            {
            int[] resultado = new int[billetes.GetLength(0)];

            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                int denominacion = billetes[i, 0];
                int limite = billetes[i,1];

                if (limite >= 0 || limite == int.MaxValue)
                {
                    resultado[i] = Math.Min(cantidad / denominacion, limite);
                    Console.WriteLine(resultado[i]);
                }
                else if (limite < 0 || limite == int.MinValue)
                {
                    resultado[i] = cantidad / denominacion;
                }
                cantidad -= resultado[i] * denominacion;
            }
            return resultado;
            }
    }
}
