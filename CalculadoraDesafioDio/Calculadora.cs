using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDesafioDio
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int somar(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
            listaHistorico.Insert(0, "Resultado: " + result);
        }

        public int subtrair(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
            listaHistorico.Insert(0, "Resultado: " + result);
        }

        public int multiplicar(int value1, int value2)
        {
            int result = value1 * value2;
            return result;
            listaHistorico.Insert(0, "Resultado: " + result);
        }

        public int dividir(int value1, int value2)
        {
            int result = value1 / value2;
            return result;
            listaHistorico.Insert(0, "Resultado: " + result);
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
