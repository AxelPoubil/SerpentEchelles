using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    internal class PointsQuitteDouble : Points
    {
        Random random;
        public PointsQuitteDouble(int valeur) : base(valeur)
        {
            random = new Random();
        }
        public override int ObtenirPoints()
        {
            int resltatRand = random.Next(0,2);
            if (resltatRand==0)
            {
                return 0;
            }
            else
            {

                return Valeur*2;
            }
        }
    }
}
