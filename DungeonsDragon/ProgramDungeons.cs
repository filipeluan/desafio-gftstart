using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGft.DungeonsDragon
{
     public class ProgramDungeons
    {
        public void IniciaDungeons ()
        {
            var opcao = "";
            do
            {
                Console.WriteLine("Digite o valor da Força do Personagem (entre 3 e 18): ");
                int forca = int.Parse(Console.ReadLine());
                if (forca < 3 || forca > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Digite o valor da Destreza do Personagem (entre 3 e 18): ");
                int destreza = int.Parse(Console.ReadLine());
                if (destreza < 3 || destreza > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Digite o valor da Consituição do Personagem (entre 3 e 18): ");
                int constituicao = int.Parse(Console.ReadLine());
                if (constituicao < 3 || constituicao > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Digite o valor da Inteligência do Personagem (entre 3 e 18): ");
                int inteligencia = int.Parse(Console.ReadLine());
                if (inteligencia < 3 || inteligencia > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Digite o valor da Sabedoria do Personagem (entre 3 e 18): ");
                int sabedoria = int.Parse(Console.ReadLine());
                if (sabedoria < 3 || sabedoria > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Digite o valor da Carisma do Personagem (entre 3 e 18): ");
                int carisma = int.Parse(Console.ReadLine());
                if (carisma < 3 || carisma > 18)
                    Console.WriteLine("Valor inválido!");
                Console.WriteLine("Escolha o seu Personagem (anao, elfo ou humano): ");
                opcao = Console.ReadLine();
                if (opcao != "anao" && opcao != "elfo" && opcao != "humano")
                    Console.WriteLine("Escolha um personagem entre anao, elfo e humano");

                if(opcao == "anao")
                {
                    Anao anao = new Anao(forca, destreza, constituicao, inteligencia, sabedoria, carisma);
                    Console.WriteLine(anao.ToString());
                } else if (opcao == "elfo")
                {
                    Elfo elfo = new Elfo(forca, destreza, constituicao, inteligencia, sabedoria, carisma);
                    Console.WriteLine(elfo.ToString());
                }
                else if(opcao == "humano")
                {
                    Humano humano = new Humano(forca, destreza, constituicao, inteligencia, sabedoria, carisma);
                    Console.WriteLine(humano.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Deseja adicionar outro pesonagem? Digite 1 para continuar ou 2 para sair");
                opcao = Console.ReadLine();
            } while (opcao != "2");
        }
    }
}
