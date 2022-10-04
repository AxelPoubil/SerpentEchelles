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
            this.label_CaseDeBase = new System.Windows.Forms.Label();
            this.pictBoxLegendBase = new System.Windows.Forms.PictureBox();
            this.pictBoxLegendEchelle = new System.Windows.Forms.PictureBox();
            this.label_CaseEchelle = new System.Windows.Forms.Label();
            this.pictBoxLegendSerpent = new System.Windows.Forms.PictureBox();
            this.label_CaseSerpent = new System.Windows.Forms.Label();
            this.pictBoxLegendSaut = new System.Windows.Forms.PictureBox();
            this.label_CaseSaut = new System.Windows.Forms.Label();
            this.pictBoxLegendTrappe = new System.Windows.Forms.PictureBox();
            this.label_CaseTrappe = new System.Windows.Forms.Label();
            this.statsJoueur1 = new Travail1.Controls.StatsJoueur();
            this.btn_Jouer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendEchelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendSerpent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendSaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendTrappe)).BeginInit();
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
            // label_CaseDeBase
            // 
            this.label_CaseDeBase.AutoSize = true;
            this.label_CaseDeBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CaseDeBase.Location = new System.Drawing.Point(333, 416);
            this.label_CaseDeBase.Name = "label_CaseDeBase";
            this.label_CaseDeBase.Size = new System.Drawing.Size(133, 28);
            this.label_CaseDeBase.TabIndex = 5;
            this.label_CaseDeBase.Text = "Case de base: ";
            // 
            // pictBoxLegendBase
            // 
            this.pictBoxLegendBase.BackColor = System.Drawing.Color.White;
            this.pictBoxLegendBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictBoxLegendBase.Location = new System.Drawing.Point(472, 416);
            this.pictBoxLegendBase.Name = "pictBoxLegendBase";
            this.pictBoxLegendBase.Size = new System.Drawing.Size(44, 30);
            this.pictBoxLegendBase.TabIndex = 10;
            this.pictBoxLegendBase.TabStop = false;
            // 
            // pictBoxLegendEchelle
            // 
            this.pictBoxLegendEchelle.BackColor = System.Drawing.Color.Gray;
            this.pictBoxLegendEchelle.Location = new System.Drawing.Point(472, 457);
            this.pictBoxLegendEchelle.Name = "pictBoxLegendEchelle";
            this.pictBoxLegendEchelle.Size = new System.Drawing.Size(44, 30);
            this.pictBoxLegendEchelle.TabIndex = 12;
            this.pictBoxLegendEchelle.TabStop = false;
            // 
            // label_CaseEchelle
            // 
            this.label_CaseEchelle.AutoSize = true;
            this.label_CaseEchelle.BackColor = System.Drawing.SystemColors.Control;
            this.label_CaseEchelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CaseEchelle.Location = new System.Drawing.Point(340, 457);
            this.label_CaseEchelle.Name = "label_CaseEchelle";
            this.label_CaseEchelle.Size = new System.Drawing.Size(126, 28);
            this.label_CaseEchelle.TabIndex = 11;
            this.label_CaseEchelle.Text = "Case échelle: ";
            // 
            // pictBoxLegendSerpent
            // 
            this.pictBoxLegendSerpent.BackColor = System.Drawing.Color.Green;
            this.pictBoxLegendSerpent.Location = new System.Drawing.Point(472, 499);
            this.pictBoxLegendSerpent.Name = "pictBoxLegendSerpent";
            this.pictBoxLegendSerpent.Size = new System.Drawing.Size(44, 30);
            this.pictBoxLegendSerpent.TabIndex = 14;
            this.pictBoxLegendSerpent.TabStop = false;
            // 
            // label_CaseSerpent
            // 
            this.label_CaseSerpent.AutoSize = true;
            this.label_CaseSerpent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CaseSerpent.Location = new System.Drawing.Point(336, 499);
            this.label_CaseSerpent.Name = "label_CaseSerpent";
            this.label_CaseSerpent.Size = new System.Drawing.Size(131, 28);
            this.label_CaseSerpent.TabIndex = 13;
            this.label_CaseSerpent.Text = "Case serpent: ";
            // 
            // pictBoxLegendSaut
            // 
            this.pictBoxLegendSaut.BackColor = System.Drawing.Color.SkyBlue;
            this.pictBoxLegendSaut.Location = new System.Drawing.Point(472, 541);
            this.pictBoxLegendSaut.Name = "pictBoxLegendSaut";
            this.pictBoxLegendSaut.Size = new System.Drawing.Size(44, 30);
            this.pictBoxLegendSaut.TabIndex = 16;
            this.pictBoxLegendSaut.TabStop = false;
            // 
            // label_CaseSaut
            // 
            this.label_CaseSaut.AutoSize = true;
            this.label_CaseSaut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CaseSaut.Location = new System.Drawing.Point(364, 541);
            this.label_CaseSaut.Name = "label_CaseSaut";
            this.label_CaseSaut.Size = new System.Drawing.Size(102, 28);
            this.label_CaseSaut.TabIndex = 15;
            this.label_CaseSaut.Text = "Case saut: ";
            // 
            // pictBoxLegendTrappe
            // 
            this.pictBoxLegendTrappe.BackColor = System.Drawing.Color.Maroon;
            this.pictBoxLegendTrappe.Location = new System.Drawing.Point(472, 583);
            this.pictBoxLegendTrappe.Name = "pictBoxLegendTrappe";
            this.pictBoxLegendTrappe.Size = new System.Drawing.Size(44, 30);
            this.pictBoxLegendTrappe.TabIndex = 18;
            this.pictBoxLegendTrappe.TabStop = false;
            // 
            // label_CaseTrappe
            // 
            this.label_CaseTrappe.AutoSize = true;
            this.label_CaseTrappe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CaseTrappe.Location = new System.Drawing.Point(347, 583);
            this.label_CaseTrappe.Name = "label_CaseTrappe";
            this.label_CaseTrappe.Size = new System.Drawing.Size(124, 28);
            this.label_CaseTrappe.TabIndex = 17;
            this.label_CaseTrappe.Text = "Case trappe: ";
            // 
            // statsJoueur1
            // 
            this.statsJoueur1.Joueur = null;
            this.statsJoueur1.Location = new System.Drawing.Point(12, 9);
            this.statsJoueur1.Margin = new System.Windows.Forms.Padding(6);
            this.statsJoueur1.Name = "statsJoueur1";
            this.statsJoueur1.Size = new System.Drawing.Size(504, 312);
            this.statsJoueur1.TabIndex = 19;
            // 
            // btn_Jouer
            // 
            this.btn_Jouer.Location = new System.Drawing.Point(12, 330);
            this.btn_Jouer.Name = "btn_Jouer";
            this.btn_Jouer.Size = new System.Drawing.Size(231, 129);
            this.btn_Jouer.TabIndex = 20;
            this.btn_Jouer.Text = "Jouer";
            this.btn_Jouer.UseVisualStyleBackColor = true;
            this.btn_Jouer.Click += new System.EventHandler(this.btn_Jouer_Click);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.btn_Jouer);
            this.Controls.Add(this.statsJoueur1);
            this.Controls.Add(this.pictBoxLegendTrappe);
            this.Controls.Add(this.label_CaseTrappe);
            this.Controls.Add(this.pictBoxLegendSaut);
            this.Controls.Add(this.label_CaseSaut);
            this.Controls.Add(this.pictBoxLegendSerpent);
            this.Controls.Add(this.label_CaseSerpent);
            this.Controls.Add(this.pictBoxLegendEchelle);
            this.Controls.Add(this.label_CaseEchelle);
            this.Controls.Add(this.pictBoxLegendBase);
            this.Controls.Add(this.label_CaseDeBase);
            this.Controls.Add(this.picPlancheJeu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJeu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendEchelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendSerpent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendSaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLegendTrappe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPlancheJeu;
        private Label label_CaseDeBase;
        private PictureBox pictBoxLegendBase;
        private PictureBox pictBoxLegendEchelle;
        private Label label_CaseEchelle;
        private PictureBox pictBoxLegendSerpent;
        private Label label_CaseSerpent;
        private PictureBox pictBoxLegendSaut;
        private Label label_CaseSaut;
        private PictureBox pictBoxLegendTrappe;
        private Label label_CaseTrappe;
        private Controls.StatsJoueur statsJoueur1;
        private Button btn_Jouer;
    }
}