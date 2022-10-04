using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models
{
    internal class De
    {
        int nbFace;
        Random random;
        public int NbFace { get => nbFace; set => nbFace = value; }
        public De(int face)
        {
            this.nbFace = face;
            random = new Random();
        }


        public int brasserDe()
        {
            int resultat=random.Next(1, nbFace + 1);
            return resultat;
        }
        
    }
}
