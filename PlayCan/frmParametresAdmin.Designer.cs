namespace PlayCan
{
    partial class frmParametresAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametresAdmin));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblDeconnexion = new System.Windows.Forms.Label();
            this.lblAPropos = new System.Windows.Forms.Label();
            this.lblParametres = new System.Windows.Forms.Label();
            this.lblMusique = new System.Windows.Forms.Label();
            this.lblAbonnements = new System.Windows.Forms.Label();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlInfosMusique = new System.Windows.Forms.Panel();
            this.picFestival = new System.Windows.Forms.PictureBox();
            this.pnlFormulaire = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblConfMdp = new System.Windows.Forms.Label();
            this.tbxConfMdp = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlInfosMusique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).BeginInit();
            this.pnlFormulaire.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlMenu.TabIndex = 83;
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
            this.lblMusique.Text = "M&usiques";
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
            // pnlInfosMusique
            // 
            this.pnlInfosMusique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfosMusique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInfosMusique.Controls.Add(this.picFestival);
            this.pnlInfosMusique.Location = new System.Drawing.Point(203, -2);
            this.pnlInfosMusique.Name = "pnlInfosMusique";
            this.pnlInfosMusique.Size = new System.Drawing.Size(709, 111);
            this.pnlInfosMusique.TabIndex = 82;
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
            // pnlFormulaire
            // 
            this.pnlFormulaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormulaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlFormulaire.Controls.Add(this.btnUpdate);
            this.pnlFormulaire.Controls.Add(this.lblId);
            this.pnlFormulaire.Controls.Add(this.lblConfMdp);
            this.pnlFormulaire.Controls.Add(this.tbxNom);
            this.pnlFormulaire.Controls.Add(this.tbxConfMdp);
            this.pnlFormulaire.Controls.Add(this.lblPrenom);
            this.pnlFormulaire.Controls.Add(this.tbxMdp);
            this.pnlFormulaire.Controls.Add(this.lblNom);
            this.pnlFormulaire.Controls.Add(this.tbxId);
            this.pnlFormulaire.Controls.Add(this.lblMdp);
            this.pnlFormulaire.Controls.Add(this.tbxPrenom);
            this.pnlFormulaire.Location = new System.Drawing.Point(204, 112);
            this.pnlFormulaire.Name = "pnlFormulaire";
            this.pnlFormulaire.Size = new System.Drawing.Size(709, 404);
            this.pnlFormulaire.TabIndex = 94;
            this.pnlFormulaire.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormulaire_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(242, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(229, 22);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Mettre à &jour informations de compte";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblConfMdp
            // 
            this.lblConfMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfMdp.AutoSize = true;
            this.lblConfMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblConfMdp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConfMdp.Location = new System.Drawing.Point(230, 244);
            this.lblConfMdp.Name = "lblConfMdp";
            this.lblConfMdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConfMdp.Size = new System.Drawing.Size(89, 18);
            this.lblConfMdp.TabIndex = 8;
            this.lblConfMdp.Text = "&Confirmation";
            this.lblConfMdp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxConfMdp
            // 
            this.tbxConfMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxConfMdp.Location = new System.Drawing.Point(326, 242);
            this.tbxConfMdp.Name = "tbxConfMdp";
            this.tbxConfMdp.Size = new System.Drawing.Size(155, 20);
            this.tbxConfMdp.TabIndex = 9;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMdp.Location = new System.Drawing.Point(326, 211);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(155, 20);
            this.tbxMdp.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblId.Location = new System.Drawing.Point(230, 182);
            this.lblId.Name = "lblId";
            this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId.Size = new System.Drawing.Size(73, 18);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "&Identifiant";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMdp
            // 
            this.lblMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMdp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMdp.Location = new System.Drawing.Point(230, 213);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMdp.Size = new System.Drawing.Size(91, 18);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "&Mot de passe";
            this.lblMdp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrenom.Location = new System.Drawing.Point(326, 149);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(155, 20);
            this.tbxPrenom.TabIndex = 3;
            // 
            // tbxId
            // 
            this.tbxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxId.Location = new System.Drawing.Point(326, 180);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(155, 20);
            this.tbxId.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNom.Location = new System.Drawing.Point(230, 120);
            this.lblNom.Name = "lblNom";
            this.lblNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNom.Size = new System.Drawing.Size(38, 18);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPrenom.Location = new System.Drawing.Point(230, 151);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrenom.Size = new System.Drawing.Size(57, 18);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prénom";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNom.Location = new System.Drawing.Point(326, 118);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(155, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // frmParametresAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInfosMusique);
            this.Controls.Add(this.pnlFormulaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(932, 562);
            this.Name = "frmParametresAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmParametresAdmin_FormClosed);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlInfosMusique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFestival)).EndInit();
            this.pnlFormulaire.ResumeLayout(false);
            this.pnlFormulaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlInfosMusique;
        private System.Windows.Forms.PictureBox picFestival;
        private System.Windows.Forms.Panel pnlFormulaire;
        private System.Windows.Forms.Label lblDeconnexion;
        private System.Windows.Forms.Label lblAPropos;
        private System.Windows.Forms.Label lblParametres;
        private System.Windows.Forms.Label lblMusique;
        private System.Windows.Forms.Label lblAbonnements;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblConfMdp;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxConfMdp;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox tbxPrenom;
    }
}