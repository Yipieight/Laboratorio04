using System.Runtime.CompilerServices;

namespace Laboratorio04Tests
{
    [TestClass]
    public class Ejercicio05Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void TestCantidadDeBilletes(int cantidad, int[,] billetes, int[] resultado)
        {
            var ejercicio5 = new Ejercicio05();

            int[] resultadoActual = ejercicio5.CalcularBilletes(cantidad, billetes);

            Assert.AreEqual(resultado.GetLength(0), resultadoActual.GetLength(0), "El resultado no tiene la cantidad de billetes esperada");

            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                Assert.AreEqual(resultado[i], resultadoActual[i], $"El resultado ${i} no es correcto");
            }
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 23, new int[,] { { 1, -1 } }, new int[] { 23 } };
            yield return new object[] { 550, new int[,] { { 20, 10 }, { 10, 10 }, { 50, 4 }, { 1, -1 } }, new int[] { 10, 10, 4, 50 } };
            yield return new object[] { 553, new int[,] { { 20, 0 }, { 10, 0 }, { 50, 0 }, { 1, -1 } }, new int[] { 0, 0, 0, 553 } };
            yield return new object[] { 553, new int[,] { { 20, 0 }, { 10, 0 }, { 50, int.MinValue }, { 1, -2 } }, new int[] { 0, 0, 11, 3 } };
            yield return new object[] { 553, new int[,] { { 20, int.MaxValue }, { 10, int.MaxValue }, { 50, int.MaxValue }, { 1, -1 } }, new int[] { 27, 1, 0, 3 } };
            yield return new object[] { 553, new int[,] { { 50, int.MaxValue }, { 20, int.MaxValue }, { 10, int.MaxValue }, { 1, -1 } }, new int[] { 11, 0, 0, 3 } };
            yield return new object[] { 553, new int[,] { { 50, -1 }, { 20, -1 }, { 10, -1 }, { 1, -1 } }, new int[] { 11, 0, 0, 3 } };
            yield return new object[] { 1089, new int[,] { { 100, int.MaxValue }, { 50, int.MaxValue }, { 20, int.MaxValue }, { 10, int.MaxValue }, { 1, -1 } }, new int[] { 10, 1, 1, 1, 9 } };
        }
    }
}
