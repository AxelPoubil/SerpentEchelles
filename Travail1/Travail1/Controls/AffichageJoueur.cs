using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Controllers;
using Travail1.Models;

namespace Travail1.Controls
{
    public class AffichageJoueur: PictureBox
    {
        public Joueur joueur;

        public AffichageJoueur(Joueur joueur) : base()
        {
            this.joueur = joueur;
            BackColor = Color.Transparent;
            Height = 801;
            Width = 801;
            Image = joueur.Dessiner();
            Abonnement();
        }
        public Joueur Joueur
        {
            get => joueur; set
            {
                joueur = value;
                Image=joueur.Dessiner();

            }
        }

        void Abonnement ()
        {
            joueur.ABouger += Joueur_ABouger;
        }

        private void Joueur_ABouger(object? sender, Joueur joueur)
        {
            Image = joueur.Dessiner();
        }
    }
}
