namespace PlayCan
{
    partial class frmAccueilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueilAdmin));
            this.dtgStats = new System.Windows.Forms.DataGridView();
            this.pnlInfosMusique = new System.Windows.Forms.Panel();
            this.picFestival = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblDeconnexion = new System.Windows.Forms.Label();
            this.lblAPropos = new System.Windows.Forms.Label();
            this.lblParametres = new System.Windows.Forms.Label();
            this.lblMusique = new System.Windows.Forms.Label();
            this.lblAbonnements = new System.Windows.Forms.Label();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblImpayes = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblDeluxe = new System.Windows.Forms.Label();
            this.lblMusiques = new System.Windows.Forms.Label();
            this.lblTotalImpayes = new System.Windows.Forms.Label();
            this.lblTotalStandard = new System.Windows.Forms.Label();
            this.lblTotalPremium = new System.Windows.Forms.Label();
            this.lblTotalDeluxe = new System.Windows.Forms.Label();
            this.lblTotalMusiques = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStats)).BeginInit();
            this.pnlInfosMusique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStats
            // 
            this.dtgStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStats.Location = new System.Drawing.Point(203, 112);
            this.dtgStats.Name = "dtgStats";
            this.dtgStats.Size = new System.Drawing.Size(709, 404);
            this.dtgStats.TabIndex = 6;
            this.dtgStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusiques_CellContentClick);
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
            this.pnlInfosMusique.TabIndex = 4;
            this.pnlInfosMusique.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfosMusique_Paint);
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
            this.pnlMenu.Controls.Add(this.lblMusique);
            this.pnlMenu.Controls.Add(this.lblAbonnements);
            this.pnlMenu.Controls.Add(this.lblAccueil);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Location = new System.Drawing.Point(-3, -2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 554);
            this.pnlMenu.TabIndex = 5;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
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
            // lblImpayes
            // 
            this.lblImpayes.AutoSize = true;
            this.lblImpayes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblImpayes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpayes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblImpayes.Location = new System.Drawing.Point(239, 158);
            this.lblImpayes.Name = "lblImpayes";
            this.lblImpayes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImpayes.Size = new System.Drawing.Size(85, 23);
            this.lblImpayes.TabIndex = 0;
            this.lblImpayes.Text = "Impayés :";
            this.lblImpayes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImpayes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStandard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStandard.Location = new System.Drawing.Point(239, 204);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStandard.Size = new System.Drawing.Size(90, 23);
            this.lblStandard.TabIndex = 2;
            this.lblStandard.Text = "Standard :";
            this.lblStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPremium.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPremium.Location = new System.Drawing.Point(239, 250);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPremium.Size = new System.Drawing.Size(91, 23);
            this.lblPremium.TabIndex = 4;
            this.lblPremium.Text = "Premium :";
            this.lblPremium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeluxe
            // 
            this.lblDeluxe.AutoSize = true;
            this.lblDeluxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDeluxe.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeluxe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDeluxe.Location = new System.Drawing.Point(239, 296);
            this.lblDeluxe.Name = "lblDeluxe";
            this.lblDeluxe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeluxe.Size = new System.Drawing.Size(75, 23);
            this.lblDeluxe.TabIndex = 6;
            this.lblDeluxe.Text = "Deluxe :";
            this.lblDeluxe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMusiques
            // 
            this.lblMusiques.AutoSize = true;
            this.lblMusiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMusiques.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMusiques.Location = new System.Drawing.Point(239, 403);
            this.lblMusiques.Name = "lblMusiques";
            this.lblMusiques.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMusiques.Size = new System.Drawing.Size(137, 23);
            this.lblMusiques.TabIndex = 8;
            this.lblMusiques.Text = "Total musiques :";
            this.lblMusiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalImpayes
            // 
            this.lblTotalImpayes.AutoSize = true;
            this.lblTotalImpayes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalImpayes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImpayes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalImpayes.Location = new System.Drawing.Point(443, 158);
            this.lblTotalImpayes.Name = "lblTotalImpayes";
            this.lblTotalImpayes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalImpayes.Size = new System.Drawing.Size(19, 23);
            this.lblTotalImpayes.TabIndex = 1;
            this.lblTotalImpayes.Text = "?";
            this.lblTotalImpayes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalStandard
            // 
            this.lblTotalStandard.AutoSize = true;
            this.lblTotalStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalStandard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalStandard.Location = new System.Drawing.Point(443, 204);
            this.lblTotalStandard.Name = "lblTotalStandard";
            this.lblTotalStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalStandard.Size = new System.Drawing.Size(19, 23);
            this.lblTotalStandard.TabIndex = 3;
            this.lblTotalStandard.Text = "?";
            this.lblTotalStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPremium
            // 
            this.lblTotalPremium.AutoSize = true;
            this.lblTotalPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalPremium.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalPremium.Location = new System.Drawing.Point(443, 250);
            this.lblTotalPremium.Name = "lblTotalPremium";
            this.lblTotalPremium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPremium.Size = new System.Drawing.Size(19, 23);
            this.lblTotalPremium.TabIndex = 5;
            this.lblTotalPremium.Text = "?";
            this.lblTotalPremium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalDeluxe
            // 
            this.lblTotalDeluxe.AutoSize = true;
            this.lblTotalDeluxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalDeluxe.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeluxe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalDeluxe.Location = new System.Drawing.Point(443, 296);
            this.lblTotalDeluxe.Name = "lblTotalDeluxe";
            this.lblTotalDeluxe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalDeluxe.Size = new System.Drawing.Size(19, 23);
            this.lblTotalDeluxe.TabIndex = 7;
            this.lblTotalDeluxe.Text = "?";
            this.lblTotalDeluxe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalMusiques
            // 
            this.lblTotalMusiques.AutoSize = true;
            this.lblTotalMusiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalMusiques.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMusiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalMusiques.Location = new System.Drawing.Point(443, 403);
            this.lblTotalMusiques.Name = "lblTotalMusiques";
            this.lblTotalMusiques.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalMusiques.Size = new System.Drawing.Size(19, 23);
            this.lblTotalMusiques.TabIndex = 9;
            this.lblTotalMusiques.Text = "?";
            this.lblTotalMusiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.lblTotalMusiques);
            this.Controls.Add(this.lblTotalDeluxe);
            this.Controls.Add(this.lblTotalPremium);
            this.Controls.Add(this.lblTotalStandard);
            this.Controls.Add(this.lblTotalImpayes);
            this.Controls.Add(this.lblMusiques);
            this.Controls.Add(this.lblDeluxe);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblImpayes);
            this.Controls.Add(this.dtgStats);
            this.Controls.Add(this.pnlInfosMusique);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(932, 562);
            this.Name = "frmAccueilAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccueilAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAccueilAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStats)).EndInit();
            this.pnlInfosMusique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStats;
        private System.Windows.Forms.Panel pnlInfosMusique;
        private System.Windows.Forms.PictureBox picFestival;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblDeconnexion;
        private System.Windows.Forms.Label lblParametres;
        private System.Windows.Forms.Label lblMusique;
        private System.Windows.Forms.Label lblAbonnements;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAPropos;
        private System.Windows.Forms.Label lblImpayes;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblDeluxe;
        private System.Windows.Forms.Label lblMusiques;
        private System.Windows.Forms.Label lblTotalImpayes;
        private System.Windows.Forms.Label lblTotalStandard;
        private System.Windows.Forms.Label lblTotalPremium;
        private System.Windows.Forms.Label lblTotalDeluxe;
        private System.Windows.Forms.Label lblTotalMusiques;
    }
}