namespace Travail1.Controllers
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonJouer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom1 = new System.Windows.Forms.TextBox();
            this.textBoxNom2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonJouer
            // 
            this.buttonJouer.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonJouer.Location = new System.Drawing.Point(173, 247);
            this.buttonJouer.Name = "buttonJouer";
            this.buttonJouer.Size = new System.Drawing.Size(132, 50);
            this.buttonJouer.TabIndex = 0;
            this.buttonJouer.Text = "Jouer";
            this.buttonJouer.UseVisualStyleBackColor = true;
            this.buttonJouer.Click += new System.EventHandler(this.buttonJouer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom joueur 1 :";
            // 
            // textBoxNom1
            // 
            this.textBoxNom1.Location = new System.Drawing.Point(228, 41);
            this.textBoxNom1.Name = "textBoxNom1";
            this.textBoxNom1.Size = new System.Drawing.Size(125, 27);
            this.textBoxNom1.TabIndex = 2;
            // 
            // textBoxNom2
            // 
            this.textBoxNom2.Location = new System.Drawing.Point(228, 96);
            this.textBoxNom2.Name = "textBoxNom2";
            this.textBoxNom2.Size = new System.Drawing.Size(125, 27);
            this.textBoxNom2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom joueur 2 :";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 350);
            this.Controls.Add(this.textBoxNom2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonJouer);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonJouer;
        private Label label1;
        private TextBox textBoxNom1;
        private TextBox textBoxNom2;
        private Label label2;
    }
}