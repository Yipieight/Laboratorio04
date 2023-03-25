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
            
            int[] resultado = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                // Calcular cuántos billetes se necesitan para cubrir la cantidad restante.
                int cantidadDeBilletes = cantidad / billetes[i];

                // Guardar la cantidad de billetes necesarios en el arreglo de resultados.
                resultado[i] = cantidadDeBilletes;

                // Restar la cantidad de dinero cubierta por los billetes ya calculados.
                cantidad -= cantidadDeBilletes * billetes[i];
            }

            return resultado;
        }
    }
}