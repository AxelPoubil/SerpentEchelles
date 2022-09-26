namespace Travail1
{
    partial class FormJeu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlancheJeu = new System.Windows.Forms.PictureBox();
            this.labelTour = new System.Windows.Forms.Label();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlancheJeu
            // 
            this.picPlancheJeu.BackColor = System.Drawing.SystemColors.Control;
            this.picPlancheJeu.Location = new System.Drawing.Point(525, 15);
            this.picPlancheJeu.Margin = new System.Windows.Forms.Padding(6);
            this.picPlancheJeu.Name = "picPlancheJeu";
            this.picPlancheJeu.Size = new System.Drawing.Size(801, 801);
            this.picPlancheJeu.TabIndex = 0;
            this.picPlancheJeu.TabStop = false;
            // 
            // labelTour
            // 
            this.labelTour.AutoSize = true;
            this.labelTour.Location = new System.Drawing.Point(34, 83);
            this.labelTour.Name = "labelTour";
            this.labelTour.Size = new System.Drawing.Size(243, 41);
            this.labelTour.TabIndex = 1;
            this.labelTour.Text = "C\'est au tour de :";
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur2.Location = new System.Drawing.Point(34, 290);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(105, 28);
            this.labelJoueur2.TabIndex = 2;
            this.labelJoueur2.Text = "Joueur 2 :";
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur1.Location = new System.Drawing.Point(34, 250);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(105, 28);
            this.labelJoueur1.TabIndex = 3;
            this.labelJoueur1.Text = "Joueur 1 :";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(34, 200);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(114, 41);
            this.labelPoint.TabIndex = 4;
            this.labelPoint.Text = "Points :";
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelJoueur1);
            this.Controls.Add(this.labelJoueur2);
            this.Controls.Add(this.labelTour);
            this.Controls.Add(this.picPlancheJeu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJeu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPlancheJeu;
        private Label labelTour;
        private Label labelJoueur2;
        private Label labelJoueur1;
        private Label labelPoint;
    }
}