﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models
{
    public class Joueur
    {
        private int id;
        private string nom;
        private int points;
        public int position;
        private Color couleur;
        private int diametre;

        public int Id { get => id; }
        public string Nom { get => nom; }
        public int Points { get => points; set => points = value; }
        public int Position { get => position; set => position = value; }
        public Color Couleur { get => couleur;}

        public event EventHandler<Joueur> ABouger;

        public Joueur(int id, string nom, Color couleur)
        {
            this.id = id;
            this.nom = nom;
            this.points = 0;
            this.position = 0;
            this.couleur = couleur;
            this.diametre = 20;
        }

        private PointF ObtenirCoordonees()
        {
            int y = (7 - (position / 8));
            int x = (position % 8);
            if ((position / 8) % 2 == 1)
            {
                x = 7 - x;
            }
            return new PointF { X = x * 100, Y = y * 100 + id * diametre };
        }

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(801, 801);
            var brush = new SolidBrush(couleur);
            var coordonees = ObtenirCoordonees();

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillEllipse(brush, coordonees.X, coordonees.Y, diametre, diametre);
            }
            return bitmap;
        }

        public void Bouger()
        {
            ABouger.Invoke(this, this);
        }
        
    }
}
