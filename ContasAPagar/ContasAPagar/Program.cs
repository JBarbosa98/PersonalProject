using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Celular = 60.00;
            const double Consorcio = 1090.91;
            const double Ingles = 350.00;
            const double Academia = 140.00;
            double CartaoCreditoItau;
            double CartaoCreditoSant;

            double resultado;

            Console.WriteLine("Escreva o valor da fatura do cartão Itau do mês " + DateTime.Now.Month);
            CartaoCreditoItau = Convert.ToDouble(Console.ReadLine().ToString());


            Console.WriteLine("Escreva o valor da fatura do cartão Santander do mês " + DateTime.Now.Month);
            CartaoCreditoSant = Convert.ToDouble(Console.ReadLine().ToString());

            resultado = CartaoCreditoItau + CartaoCreditoSant + Academia + Celular + Consorcio + Ingles;

            Console.WriteLine("Seus gastos desse mês serão = " + resultado);
            Console.ReadLine(); 
        }
    }
}
