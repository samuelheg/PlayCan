namespace PlayCan
{
    partial class frmAccueilUtilisateur
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueilUtilisateur));
            this.pnlInfosMusique = new System.Windows.Forms.Panel();
            this.picFestival = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblDeconnexion = new System.Windows.Forms.Label();
            this.lblAPropos = new System.Windows.Forms.Label();
            this.lblParametres = new System.Windows.Forms.Label();
            this.lblFavoris = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.lblSuivant = new System.Windows.Forms.Label();
            this.lblPrecedent = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.dtgInfosMusiques = new System.Windows.Forms.DataGridView();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dtgMusiques = new System.Windows.Forms.DataGridView();
            this.pnlInfosMusique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosMusiques)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusiques)).BeginInit();
            this.SuspendLayout();
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
            this.pnlInfosMusique.TabIndex = 1;
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
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.lblDeconnexion);
            this.pnlMenu.Controls.Add(this.lblAPropos);
            this.pnlMenu.Controls.Add(this.lblParametres);
            this.pnlMenu.Controls.Add(this.lblFavoris);
            this.pnlMenu.Controls.Add(this.lblPlaylist);
            this.pnlMenu.Controls.Add(this.lblAccueil);
            this.pnlMenu.Controls.Add(this.lblSuivant);
            this.pnlMenu.Controls.Add(this.lblPrecedent);
            this.pnlMenu.Controls.Add(this.lblPlay);
            this.pnlMenu.Controls.Add(this.dtgInfosMusiques);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Location = new System.Drawing.Point(-3, -2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 554);
            this.pnlMenu.TabIndex = 2;
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
            this.lblAPropos.Text = "A Pr&opos";
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
            // lblFavoris
            // 
            this.lblFavoris.AutoSize = true;
            this.lblFavoris.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFavoris.Location = new System.Drawing.Point(32, 160);
            this.lblFavoris.Name = "lblFavoris";
            this.lblFavoris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFavoris.Size = new System.Drawing.Size(66, 23);
            this.lblFavoris.TabIndex = 2;
            this.lblFavoris.Text = "&Favoris";
            this.lblFavoris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFavoris.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblFavoris.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlaylist.Location = new System.Drawing.Point(32, 137);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaylist.Size = new System.Drawing.Size(68, 23);
            this.lblPlaylist.TabIndex = 1;
            this.lblPlaylist.Text = "&Playlist";
            this.lblPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlaylist.Click += new System.EventHandler(this.lblPlaylist_Click);
            this.lblPlaylist.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblPlaylist.MouseHover += new System.EventHandler(this.lbl_MouseHover);
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
            this.lblAccueil.Click += new System.EventHandler(this.lblAccueil_Click_1);
            this.lblAccueil.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblAccueil.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblSuivant
            // 
            this.lblSuivant.AutoSize = true;
            this.lblSuivant.Font = new System.Drawing.Font("Webdings", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSuivant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSuivant.Location = new System.Drawing.Point(136, 413);
            this.lblSuivant.Name = "lblSuivant";
            this.lblSuivant.Size = new System.Drawing.Size(43, 30);
            this.lblSuivant.TabIndex = 8;
            this.lblSuivant.Text = "&8";
            this.lblSuivant.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblSuivant.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblPrecedent
            // 
            this.lblPrecedent.AutoSize = true;
            this.lblPrecedent.Font = new System.Drawing.Font("Webdings", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPrecedent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPrecedent.Location = new System.Drawing.Point(22, 413);
            this.lblPrecedent.Name = "lblPrecedent";
            this.lblPrecedent.Size = new System.Drawing.Size(43, 30);
            this.lblPrecedent.TabIndex = 7;
            this.lblPrecedent.Text = "&7";
            this.lblPrecedent.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblPrecedent.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlay.Location = new System.Drawing.Point(65, 398);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(71, 49);
            this.lblPlay.TabIndex = 6;
            this.lblPlay.Text = "&4";
            this.lblPlay.Click += new System.EventHandler(this.label5_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblPlay.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // dtgInfosMusiques
            // 
            this.dtgInfosMusiques.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgInfosMusiques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfosMusiques.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgInfosMusiques.Location = new System.Drawing.Point(36, 283);
            this.dtgInfosMusiques.Name = "dtgInfosMusiques";
            this.dtgInfosMusiques.Size = new System.Drawing.Size(129, 111);
            this.dtgInfosMusiques.TabIndex = 7;
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
            this.dtgMusiques.TabIndex = 3;
            this.dtgMusiques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusiques_CellContentClick);
            // 
            // frmAccueilUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.dtgMusiques);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInfosMusique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(932, 562);
            this.Name = "frmAccueilUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlInfosMusique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosMusiques)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusiques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfosMusique;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.DataGridView dtgMusiques;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.DataGridView dtgInfosMusiques;
        private System.Windows.Forms.PictureBox picFestival;
        private System.Windows.Forms.Label lblSuivant;
        private System.Windows.Forms.Label lblPrecedent;
        private System.Windows.Forms.Label lblDeconnexion;
        private System.Windows.Forms.Label lblAPropos;
        private System.Windows.Forms.Label lblParametres;
        private System.Windows.Forms.Label lblFavoris;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblAccueil;
    }
}

