using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    internal class PointsNegatif : Points
    {
        public PointsNegatif(int valeur) : base(valeur)
        {
        }

        public override int ObtenirPoints()
        {
            return Valeur - Valeur - Valeur;
        }
    }
}
