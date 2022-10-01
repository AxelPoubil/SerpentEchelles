using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    public class Case
    {
        private Points points;
        private string type;
        private int position;
        private int largeur;
        private Random random = new Random();
        public int Points {get => points.ObtenirPoints(); set => points.ObtenirPoints(); }
        public int Largeur { get => largeur;}
        public int Position { get => position;}
        public Random Random { get => random; set => random = value; }
        public string Type { get => type;}

        public Case(Points points, int position)
        {
            this.points = points;
            this.position = position;
            this.largeur = 100;
        }

        protected PointF ObtenirCoordonees()
        {
            int y = (7 - (position / 8));
            int x = (position % 8);
            if ((position / 8) % 2 == 1)
            {
                x = 7 - x;
            }
            return new PointF { X = x * largeur, Y = y * largeur };
        }

        public virtual void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.DrawRectangle(Pens.Black, coordonees.X, coordonees.Y, largeur, largeur);
            graphics.DrawString((position).ToString(), font, Brushes.Black, coordonees.X + 30, coordonees.Y + 30);
        }
        public virtual int DeplacementSpecial()
        {
            return 0;
        }
    }
}
