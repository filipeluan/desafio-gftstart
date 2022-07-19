using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGft.DungeonsDragon
{
    internal class Humano : Raca
    {
        public Humano(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) : 
            base(forca, destreza, constituicao, inteligencia, sabedoria, carisma)
        {
            AlteraPersonagem();
        }

        public override void AlteraPersonagem()
        {
            Forca += 1;
            Destreza += 1;
            Constituicao += 1;
            Inteligencia += 1;
            Sabedoria += 1;
            Carisma += 1;
        }
        public override string ToString()
        {
            return $"Humano: Força: {Forca}, Destreza: {Destreza}, Constituição: {Constituicao}, Inteligência: {Inteligencia} " +
                $", Sabedoria: {Sabedoria}, Carisma: {Carisma}";
        }
    }
}
