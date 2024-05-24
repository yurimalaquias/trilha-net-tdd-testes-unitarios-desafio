using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tddnetcore
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2) 
        { 
            int total = val1 + val2;
            listaHistorico.Insert(0, $"Total: {total} - Data: {data}");
            return total;
        }

        public int subtrair(int val1, int val2) 
        { 
            int total = val1 - val2;
            listaHistorico.Insert(0, $"Total: {total} - Data: {data}");
            return total; 
        }

        public int multiplicar(int val1, int val2) 
        { 
            int total = val1 * val2;
            listaHistorico.Insert(0, $"Total: {total} - Data: {data}");
            return total;
        }

        public int dividir(int val1, int val2) 
        {
            int total = val1 / val2;
            listaHistorico.Insert(0, $"Total: {total} - Data: {data}");
            return total; 
        }

        public List<string> historico() 
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico; 
        }
    }
}
