﻿using System;
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
                    cases[i] = new CaseBase(new PointsBase(i), i);
                    
                }
                else if (resultatRandom<0.7)
                {
                    cases[i] = new CaseEchelle(new PointsQuitteDouble(i), i);
                }
                else if (resultatRandom<0.8)
                {
                    cases[i] = new CaseSerpent(new PointsNegatif(i), i);
                }
                else if (resultatRandom<0.9)
                {
                    cases[i] = new CaseSaut(new PointsQuitteDouble(i), i);
                }
                else
                {
                    cases[i] = new CaseTrappe(new PointsNegatif(i), i);
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

            Debug.WriteLine("de "+lancerDe);
            Debug.WriteLine("deplacement "+joueurCourant.position + joueurCourant.Nom);

            while (cases[joueurCourant.position].Type != "Base")
            {
                joueurCourant.Position += cases[joueurCourant.Position].DeplacementSpecial();
                joueurCourant.Bouger();
                Debug.WriteLine("deplacement special " + joueurCourant.position + " " + joueurCourant.Nom);
            }

            
           
            joueurCourant.Points += cases[joueurCourant.Position].Points;
            JoueurChanged.Invoke(this, joueurCourant);
            

        } 
        
    }
}
