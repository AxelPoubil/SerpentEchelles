using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail1.Models;

namespace Travail1.Controls
{
    public partial class StatsJoueur : UserControl
    {
        Joueur joueur;
        public StatsJoueur()
        {
            InitializeComponent();
        }
        public Joueur Joueur { get=> joueur; set
            {
                joueur = value;
                AffichageStatsJoueur();
                
            }
        }  
       
        

        private void AffichageStatsJoueur()
        {
            if (Joueur.Id==0)
            {
                labelTour.Text = "C'est au tour de : " + Joueur.Nom;
                labelTour.ForeColor = Joueur.Couleur;
                labelJoueur1.Text = "Joueur 1 : "+ Joueur.Points;
                labelPoint.Text = "Points : " + Joueur.Points;
            }
            else
            {
                labelTour.Text = "C'est au tour de : " + Joueur.Nom;
                labelTour.ForeColor = Joueur.Couleur;
                labelJoueur2.Text = "Joueur 1 : " + Joueur.Points;
                labelPoint.Text = "Points : " + Joueur.Points;
            }
            
        }
    }
}
