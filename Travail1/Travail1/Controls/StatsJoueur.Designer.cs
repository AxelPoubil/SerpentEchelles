namespace Travail1.Controls
{
    partial class StatsJoueur
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.labelTour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPoint.Location = new System.Drawing.Point(3, 63);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(105, 31);
            this.labelPoint.TabIndex = 8;
            this.labelPoint.Text = "Points :";
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur1.Location = new System.Drawing.Point(3, 94);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(156, 31);
            this.labelJoueur1.TabIndex = 7;
            this.labelJoueur1.Text = "Joueur 1 : 0";
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur2.Location = new System.Drawing.Point(3, 125);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(156, 31);
            this.labelJoueur2.TabIndex = 6;
            this.labelJoueur2.Text = "Joueur 2 : 0";
            // 
            // labelTour
            // 
            this.labelTour.AutoSize = true;
            this.labelTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTour.Location = new System.Drawing.Point(3, 32);
            this.labelTour.Name = "labelTour";
            this.labelTour.Size = new System.Drawing.Size(219, 31);
            this.labelTour.TabIndex = 5;
            this.labelTour.Text = "C\'est au tour de :";
            // 
            // StatsJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelJoueur1);
            this.Controls.Add(this.labelJoueur2);
            this.Controls.Add(this.labelTour);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatsJoueur";
            this.Size = new System.Drawing.Size(535, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPoint;
        private Label labelJoueur1;
        private Label labelJoueur2;
        private Label labelTour;
    }
}
