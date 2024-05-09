namespace OccasAuto
{
    partial class Connexion
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
            this.btnFermer = new System.Windows.Forms.Label();
            this.lblCnxInscr = new System.Windows.Forms.Label();
            this.txtMDP2 = new System.Windows.Forms.TextBox();
            this.lblMDP2 = new System.Windows.Forms.Label();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSeePSW = new System.Windows.Forms.PictureBox();
            this.btnParam = new System.Windows.Forms.Label();
            this.gpParamBDD = new System.Windows.Forms.GroupBox();
            this.btnAnnulerBDD = new System.Windows.Forms.Button();
            this.btnValidBDD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseParamBDD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPSW = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeePSW)).BeginInit();
            this.gpParamBDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.AutoSize = true;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(321, 7);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(35, 37);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "X";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // lblCnxInscr
            // 
            this.lblCnxInscr.AutoSize = true;
            this.lblCnxInscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnxInscr.ForeColor = System.Drawing.Color.Wheat;
            this.lblCnxInscr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCnxInscr.Location = new System.Drawing.Point(30, 429);
            this.lblCnxInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCnxInscr.Name = "lblCnxInscr";
            this.lblCnxInscr.Size = new System.Drawing.Size(186, 13);
            this.lblCnxInscr.TabIndex = 13;
            this.lblCnxInscr.Text = "Nouvel utilisateur ? Créez un compte !";
            this.lblCnxInscr.Click += new System.EventHandler(this.lblCnxInscr_Click);
            // 
            // txtMDP2
            // 
            this.txtMDP2.Location = new System.Drawing.Point(122, 315);
            this.txtMDP2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMDP2.Name = "txtMDP2";
            this.txtMDP2.Size = new System.Drawing.Size(188, 20);
            this.txtMDP2.TabIndex = 14;
            this.txtMDP2.Visible = false;
            this.txtMDP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMDP2_KeyDown);
            // 
            // lblMDP2
            // 
            this.lblMDP2.AutoSize = true;
            this.lblMDP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP2.ForeColor = System.Drawing.Color.Wheat;
            this.lblMDP2.Location = new System.Drawing.Point(16, 313);
            this.lblMDP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMDP2.Name = "lblMDP2";
            this.lblMDP2.Size = new System.Drawing.Size(99, 20);
            this.lblMDP2.TabIndex = 12;
            this.lblMDP2.Text = "Confirmation";
            this.lblMDP2.Visible = false;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(122, 271);
            this.txtMDP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(188, 20);
            this.txtMDP.TabIndex = 11;
            this.txtMDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMDP_KeyDown);
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(122, 228);
            this.txtIdent.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(188, 20);
            this.txtIdent.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(10, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mot de Passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(30, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Identifiant";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(217, 376);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(92, 24);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(79, 161);
            this.lblErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErr.MaximumSize = new System.Drawing.Size(212, 41);
            this.lblErr.MinimumSize = new System.Drawing.Size(212, 13);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(212, 30);
            this.lblErr.TabIndex = 15;
            this.lblErr.Text = "Veuillez vérifiez vos informations de connexion\r\n";
            this.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(106, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 45);
            this.label2.TabIndex = 19;
            this.label2.Text = "BIENVENUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OccasAuto.Properties.Resources.clefs;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSeePSW
            // 
            this.BtnSeePSW.Image = global::OccasAuto.Properties.Resources.eyePSW;
            this.BtnSeePSW.Location = new System.Drawing.Point(322, 271);
            this.BtnSeePSW.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSeePSW.Name = "BtnSeePSW";
            this.BtnSeePSW.Size = new System.Drawing.Size(18, 17);
            this.BtnSeePSW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSeePSW.TabIndex = 16;
            this.BtnSeePSW.TabStop = false;
            this.BtnSeePSW.Click += new System.EventHandler(this.BtnSeePSW_Click);
            // 
            // btnParam
            // 
            this.btnParam.AutoSize = true;
            this.btnParam.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParam.Location = new System.Drawing.Point(262, 9);
            this.btnParam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(55, 37);
            this.btnParam.TabIndex = 20;
            this.btnParam.Text = "⚙";
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // gpParamBDD
            // 
            this.gpParamBDD.Controls.Add(this.btnAnnulerBDD);
            this.gpParamBDD.Controls.Add(this.btnValidBDD);
            this.gpParamBDD.Controls.Add(this.label9);
            this.gpParamBDD.Controls.Add(this.label8);
            this.gpParamBDD.Controls.Add(this.label7);
            this.gpParamBDD.Controls.Add(this.label6);
            this.gpParamBDD.Controls.Add(this.btnCloseParamBDD);
            this.gpParamBDD.Controls.Add(this.label1);
            this.gpParamBDD.Controls.Add(this.txtServeur);
            this.gpParamBDD.Controls.Add(this.txtUser);
            this.gpParamBDD.Controls.Add(this.txtDatabase);
            this.gpParamBDD.Controls.Add(this.txtPSW);
            this.gpParamBDD.Location = new System.Drawing.Point(9, 7);
            this.gpParamBDD.Name = "gpParamBDD";
            this.gpParamBDD.Size = new System.Drawing.Size(347, 455);
            this.gpParamBDD.TabIndex = 21;
            this.gpParamBDD.TabStop = false;
            this.gpParamBDD.Visible = false;
            this.gpParamBDD.Enter += new System.EventHandler(this.gpParamBDD_Enter);
            // 
            // btnAnnulerBDD
            // 
            this.btnAnnulerBDD.Location = new System.Drawing.Point(163, 398);
            this.btnAnnulerBDD.Name = "btnAnnulerBDD";
            this.btnAnnulerBDD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnnulerBDD.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerBDD.TabIndex = 31;
            this.btnAnnulerBDD.Text = "Annuler";
            this.btnAnnulerBDD.UseVisualStyleBackColor = true;
            this.btnAnnulerBDD.Click += new System.EventHandler(this.btnCloseParamBDD_Click);
            // 
            // btnValidBDD
            // 
            this.btnValidBDD.Location = new System.Drawing.Point(244, 398);
            this.btnValidBDD.Name = "btnValidBDD";
            this.btnValidBDD.Size = new System.Drawing.Size(75, 23);
            this.btnValidBDD.TabIndex = 30;
            this.btnValidBDD.Text = "Valider";
            this.btnValidBDD.UseVisualStyleBackColor = true;
            this.btnValidBDD.Click += new System.EventHandler(this.btnValidBDD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Wheat;
            this.label9.Location = new System.Drawing.Point(28, 343);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Wheat;
            this.label8.Location = new System.Drawing.Point(24, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Wheat;
            this.label7.Location = new System.Drawing.Point(27, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Database :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Wheat;
            this.label6.Location = new System.Drawing.Point(41, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Serveur :";
            // 
            // btnCloseParamBDD
            // 
            this.btnCloseParamBDD.AutoSize = true;
            this.btnCloseParamBDD.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseParamBDD.Location = new System.Drawing.Point(296, 16);
            this.btnCloseParamBDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCloseParamBDD.Name = "btnCloseParamBDD";
            this.btnCloseParamBDD.Size = new System.Drawing.Size(35, 37);
            this.btnCloseParamBDD.TabIndex = 22;
            this.btnCloseParamBDD.Text = "X";
            this.btnCloseParamBDD.Click += new System.EventHandler(this.btnCloseParamBDD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(45, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Parametres de la base de données";
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(124, 217);
            this.txtServeur.Margin = new System.Windows.Forms.Padding(2);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(195, 20);
            this.txtServeur.TabIndex = 25;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 301);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(196, 20);
            this.txtUser.TabIndex = 24;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(124, 258);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(196, 20);
            this.txtDatabase.TabIndex = 23;
            // 
            // txtPSW
            // 
            this.txtPSW.Location = new System.Drawing.Point(124, 343);
            this.txtPSW.Margin = new System.Windows.Forms.Padding(2);
            this.txtPSW.Name = "txtPSW";
            this.txtPSW.Size = new System.Drawing.Size(196, 20);
            this.txtPSW.TabIndex = 22;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(362, 474);
            this.ControlBox = false;
            this.Controls.Add(this.gpParamBDD);
            this.Controls.Add(this.btnParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSeePSW);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.lblCnxInscr);
            this.Controls.Add(this.txtMDP2);
            this.Controls.Add(this.lblMDP2);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(379, 490);
            this.MinimumSize = new System.Drawing.Size(273, 490);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeePSW)).EndInit();
            this.gpParamBDD.ResumeLayout(false);
            this.gpParamBDD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFermer;
        private System.Windows.Forms.Label lblCnxInscr;
        private System.Windows.Forms.TextBox txtMDP2;
        private System.Windows.Forms.Label lblMDP2;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.PictureBox BtnSeePSW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnParam;
        private System.Windows.Forms.GroupBox gpParamBDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPSW;
        private System.Windows.Forms.Label btnCloseParamBDD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnulerBDD;
        private System.Windows.Forms.Button btnValidBDD;
    }
}