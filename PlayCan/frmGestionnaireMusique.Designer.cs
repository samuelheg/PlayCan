﻿namespace PlayCan
{
    partial class frmGestionnaireMusique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionnaireMusique));
            this.lblDeconnexion = new System.Windows.Forms.Label();
            this.lblAPropos = new System.Windows.Forms.Label();
            this.lblParametres = new System.Windows.Forms.Label();
            this.lblMusique = new System.Windows.Forms.Label();
            this.lblAbonnements = new System.Windows.Forms.Label();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlInfosMusique = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbPayes = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.dtgMusiques = new System.Windows.Forms.DataGridView();
            this.picFestival = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            this.pnlInfosMusique.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusiques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeconnexion
            // 
            this.lblDeconnexion.AutoSize = true;
            this.lblDeconnexion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeconnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDeconnexion.Location = new System.Drawing.Point(32, 229);
            this.lblDeconnexion.Name = "lblDeconnexion";
            this.lblDeconnexion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeconnexion.Size = new System.Drawing.Size(114, 23);
            this.lblDeconnexion.TabIndex = 5;
            this.lblDeconnexion.Text = "&Déconnexion";
            this.lblDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeconnexion.Click += new System.EventHandler(this.lblDeconnexion_Click);
            this.lblDeconnexion.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblDeconnexion.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblAPropos
            // 
            this.lblAPropos.AutoSize = true;
            this.lblAPropos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPropos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAPropos.Location = new System.Drawing.Point(32, 206);
            this.lblAPropos.Name = "lblAPropos";
            this.lblAPropos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAPropos.Size = new System.Drawing.Size(81, 23);
            this.lblAPropos.TabIndex = 4;
            this.lblAPropos.Text = "A &Propos";
            this.lblAPropos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAPropos.Click += new System.EventHandler(this.lblAPropos_Click);
            this.lblAPropos.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblAPropos.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblParametres
            // 
            this.lblParametres.AutoSize = true;
            this.lblParametres.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblParametres.Location = new System.Drawing.Point(32, 183);
            this.lblParametres.Name = "lblParametres";
            this.lblParametres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblParametres.Size = new System.Drawing.Size(102, 23);
            this.lblParametres.TabIndex = 3;
            this.lblParametres.Text = "Pa&ramètres";
            this.lblParametres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblParametres.Click += new System.EventHandler(this.lblParametres_Click);
            this.lblParametres.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblParametres.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblMusique
            // 
            this.lblMusique.AutoSize = true;
            this.lblMusique.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMusique.Location = new System.Drawing.Point(32, 160);
            this.lblMusique.Name = "lblMusique";
            this.lblMusique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMusique.Size = new System.Drawing.Size(88, 23);
            this.lblMusique.TabIndex = 2;
            this.lblMusique.Text = "&Musiques";
            this.lblMusique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMusique.Click += new System.EventHandler(this.lblMusique_Click);
            this.lblMusique.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblMusique.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblAbonnements
            // 
            this.lblAbonnements.AutoSize = true;
            this.lblAbonnements.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonnements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAbonnements.Location = new System.Drawing.Point(32, 137);
            this.lblAbonnements.Name = "lblAbonnements";
            this.lblAbonnements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAbonnements.Size = new System.Drawing.Size(122, 23);
            this.lblAbonnements.TabIndex = 1;
            this.lblAbonnements.Text = "A&bonnements";
            this.lblAbonnements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAbonnements.Click += new System.EventHandler(this.lblAbonnements_Click);
            this.lblAbonnements.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblAbonnements.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblAccueil
            // 
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAccueil.Location = new System.Drawing.Point(32, 114);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAccueil.Size = new System.Drawing.Size(68, 23);
            this.lblAccueil.TabIndex = 0;
            this.lblAccueil.Text = "&Accueil";
            this.lblAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAccueil.Click += new System.EventHandler(this.lblAccueil_Click);
            this.lblAccueil.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblAccueil.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(36, -11);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(129, 122);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlInfosMusique
            // 
            this.pnlInfosMusique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfosMusique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInfosMusique.Controls.Add(this.picFestival);
            this.pnlInfosMusique.Location = new System.Drawing.Point(203, -2);
            this.pnlInfosMusique.Name = "pnlInfosMusique";
            this.pnlInfosMusique.Size = new System.Drawing.Size(709, 111);
            this.pnlInfosMusique.TabIndex = 19;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.radioButton1);
            this.pnlMenu.Controls.Add(this.rbPayes);
            this.pnlMenu.Controls.Add(this.rbStandard);
            this.pnlMenu.Controls.Add(this.lblDeconnexion);
            this.pnlMenu.Controls.Add(this.lblAPropos);
            this.pnlMenu.Controls.Add(this.lblParametres);
            this.pnlMenu.Controls.Add(this.lblMusique);
            this.pnlMenu.Controls.Add(this.lblAbonnements);
            this.pnlMenu.Controls.Add(this.lblAccueil);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Location = new System.Drawing.Point(-3, -2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 554);
            this.pnlMenu.TabIndex = 20;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton1.Location = new System.Drawing.Point(36, 417);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 27);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Delu&xe";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbPayes
            // 
            this.rbPayes.AutoSize = true;
            this.rbPayes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPayes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbPayes.Location = new System.Drawing.Point(36, 384);
            this.rbPayes.Name = "rbPayes";
            this.rbPayes.Size = new System.Drawing.Size(100, 27);
            this.rbPayes.TabIndex = 7;
            this.rbPayes.TabStop = true;
            this.rbPayes.Text = "Pr&emium";
            this.rbPayes.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbStandard.Location = new System.Drawing.Point(36, 351);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(99, 27);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "&Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbImpayes_CheckedChanged);
            // 
            // dtgMusiques
            // 
            this.dtgMusiques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMusiques.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgMusiques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMusiques.Location = new System.Drawing.Point(203, 112);
            this.dtgMusiques.Name = "dtgMusiques";
            this.dtgMusiques.Size = new System.Drawing.Size(709, 404);
            this.dtgMusiques.TabIndex = 18;
            // 
            // picFestival
            // 
            this.picFestival.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFestival.Image = global::PlayCan.Properties.Resources.Sans_titre___1;
            this.picFestival.Location = new System.Drawing.Point(0, 0);
            this.picFestival.Name = "picFestival";
            this.picFestival.Size = new System.Drawing.Size(709, 108);
            this.picFestival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFestival.TabIndex = 0;
            this.picFestival.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PlayCan.Properties.Resources.playcan;
            this.picLogo.Location = new System.Drawing.Point(23, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(83, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmGestionnaireMusique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.pnlInfosMusique);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dtgMusiques);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(932, 562);
            this.Name = "frmGestionnaireMusique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musique";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestionnaireMusique_FormClosed);
            this.pnlLogo.ResumeLayout(false);
            this.pnlInfosMusique.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusiques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeconnexion;
        private System.Windows.Forms.Label lblAPropos;
        private System.Windows.Forms.Label lblParametres;
        private System.Windows.Forms.Label lblMusique;
        private System.Windows.Forms.Label lblAbonnements;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlInfosMusique;
        private System.Windows.Forms.PictureBox picFestival;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.RadioButton rbPayes;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.DataGridView dtgMusiques;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}