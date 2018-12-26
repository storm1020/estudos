using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMega
{
    public class Jogo : Random
    {
        public int number = new Random().Next();
        public Random rd = new Random();

        public void Jogar (string opcao)
        {            
            if (opcao == "6" || opcao == "7" || opcao == "8")
            {
                switch (opcao)
                {
                    case "6":
                        int[] seisNumeros = new int[6];
                        for (int i = 0; i < seisNumeros.Length; i++)
                        {
                            if (seisNumeros[i] != number)
                            {
                                seisNumeros[i] = rd.Next(0, 60);
                            }
                        }
                        foreach (var item in seisNumeros)
                        {
                            Console.WriteLine("Seis números: " + item);
                        }
                        break;

                    case "7":
                        int[] seteNumeros = new int[7];
                        for (int i = 0; i < seteNumeros.Length; i++)
                        {
                            if (seteNumeros[i] != number)
                            {
                                seteNumeros[i] = rd.Next(0, 60);
                            }
                        }
                        foreach (var item in seteNumeros)
                        {
                            Console.WriteLine("Sete números: " + item);
                        }
                        break;
                    case "8":
                        int[] oitoNumeros = new int[8];
                        for (int i = 0; i < oitoNumeros.Length; i++)
                        {
                            if (oitoNumeros[i] != number)
                            {
                                oitoNumeros[i] = rd.Next(0, 60);
                            }
                        }
                        foreach (var item in oitoNumeros)
                        {
                            Console.WriteLine("Oito números: " + item);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Escolha entre 6, 7 ou 8 números.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            Console.WriteLine("Digite: 6 para SEIS números, 7 para SETE números, 8 para OITO números");
            string retorno = Console.ReadLine();
            jogo.Jogar(retorno);
        }
    }
}
