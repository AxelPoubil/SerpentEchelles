using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        Joueur joueurCourant;
        De de;
        Random random;
        int index = 0;
        
        

        public Joueur[] Joueurs { get => joueurs; }
        public Joueur JoueurCourant { get => joueurCourant; set => joueurCourant = value; }

        public event EventHandler<Joueur> JoueurChanged;

        public Controleur()
        {
            random = new Random(9);
            de = new De(6);
            InitialiserCases();
            InitialiserJoueurs();
            joueurCourant = joueurs[index];
        }

        private void InitialiserCases()
        {
            
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                float resultatRandom=random.NextSingle();
                if (resultatRandom<0.6)
                {
                    cases[i] = new CaseBase(new PointsBase(i), i,"Base");
                    
                }
                else if (resultatRandom<0.7)
                {
                    cases[i] = new CaseEchelle(new PointsQuitteDouble(i), i,"Echelle");
                }
                else if (resultatRandom<0.8)
                {
                    cases[i] = new CaseSerpent(new PointsNegatif(i), i,"Serpent");
                }
                else if (resultatRandom<0.9)
                {
                    cases[i] = new CaseSaut(new PointsQuitteDouble(i), i,"Saut");
                }
                else
                {
                    cases[i] = new CaseTrappe(new PointsNegatif(i), i,"Trappe");
                }
            }
        }

        private void InitialiserJoueurs()
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, "", Color.Blue);
            joueurs[1] = new Joueur(1, "", Color.Red);
        }

        public Bitmap DessinerPlancheJeu()
        {
            Bitmap bitmap = new Bitmap(801, 801);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (var uneCase in cases)
                {
                    uneCase.Dessiner(graphics);
                    
                }
            }
            return bitmap;
        }

        public void JoueurSuivant()
        {
            index = (index + 1) % joueurs.Count();
            joueurCourant = joueurs[index];
            JoueurChanged.Invoke(this, joueurCourant);
        }

        public void Jouer()
        {
            int lancerDe = de.brasserDe();
            joueurCourant.Position += lancerDe;
            joueurCourant.Bouger();

            Debug.WriteLine("lancer du de: "+lancerDe);
            Debug.WriteLine("deplacement a la case: "+joueurCourant.position + ". du joueur:"+ joueurCourant.Nom);

            while (cases[joueurCourant.position].Type != "Base")
            {
                Debug.WriteLine("deplacement special a la case:  " + cases[joueurCourant.Position].Type + " " + cases[joueurCourant.Position].Position + ". " );

                joueurCourant.Position += cases[joueurCourant.Position].DeplacementSpecial();
                joueurCourant.Bouger();

                Debug.WriteLine("Placement apres deplacment special:" + joueurCourant.Position + ". du joueur:  " + joueurCourant.Nom);

                joueurCourant.Points += cases[joueurCourant.Position].Points;
                JoueurChanged.Invoke(this, joueurCourant);

                if (joueurCourant.Position>=63)
                {
                    return;
                }

            }

            
           
            joueurCourant.Points += cases[joueurCourant.Position].Points;
            JoueurChanged.Invoke(this, joueurCourant);
            

        } 
        public string finDePartie()
        {
            int scoreMax=-1;
            int indexJoueur=-1;
            string resultat = "";
            foreach (Joueur joueur in joueurs)
            {
                if (joueur.Points>scoreMax)
                {
                    scoreMax = joueur.Points;
                    indexJoueur = joueur.Id;
                }
                resultat = "Le gagnant est: " + joueurs[indexJoueur].Nom + " avec un total de " + joueurs[indexJoueur].Points + " points";
            }
            return resultat;
            
        }
        
    }
}
