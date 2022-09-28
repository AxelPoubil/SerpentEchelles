using System.Diagnostics;
using Travail1.Controllers;
using Travail1.Controls;
using Travail1.Models;

namespace Travail1
{
    public partial class FormJeu : Form
    {
        private Controleur controleur;
        private AffichageJoueur[] affichageJoueurs;

        public FormJeu()
        {
            InitializeComponent();
            controleur = new Controleur();
            picPlancheJeu.Image = controleur.DessinerPlancheJeu();
            InitAffichageJoueurs();
            Abonnement();
            MettreAjour(controleur.JoueurCourant);
        }

        

        private void InitAffichageJoueurs()
        {
            
            affichageJoueurs = new AffichageJoueur[controleur.Joueurs.Length];
            for (int i = 0; i < controleur.Joueurs.Length; ++i)
            {
                affichageJoueurs[i] = new AffichageJoueur(controleur.Joueurs[i]);
            }
            picPlancheJeu.Controls.Add(affichageJoueurs[0]);
            for (int i = 1; i < affichageJoueurs.Length; ++i)
            {
                affichageJoueurs[i - 1].Controls.Add(affichageJoueurs[i]);
            }
            
        }

        private void btn_Jouer_Click(object sender, EventArgs e)
        {
            FinDePartie();
            controleur.Jouer();
            controleur.JoueurSuivant();

        }

        private void MettreAjour(Joueur joueur)
        {
            statsJoueur1.Joueur = joueur;
        }

        private void Abonnement()
        {
            controleur.JoueurChanged += Controleur_JoueurChanged;
        }

        private void Controleur_JoueurChanged(object? sender, Joueur joueur)
        {
            MettreAjour(joueur);
        }

        private void FinDePartie()
        {
            if (controleur.JoueurCourant.Position >= 63)
            {
                controleur.JoueurCourant.Position = 63;
                DialogResult result = MessageBox.Show(controleur.JoueurCourant.Nom + " a gagn� la partie");
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}