using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGft.DungeonsDragon
{
    abstract class Raca
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }

        public Raca(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma)
        {
            this.Forca = forca;
            this.Destreza = destreza;
            this.Constituicao = constituicao;
            this.Inteligencia = inteligencia;
            this.Sabedoria = sabedoria;
            this.Carisma = carisma;
        }

        public abstract void AlteraPersonagem();
    }
}
