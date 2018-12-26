using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosAplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horario agora = new Horario(11, 25, 30);
            //Console.WriteLine("Agora são {0} horas", agora.Hora());

            //Horario copia = agora;
            //Console.WriteLine("Agora são {0} horas", copia.Hora());

            //Mes atual = new Mes(27, 2013);
            //Console.WriteLine("Dia atual {0}, ano atual {1}: ", atual.Dia(), atual.Ano());

            Sapatos so = new Sapatos();
            foreach (var item in so.GetTipos())
            {
                Console.WriteLine(item);
            }
            

        }

        struct Mes
        {
            private int dia, ano;

            public Mes(int d, int a)
            {
                this.dia = d % 30;
                this.ano = a % 2000;
            }

            public int Dia()
            {
                return this.dia;
            }

            public int Ano()
            {
                return this.ano;
            }
        }

        struct Horario
        {
            private int hora, minuto, segundo;

            public Horario(int hora, int minuto, int segundo)
            {
                this.hora = hora % 24;
                this.minuto = minuto % 60;
                this.segundo = segundo % 60;
            }

            public int Hora()
            {
                return this.hora;
            }
        }

        public class Enums
        {
            public enum Cartoes : int
            {
                CARTAO_CREDITO = 1,
                CARTAO_DEBITO = 2,
                CARTAO_DESCONHECIDO = 3,
                CARTAO_VOUCHER = 4
            }

            public enum Tipos : int
            {
                SAPATENIS = 0,
                SAPATO = 1,
                TENIS = 2,
                CHINELO = 3
            }

            public List<string> GetTipos()
            {
                Dictionary<int, string> dtyTipos = new Dictionary<int, string>();
                List<string> retorno = new List<string>();
                var tipos = Enum.GetValues(typeof(Tipos));

                for (int i = 0; i < tipos.Length; i++)
                {
                    dtyTipos.Add(i, tipos.GetValue(i).ToString()); 
                }

                foreach (var item in dtyTipos)
                {
                    retorno.Add(item.Key + " " + item.Value);
                }

                return retorno;
            }
        }


        public class Sapatos : Enums
        {
            public double Valor { get; set; }
        }
    }
}
