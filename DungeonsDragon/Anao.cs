using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGft.DungeonsDragon
{
    internal class Anao : Raca
    {
        public Anao(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) : 
            base(forca, destreza, constituicao, inteligencia, sabedoria, carisma)
        {
            AlteraPersonagem();
        }

        public override void AlteraPersonagem()
        {
            Constituicao += 2;
            Forca += 2;
            Sabedoria += 2;
        }
        public override string ToString()
        {
            return $"Anão: Força: {Forca}, Destreza: {Destreza}, Constituição: {Constituicao}, Inteligência: {Inteligencia} " +
                $", Sabedoria: {Sabedoria}, Carisma: {Carisma}";
        }
    }
}
