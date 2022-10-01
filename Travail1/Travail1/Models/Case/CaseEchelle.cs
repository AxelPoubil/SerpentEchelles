using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    class CaseEchelle : CaseBase
    {
        public CaseEchelle(Points points, int position) : base(points, position)
        {
        }
        public override void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.DrawRectangle(Pens.Black, coordonees.X, coordonees.Y, Largeur, Largeur);
            graphics.FillRectangle(Brushes.Gray, coordonees.X + 5, coordonees.Y + 5, Largeur - 10, Largeur - 10);
            graphics.DrawString((Position ).ToString(), font, Brushes.Black, coordonees.X + 30, coordonees.Y + 30);

        }

        public override int DeplacementSpecial()
        {
            return Random.Next(1 ,15);
        }
    }
}
