using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGft.DungeonsDragon
{
    class Elfo : Raca
    {
        public Elfo(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) : 
            base(forca, destreza, constituicao, inteligencia, sabedoria, carisma)
        {
            AlteraPersonagem();
        }

        public override void AlteraPersonagem()
        {
            Destreza += 2;
            Carisma += 2;
            Inteligencia += 2;
        }
        public override string ToString()
        {
            return $"Elfo: Força: {Forca}, Destreza: {Destreza}, Constituição: {Constituicao}, Inteligência: {Inteligencia} " +
                $", Sabedoria: {Sabedoria}, Carisma: {Carisma}";
        }
    }
}
