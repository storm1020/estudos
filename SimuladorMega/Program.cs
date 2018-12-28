using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMega
{
    public class Jogo
    {
        public int quantidadeDeJogos;
        public int quantidadeDeNumeros;

        public static int CapturarQuantidadeDeJogos()
        {
            Console.WriteLine("Digite a quantidade de jogos: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        public static int CapturarQuantidadeDeNumeros()
        {
            Console.WriteLine("Digite a quantidade de números referente aos jogos: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        public void Jogar (int qtdeJogos, int qtdeNumeros)
        {
            List<int> numeros = new List<int>();
            List<int> resultado = new List<int>();
            Random rd = new Random();

            while (qtdeJogos > 0)
            {
                numeros = Enumerable.Range(1, 60).OrderBy(x => rd.Next()).Take(qtdeNumeros).ToList();

                foreach (int item in numeros)
                {
                    resultado.Add(item);
                }

                Console.WriteLine(ExibirResultado(numeros));
                qtdeJogos--;
            }
        }

        public string ExibirResultado(List<int> lista)
        {
            return string.Join(",", lista).ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            int quantidadeDeJogos = Jogo.CapturarQuantidadeDeJogos();
            int quantidadeDeNumeros = Jogo.CapturarQuantidadeDeNumeros();
            jogo.Jogar(quantidadeDeJogos, quantidadeDeNumeros);

            #region Estruturada
            //List<int> numeros = new List<int>();
            //List<int> resultado = new List<int>();

            //Random rd = new Random();
            //while (quantidadeDeJogos > 0)
            //{ 
            //    numeros = Enumerable.Range(1, 60).OrderBy(x => rd.Next()).Take(quantidadeDeNumeros).ToList();

            //    foreach(int item in numeros)
            //    {
            //        resultado.Add(item);
            //    }
            //    Console.WriteLine(string.Join(", ", numeros));
            //    quantidadeDeJogos--;
            //}
            #endregion
        }
    }
}
