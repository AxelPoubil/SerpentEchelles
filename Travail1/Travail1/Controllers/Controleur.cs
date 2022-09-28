using System;
using System.Collections.Generic;
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
                    cases[i] = new CaseBase(new Points(i), i);
                    
                }
                else if (resultatRandom<0.7)
                {
                    cases[i] = new CaseEchelle(new Points(i), i);
                    Console.WriteLine(i);
                }
                else if (resultatRandom<0.8)
                {
                    cases[i] = new CaseSerpent(new Points(i), i);
                }
                else if (resultatRandom<0.9)
                {
                    cases[i] = new CaseSaut(new Points(i), i);
                }
                else
                {
                    cases[i] = new CaseTrappe(new Points(i), i);
                }
            }
        }

        private void InitialiserJoueurs()
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, "Remi", Color.Blue);
            joueurs[1] = new Joueur(1, "Axel", Color.Red);
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
            joueurCourant.position += lancerDe;
            joueurCourant.Bouger();
            if (joueurCourant.Position<0)
            {
                joueurCourant.Position = 0;
            }
            else if (joueurCourant.Position > 62)
            {
                joueurCourant.Position = 62;
            }
            joueurCourant.Points += cases[joueurCourant.Position + 1].Points;
            joueurCourant.Position += cases[joueurCourant.Position + 1].Deplacement();
            JoueurChanged.Invoke(this, joueurCourant);            
        } 
        
    }
}
