namespace OccasAuto
{
    partial class OccasAuto
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
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewConcess = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBoxVille = new System.Windows.Forms.ComboBox();
            this.cmbBoxNom = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.gpAddModifConcess = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblGpAddModif = new System.Windows.Forms.Label();
            this.BtnFermerGPADD = new System.Windows.Forms.Label();
            this.BtnCancelGPADD = new System.Windows.Forms.Button();
            this.BtnOKGPADD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVille_GPADD = new System.Windows.Forms.TextBox();
            this.txtCP_GPADD = new System.Windows.Forms.TextBox();
            this.txtRue_GPADD = new System.Windows.Forms.TextBox();
            this.txtPrenom_GPADD = new System.Windows.Forms.TextBox();
            this.txtNom_GPADD = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnPseudo = new System.Windows.Forms.Button();
            this.panelVoid0 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnModif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpAddModifConcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecherche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRecherche.Location = new System.Drawing.Point(909, 116);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(205, 75);
            this.btnRecherche.TabIndex = 1;
            this.btnRecherche.Text = "RECHERCHER ➔";
            this.btnRecherche.UseVisualStyleBackColor = false;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ville :";
            // 
            // listViewConcess
            // 
            this.listViewConcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.CP,
            this.Ville});
            this.listViewConcess.FullRowSelect = true;
            this.listViewConcess.GridLines = true;
            this.listViewConcess.HideSelection = false;
            this.listViewConcess.Location = new System.Drawing.Point(12, 206);
            this.listViewConcess.Name = "listViewConcess";
            this.listViewConcess.Size = new System.Drawing.Size(1102, 500);
            this.listViewConcess.TabIndex = 5;
            this.listViewConcess.UseCompatibleStateImageBehavior = false;
            this.listViewConcess.View = System.Windows.Forms.View.Details;
            this.listViewConcess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OccasAuto_Click);
            this.listViewConcess.Click += new System.EventHandler(this.OccasAuto_Click);
            this.listViewConcess.DoubleClick += new System.EventHandler(this.BtnModif_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenom.Width = 112;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adresse.Width = 250;
            // 
            // CP
            // 
            this.CP.Text = "Code Postal";
            this.CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CP.Width = 100;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ville.Width = 150;
            // 
            // cmbBoxVille
            // 
            this.cmbBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxVille.Location = new System.Drawing.Point(682, 167);
            this.cmbBoxVille.Name = "cmbBoxVille";
            this.cmbBoxVille.Size = new System.Drawing.Size(214, 24);
            this.cmbBoxVille.TabIndex = 6;
            this.cmbBoxVille.Click += new System.EventHandler(this.OccasAuto_Click);
            // 
            // cmbBoxNom
            // 
            this.cmbBoxNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNom.Location = new System.Drawing.Point(682, 116);
            this.cmbBoxNom.Name = "cmbBoxNom";
            this.cmbBoxNom.Size = new System.Drawing.Size(214, 24);
            this.cmbBoxNom.TabIndex = 7;
            this.cmbBoxNom.Click += new System.EventHandler(this.OccasAuto_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFermer.Location = new System.Drawing.Point(3, 655);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(200, 45);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "QUITTER";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.Location = new System.Drawing.Point(3, 610);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(200, 45);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "REDUIRE";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // gpAddModifConcess
            // 
            this.gpAddModifConcess.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gpAddModifConcess.Controls.Add(this.pictureBox2);
            this.gpAddModifConcess.Controls.Add(this.lblErr);
            this.gpAddModifConcess.Controls.Add(this.lblGpAddModif);
            this.gpAddModifConcess.Controls.Add(this.BtnFermerGPADD);
            this.gpAddModifConcess.Controls.Add(this.BtnCancelGPADD);
            this.gpAddModifConcess.Controls.Add(this.BtnOKGPADD);
            this.gpAddModifConcess.Controls.Add(this.label9);
            this.gpAddModifConcess.Controls.Add(this.label8);
            this.gpAddModifConcess.Controls.Add(this.label6);
            this.gpAddModifConcess.Controls.Add(this.label5);
            this.gpAddModifConcess.Controls.Add(this.label4);
            this.gpAddModifConcess.Controls.Add(this.txtVille_GPADD);
            this.gpAddModifConcess.Controls.Add(this.txtCP_GPADD);
            this.gpAddModifConcess.Controls.Add(this.txtRue_GPADD);
            this.gpAddModifConcess.Controls.Add(this.txtPrenom_GPADD);
            this.gpAddModifConcess.Controls.Add(this.txtNom_GPADD);
            this.gpAddModifConcess.Location = new System.Drawing.Point(354, 119);
            this.gpAddModifConcess.Name = "gpAddModifConcess";
            this.gpAddModifConcess.Size = new System.Drawing.Size(518, 537);
            this.gpAddModifConcess.TabIndex = 13;
            this.gpAddModifConcess.TabStop = false;
            this.gpAddModifConcess.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OccasAuto.Properties.Resources.clefs;
            this.pictureBox2.Location = new System.Drawing.Point(16, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(123, 174);
            this.lblErr.MaximumSize = new System.Drawing.Size(300, 50);
            this.lblErr.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(300, 50);
            this.lblErr.TabIndex = 17;
            this.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGpAddModif
            // 
            this.lblGpAddModif.AutoSize = true;
            this.lblGpAddModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpAddModif.ForeColor = System.Drawing.Color.Wheat;
            this.lblGpAddModif.Location = new System.Drawing.Point(93, 73);
            this.lblGpAddModif.MaximumSize = new System.Drawing.Size(350, 80);
            this.lblGpAddModif.MinimumSize = new System.Drawing.Size(350, 80);
            this.lblGpAddModif.Name = "lblGpAddModif";
            this.lblGpAddModif.Size = new System.Drawing.Size(350, 80);
            this.lblGpAddModif.TabIndex = 16;
            this.lblGpAddModif.Text = "AJOUTEZ UN NOUVEAU\r\nCONCESSIONNAIRE";
            this.lblGpAddModif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFermerGPADD
            // 
            this.BtnFermerGPADD.AutoSize = true;
            this.BtnFermerGPADD.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermerGPADD.Location = new System.Drawing.Point(470, 18);
            this.BtnFermerGPADD.Name = "BtnFermerGPADD";
            this.BtnFermerGPADD.Size = new System.Drawing.Size(42, 45);
            this.BtnFermerGPADD.TabIndex = 14;
            this.BtnFermerGPADD.Text = "X";
            this.BtnFermerGPADD.Click += new System.EventHandler(this.BtnFermerGPADD_Click);
            // 
            // BtnCancelGPADD
            // 
            this.BtnCancelGPADD.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelGPADD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancelGPADD.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelGPADD.Location = new System.Drawing.Point(188, 429);
            this.BtnCancelGPADD.Name = "BtnCancelGPADD";
            this.BtnCancelGPADD.Size = new System.Drawing.Size(130, 43);
            this.BtnCancelGPADD.TabIndex = 15;
            this.BtnCancelGPADD.Text = "ANNULER";
            this.BtnCancelGPADD.UseVisualStyleBackColor = false;
            this.BtnCancelGPADD.Click += new System.EventHandler(this.BtnCancelGPADD_Click);
            // 
            // BtnOKGPADD
            // 
            this.BtnOKGPADD.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOKGPADD.FlatAppearance.BorderSize = 0;
            this.BtnOKGPADD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnOKGPADD.ForeColor = System.Drawing.Color.Black;
            this.BtnOKGPADD.Location = new System.Drawing.Point(341, 429);
            this.BtnOKGPADD.Name = "BtnOKGPADD";
            this.BtnOKGPADD.Size = new System.Drawing.Size(130, 43);
            this.BtnOKGPADD.TabIndex = 14;
            this.BtnOKGPADD.Text = "VALIDER";
            this.BtnOKGPADD.UseVisualStyleBackColor = false;
            this.BtnOKGPADD.Click += new System.EventHandler(this.BtnOKGPADD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Wheat;
            this.label9.Location = new System.Drawing.Point(238, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Wheat;
            this.label8.Location = new System.Drawing.Point(43, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Wheat;
            this.label6.Location = new System.Drawing.Point(32, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(251, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(26, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOM";
            // 
            // txtVille_GPADD
            // 
            this.txtVille_GPADD.Location = new System.Drawing.Point(290, 358);
            this.txtVille_GPADD.Name = "txtVille_GPADD";
            this.txtVille_GPADD.Size = new System.Drawing.Size(181, 22);
            this.txtVille_GPADD.TabIndex = 5;
            // 
            // txtCP_GPADD
            // 
            this.txtCP_GPADD.Location = new System.Drawing.Point(89, 359);
            this.txtCP_GPADD.Name = "txtCP_GPADD";
            this.txtCP_GPADD.Size = new System.Drawing.Size(100, 22);
            this.txtCP_GPADD.TabIndex = 4;
            // 
            // txtRue_GPADD
            // 
            this.txtRue_GPADD.Location = new System.Drawing.Point(89, 305);
            this.txtRue_GPADD.Name = "txtRue_GPADD";
            this.txtRue_GPADD.Size = new System.Drawing.Size(382, 22);
            this.txtRue_GPADD.TabIndex = 3;
            // 
            // txtPrenom_GPADD
            // 
            this.txtPrenom_GPADD.Location = new System.Drawing.Point(324, 250);
            this.txtPrenom_GPADD.Name = "txtPrenom_GPADD";
            this.txtPrenom_GPADD.Size = new System.Drawing.Size(147, 22);
            this.txtPrenom_GPADD.TabIndex = 1;
            // 
            // txtNom_GPADD
            // 
            this.txtNom_GPADD.Location = new System.Drawing.Point(89, 251);
            this.txtNom_GPADD.Name = "txtNom_GPADD";
            this.txtNom_GPADD.Size = new System.Drawing.Size(140, 22);
            this.txtNom_GPADD.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panelVoid0);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnFermer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1137, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 729);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnPseudo);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 68);
            this.panel5.TabIndex = 15;
            // 
            // BtnPseudo
            // 
            this.BtnPseudo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPseudo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPseudo.ForeColor = System.Drawing.Color.Wheat;
            this.BtnPseudo.Image = global::OccasAuto.Properties.Resources.avatar;
            this.BtnPseudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPseudo.Location = new System.Drawing.Point(-12, -9);
            this.BtnPseudo.Name = "BtnPseudo";
            this.BtnPseudo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnPseudo.Size = new System.Drawing.Size(236, 85);
            this.BtnPseudo.TabIndex = 11;
            this.BtnPseudo.Text = "            PSEUDO";
            this.BtnPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPseudo.UseVisualStyleBackColor = false;
            // 
            // panelVoid0
            // 
            this.panelVoid0.Location = new System.Drawing.Point(3, 77);
            this.panelVoid0.Name = "panelVoid0";
            this.panelVoid0.Size = new System.Drawing.Size(215, 79);
            this.panelVoid0.TabIndex = 0;
            this.panelVoid0.Click += new System.EventHandler(this.OccasAuto_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Location = new System.Drawing.Point(3, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 68);
            this.panel3.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Wheat;
            this.BtnAdd.Image = global::OccasAuto.Properties.Resources.croix1;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(-12, -8);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAdd.Size = new System.Drawing.Size(236, 85);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "            AJOUTER";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnModif);
            this.panel2.Location = new System.Drawing.Point(3, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 68);
            this.panel2.TabIndex = 2;
            // 
            // BtnModif
            // 
            this.BtnModif.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnModif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModif.ForeColor = System.Drawing.Color.Wheat;
            this.BtnModif.Image = global::OccasAuto.Properties.Resources.modifier;
            this.BtnModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModif.Location = new System.Drawing.Point(-11, -7);
            this.BtnModif.Name = "BtnModif";
            this.BtnModif.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnModif.Size = new System.Drawing.Size(236, 85);
            this.BtnModif.TabIndex = 11;
            this.BtnModif.Text = "            MODIFIER";
            this.BtnModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModif.UseVisualStyleBackColor = false;
            this.BtnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Location = new System.Drawing.Point(3, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 68);
            this.panel1.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Wheat;
            this.BtnDelete.Image = global::OccasAuto.Properties.Resources.poubelle1;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(-11, -9);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnDelete.Size = new System.Drawing.Size(236, 85);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "            SUPPRIMER";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 223);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.OccasAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "OCCAS AUTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OccasAuto.Properties.Resources.voitureLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // OccasAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 718);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gpAddModifConcess);
            this.Controls.Add(this.cmbBoxNom);
            this.Controls.Add(this.cmbBoxVille);
            this.Controls.Add(this.listViewConcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1357, 736);
            this.MinimumSize = new System.Drawing.Size(1357, 736);
            this.Name = "OccasAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.OccasAuto_Click);
            this.gpAddModifConcess.ResumeLayout(false);
            this.gpAddModifConcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewConcess;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader CP;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ComboBox cmbBoxVille;
        private System.Windows.Forms.ComboBox cmbBoxNom;
        private System.Windows.Forms.Label btnFermer;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox gpAddModifConcess;
        private System.Windows.Forms.Label BtnFermerGPADD;
        private System.Windows.Forms.Button BtnCancelGPADD;
        private System.Windows.Forms.Button BtnOKGPADD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVille_GPADD;
        private System.Windows.Forms.TextBox txtCP_GPADD;
        private System.Windows.Forms.TextBox txtRue_GPADD;
        private System.Windows.Forms.TextBox txtPrenom_GPADD;
        private System.Windows.Forms.TextBox txtNom_GPADD;
        private System.Windows.Forms.Label lblGpAddModif;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelVoid0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button BtnModif;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnPseudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

