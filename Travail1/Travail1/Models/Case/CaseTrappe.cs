using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    class CaseTrappe : CaseSerpent
    {
        public CaseTrappe(Points points, int position) : base(points, position)
        {
            
        }
        public override void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.DrawRectangle(Pens.Maroon, coordonees.X, coordonees.Y, Largeur, Largeur);
            graphics.DrawString((Position + 1).ToString(), font, Brushes.Maroon, coordonees.X + 30, coordonees.Y + 30);

        }
    }
}
