using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._08
{
    class Program
    {
        static void Main(string[] args)
        {

            int placar01 = 0, placar02 = 0,
                agregado01 = 0, agregado02 = 0;
            string semifinal01, semifinal02;


            Console.WriteLine("SIMULADOR COPA DO BRASIL");
            Console.WriteLine("SEMI FINAL 01");
            Console.WriteLine("SPFC X FLAMENGO");

            Console.WriteLine("INSIRA A QUANTIDADE DE" +
                "GOLS DO SPFC NO PRIMEIRO JOGO");
            placar01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira a quantidade de" +
                "gols do flamengo no primeiro jogo");
            placar02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("resultado do jogo de ida");
            Console.WriteLine("SPFC {0} X {1} FLAMENGO", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();

            agregado01 = placar01;

            Console.WriteLine("INSIRA A QUANTIDADE DE" +
                "GOLS DO SPFC NO SEGUNDO JOGO");
            placar01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira a quantidade de" +
                "gols do flamengo no segundo jogo");
            placar02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("resultado do jogo de volta");
            Console.WriteLine("SPFC {0} X {1} FLAMENGO", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Placar Agregado");
            placar01 = placar01 + agregado01;
            placar02 = placar02 + agregado02;
            Console.WriteLine("SPFC {0} X {1} FLAMENGO", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();

            if (placar01 > placar02)
            {
                Console.WriteLine("SPFC passou!");
                semifinal01 = "SPFC";
            }
            else if (placar01 > placar02)
            {
                Console.WriteLine("FLAMENGO PASSOU!");
                semifinal01 = "FLAMENGO";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("QUAL TIME CLASSIFICOU? SPFC/FLAMENGO");
                semifinal01 = Console.ReadLine();
            }




            Console.WriteLine("SIMULADOR COPA DO BRASIL");
            Console.WriteLine("SEMI FINAL 02");
            Console.WriteLine(" FLUMINENSE X Corinthians");

            Console.WriteLine("INSIRA A QUANTIDADE DE " +
                "GOLS DO  FLUMINENSE NO PRIMEIRO JOGO");
            placar01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira a quantidade de" +
                "gols do Corinthians no primeiro jogo");
            placar02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("resultado do jogo de ida");
            Console.WriteLine(" FLUMINENSE {0} X {1} Corinthians", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();

            agregado01 = placar01;
            agregado02 = placar02;

            Console.WriteLine("SIMULADOR COPA DO BRASIL");
            Console.WriteLine("SEMI FINAL 02");
            Console.WriteLine("FLUMINENSE X Corinthians");

            Console.WriteLine("INSIRA A QUANTIDADE DE" +
                "GOLS DO  FLUMINENSE NO SEGUNDO JOGO");
            placar01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira a quantidade de" +
                "gols do corintians no segundo jogo");
            placar02 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("resultado do jogo de volta");
            Console.WriteLine(" FLUMINENSE {0} X {1} Corinthians", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Placar Agregado");
            placar01 = placar01 + agregado01;
            placar02 = placar02 + agregado02;
            Console.WriteLine(" FLUMINENSE {0} X {1} Corinthians", placar01,
                placar02);
            Console.ReadKey();
            Console.Clear();

            if (placar01 > placar02)
            {
                Console.WriteLine(" FLUMINENSE passou!");
                semifinal02 = "FLUMINENSE";
            }
            else if (placar02 > placar01)
            {
                Console.WriteLine("Corinthians PASSOU!");
                semifinal02 = "Corinthians";
            }
            {
                Console.Clear();
                Console.WriteLine("Qual time classificou? Fluminense/Corinthians");
                semifinal02 = Console.ReadLine();
            }

            Console.WriteLine("SIMULADOR COPA DO BRASIL");
            Console.WriteLine("FINAL");
            Console.WriteLine("{0} X {1}", semifinal01, semifinal02 );

            Console.WriteLine("INSIRA A QUANTIDADE DE" +
                "GOLS DO {0} NO SEGUNDO JOGO",semifinal01);
            placar01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira a quantidade de" +
                "gols do {0} no SEGUNDO jogo",semifinal02);
            placar02 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("resultado do jogo de ida");
            Console.WriteLine("{0} {1} X {2} {3}", semifinal01, placar01, 
                placar02, semifinal02);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Placar Agregado");
            Console.WriteLine("{0} {1} x {2} {3}", semifinal01, placar01, 
            placar02, semifinal02);

            if (placar01 > placar02)
            {
                Console.WriteLine(" O CAMPEÃO FOI: {0} ", semifinal01);
                Console.ReadKey();
            }
            else if (placar01 < placar02)
            {
                Console.WriteLine("O CAMPEÃO FOI: {0}", semifinal02);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Escolha quem foi o campeão: {0}/{1}", semifinal01, semifinal02);
                Console.ReadKey();
            }


           


        }
    }
}
