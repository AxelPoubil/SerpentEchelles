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
        public Random random=new Random(9);

        public Joueur[] Joueurs { get => joueurs; }

        public Controleur()
        {
            InitialiserCases();
            InitialiserJoueurs();
        }

        private void InitialiserCases()
        {
            
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                float resultatRandom=random.NextSingle();
                if (resultatRandom<0.6)
                {
                    cases[i] = new CaseBase(new Points(0), i);
                    
                }
                else if (resultatRandom<0.7)
                {
                    cases[i] = new CaseEchelle(new Points(0), i);
                }
                else if (resultatRandom<0.8)
                {
                    cases[i] = new CaseSerpent(new Points(0), i);
                }
                else if (resultatRandom<0.9)
                {
                    cases[i] = new CaseSaut(new Points(0), i);
                }
                else
                {
                    cases[i] = new CaseTrappe(new Points(0), i);
                }
            }
        }

        private void InitialiserJoueurs()
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, "joueur1", Color.Blue);
            joueurs[1] = new Joueur(1, "joueur2", Color.Red);
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
    }
}
