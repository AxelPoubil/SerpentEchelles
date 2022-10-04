using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail1.Controllers
{
    public partial class FormMenu : Form
    {
        public string nomJoueur1;
        public string nomJoueur2;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonJouer_Click(object sender, EventArgs e)
        {
            if (textBoxNom1.Text != "" && textBoxNom2.Text != "")
            {
                nomJoueur1 = textBoxNom1.Text;
                nomJoueur2 = textBoxNom2.Text;

                textBoxNom1.Text = "";
                textBoxNom2.Text = "";

                FormJeu formJeu = new FormJeu(nomJoueur1, nomJoueur2);
                formJeu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez entrer les deux noms des joueurs.");
            }
        }
    }
}
