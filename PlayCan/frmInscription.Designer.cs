namespace PlayCan
{
    partial class frmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscription));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnInscription = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblInscription = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblConfMdp = new System.Windows.Forms.Label();
            this.tbxConfMdp = new System.Windows.Forms.TextBox();
            this.lblAbo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNomFactu = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tbxAdresseFactu = new System.Windows.Forms.TextBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbDeluxe = new System.Windows.Forms.RadioButton();
            this.lblInfosAbo = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(97, -5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(129, 128);
            this.pnlLogo.TabIndex = 9;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::PlayCan.Properties.Resources.playcan;
            this.picLogo.Location = new System.Drawing.Point(23, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(83, 96);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnInscription
            // 
            this.btnInscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInscription.Location = new System.Drawing.Point(106, 457);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(102, 22);
            this.btnInscription.TabIndex = 18;
            this.btnInscription.Text = "s\'inscrir&e";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblId.Location = new System.Drawing.Point(9, 240);
            this.lblId.Name = "lblId";
            this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId.Size = new System.Drawing.Size(73, 18);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "&Identifiant";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxId
            // 
            this.tbxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxId.Location = new System.Drawing.Point(120, 238);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(156, 20);
            this.tbxId.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNom.Location = new System.Drawing.Point(9, 178);
            this.lblNom.Name = "lblNom";
            this.lblNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNom.Size = new System.Drawing.Size(38, 18);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNom.Location = new System.Drawing.Point(120, 176);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(156, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // lblInscription
            // 
            this.lblInscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInscription.AutoSize = true;
            this.lblInscription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInscription.Location = new System.Drawing.Point(114, 138);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInscription.Size = new System.Drawing.Size(94, 23);
            this.lblInscription.TabIndex = 10;
            this.lblInscription.Text = "Inscription";
            this.lblInscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPrenom.Location = new System.Drawing.Point(9, 209);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrenom.Size = new System.Drawing.Size(57, 18);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prénom";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrenom.Location = new System.Drawing.Point(120, 207);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(156, 20);
            this.tbxPrenom.TabIndex = 3;
            // 
            // lblMdp
            // 
            this.lblMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMdp.Location = new System.Drawing.Point(9, 271);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMdp.Size = new System.Drawing.Size(91, 18);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "&Mot de passe";
            this.lblMdp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMdp.Location = new System.Drawing.Point(120, 269);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(156, 20);
            this.tbxMdp.TabIndex = 7;
            // 
            // lblConfMdp
            // 
            this.lblConfMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfMdp.AutoSize = true;
            this.lblConfMdp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConfMdp.Location = new System.Drawing.Point(9, 302);
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
            this.tbxConfMdp.Location = new System.Drawing.Point(120, 300);
            this.tbxConfMdp.Name = "tbxConfMdp";
            this.tbxConfMdp.Size = new System.Drawing.Size(156, 20);
            this.tbxConfMdp.TabIndex = 9;
            // 
            // lblAbo
            // 
            this.lblAbo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbo.AutoSize = true;
            this.lblAbo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAbo.Location = new System.Drawing.Point(8, 340);
            this.lblAbo.Name = "lblAbo";
            this.lblAbo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAbo.Size = new System.Drawing.Size(114, 23);
            this.lblAbo.TabIndex = 22;
            this.lblAbo.Text = "Abonnement";
            this.lblAbo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(9, 395);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nom &facturation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNomFactu
            // 
            this.tbxNomFactu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNomFactu.Location = new System.Drawing.Point(118, 395);
            this.tbxNomFactu.Name = "tbxNomFactu";
            this.tbxNomFactu.Size = new System.Drawing.Size(158, 20);
            this.tbxNomFactu.TabIndex = 14;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAdresse.Location = new System.Drawing.Point(9, 368);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAdresse.Size = new System.Drawing.Size(58, 18);
            this.lblAdresse.TabIndex = 11;
            this.lblAdresse.Text = "&Adresse";
            this.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAdresseFactu
            // 
            this.tbxAdresseFactu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdresseFactu.Location = new System.Drawing.Point(118, 366);
            this.tbxAdresseFactu.Name = "tbxAdresseFactu";
            this.tbxAdresseFactu.Size = new System.Drawing.Size(158, 20);
            this.tbxAdresseFactu.TabIndex = 12;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbStandard.Location = new System.Drawing.Point(45, 421);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(76, 17);
            this.rbStandard.TabIndex = 15;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "&Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbPremium.Location = new System.Drawing.Point(134, 421);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(72, 17);
            this.rbPremium.TabIndex = 16;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "P&remium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbDeluxe
            // 
            this.rbDeluxe.AutoSize = true;
            this.rbDeluxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeluxe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbDeluxe.Location = new System.Drawing.Point(220, 421);
            this.rbDeluxe.Name = "rbDeluxe";
            this.rbDeluxe.Size = new System.Drawing.Size(64, 17);
            this.rbDeluxe.TabIndex = 17;
            this.rbDeluxe.TabStop = true;
            this.rbDeluxe.Text = "&Deluxe";
            this.rbDeluxe.UseVisualStyleBackColor = true;
            // 
            // lblInfosAbo
            // 
            this.lblInfosAbo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfosAbo.AutoSize = true;
            this.lblInfosAbo.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInfosAbo.Location = new System.Drawing.Point(128, 346);
            this.lblInfosAbo.Name = "lblInfosAbo";
            this.lblInfosAbo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfosAbo.Size = new System.Drawing.Size(156, 15);
            this.lblInfosAbo.TabIndex = 10;
            this.lblInfosAbo.Text = "informations a&bonnements";
            this.lblInfosAbo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(322, 491);
            this.Controls.Add(this.lblInfosAbo);
            this.Controls.Add(this.rbDeluxe);
            this.Controls.Add(this.rbPremium);
            this.Controls.Add(this.rbStandard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNomFactu);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.tbxAdresseFactu);
            this.Controls.Add(this.lblAbo);
            this.Controls.Add(this.lblConfMdp);
            this.Controls.Add(this.tbxConfMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInscription_FormClosed);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblConfMdp;
        private System.Windows.Forms.TextBox tbxConfMdp;
        private System.Windows.Forms.Label lblAbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNomFactu;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox tbxAdresseFactu;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbDeluxe;
        private System.Windows.Forms.Label lblInfosAbo;
    }
}