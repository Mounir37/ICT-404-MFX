namespace Ex6_Traban
{
    partial class Form1
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
            this.lbl_prix_base = new System.Windows.Forms.Label();
            this.TxtB_prix_base = new System.Windows.Forms.TextBox();
            this.GBox_moteur = new System.Windows.Forms.GroupBox();
            this.RadBtn_1L6 = new System.Windows.Forms.RadioButton();
            this.RadBtn_1L4 = new System.Windows.Forms.RadioButton();
            this.Lbl_taxe = new System.Windows.Forms.Label();
            this.ChBox_taxe = new System.Windows.Forms.CheckBox();
            this.Lbl_Final = new System.Windows.Forms.Label();
            this.lbl_somme_final = new System.Windows.Forms.Label();
            this.Cmd_reset = new System.Windows.Forms.Button();
            this.Cmd_leave = new System.Windows.Forms.Button();
            this.Cmd_calculer = new System.Windows.Forms.Button();
            this.GBox_moteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_prix_base
            // 
            this.lbl_prix_base.AutoSize = true;
            this.lbl_prix_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prix_base.Location = new System.Drawing.Point(23, 42);
            this.lbl_prix_base.Name = "lbl_prix_base";
            this.lbl_prix_base.Size = new System.Drawing.Size(380, 25);
            this.lbl_prix_base.TabIndex = 0;
            this.lbl_prix_base.Text = "Prix de base en € (doit être >10000 €):";
            // 
            // TxtB_prix_base
            // 
            this.TxtB_prix_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_prix_base.Location = new System.Drawing.Point(409, 39);
            this.TxtB_prix_base.Name = "TxtB_prix_base";
            this.TxtB_prix_base.Size = new System.Drawing.Size(250, 31);
            this.TxtB_prix_base.TabIndex = 1;
            this.TxtB_prix_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtB_prix_base.TextChanged += new System.EventHandler(this.TxtB_prix_base_TextChanged);
            // 
            // GBox_moteur
            // 
            this.GBox_moteur.Controls.Add(this.RadBtn_1L6);
            this.GBox_moteur.Controls.Add(this.RadBtn_1L4);
            this.GBox_moteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_moteur.Location = new System.Drawing.Point(28, 109);
            this.GBox_moteur.Name = "GBox_moteur";
            this.GBox_moteur.Size = new System.Drawing.Size(375, 129);
            this.GBox_moteur.TabIndex = 2;
            this.GBox_moteur.TabStop = false;
            this.GBox_moteur.Text = "Choix du moteur:";
            // 
            // RadBtn_1L6
            // 
            this.RadBtn_1L6.AutoSize = true;
            this.RadBtn_1L6.Location = new System.Drawing.Point(6, 77);
            this.RadBtn_1L6.Name = "RadBtn_1L6";
            this.RadBtn_1L6.Size = new System.Drawing.Size(133, 28);
            this.RadBtn_1L6.TabIndex = 4;
            this.RadBtn_1L6.TabStop = true;
            this.RadBtn_1L6.Text = "1.6L : 2210 €";
            this.RadBtn_1L6.UseVisualStyleBackColor = true;
            // 
            // RadBtn_1L4
            // 
            this.RadBtn_1L4.AutoSize = true;
            this.RadBtn_1L4.Location = new System.Drawing.Point(6, 43);
            this.RadBtn_1L4.Name = "RadBtn_1L4";
            this.RadBtn_1L4.Size = new System.Drawing.Size(302, 28);
            this.RadBtn_1L4.TabIndex = 3;
            this.RadBtn_1L4.TabStop = true;
            this.RadBtn_1L4.Text = "1.4L : inclus dans le prix de base";
            this.RadBtn_1L4.UseVisualStyleBackColor = true;
            // 
            // Lbl_taxe
            // 
            this.Lbl_taxe.AutoSize = true;
            this.Lbl_taxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_taxe.Location = new System.Drawing.Point(31, 265);
            this.Lbl_taxe.Name = "Lbl_taxe";
            this.Lbl_taxe.Size = new System.Drawing.Size(58, 24);
            this.Lbl_taxe.TabIndex = 3;
            this.Lbl_taxe.Text = "Taxe:";
            // 
            // ChBox_taxe
            // 
            this.ChBox_taxe.AutoSize = true;
            this.ChBox_taxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBox_taxe.Location = new System.Drawing.Point(35, 306);
            this.ChBox_taxe.Name = "ChBox_taxe";
            this.ChBox_taxe.Size = new System.Drawing.Size(222, 28);
            this.ChBox_taxe.TabIndex = 4;
            this.ChBox_taxe.Text = "Inclure la taxe de 6.8%.";
            this.ChBox_taxe.UseVisualStyleBackColor = true;
            // 
            // Lbl_Final
            // 
            this.Lbl_Final.AutoSize = true;
            this.Lbl_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Final.Location = new System.Drawing.Point(31, 390);
            this.Lbl_Final.Name = "Lbl_Final";
            this.Lbl_Final.Size = new System.Drawing.Size(93, 24);
            this.Lbl_Final.TabIndex = 5;
            this.Lbl_Final.Text = "Prix Final:";
            // 
            // lbl_somme_final
            // 
            this.lbl_somme_final.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_somme_final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_somme_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_somme_final.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_somme_final.Location = new System.Drawing.Point(153, 373);
            this.lbl_somme_final.Name = "lbl_somme_final";
            this.lbl_somme_final.Size = new System.Drawing.Size(166, 59);
            this.lbl_somme_final.TabIndex = 6;
            this.lbl_somme_final.Text = "Prix Final:";
            this.lbl_somme_final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_reset
            // 
            this.Cmd_reset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cmd_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_reset.Location = new System.Drawing.Point(34, 469);
            this.Cmd_reset.Name = "Cmd_reset";
            this.Cmd_reset.Size = new System.Drawing.Size(302, 47);
            this.Cmd_reset.TabIndex = 7;
            this.Cmd_reset.Text = "Remettre le formulaire à zéro";
            this.Cmd_reset.UseVisualStyleBackColor = false;
            // 
            // Cmd_leave
            // 
            this.Cmd_leave.BackColor = System.Drawing.Color.DarkRed;
            this.Cmd_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_leave.ForeColor = System.Drawing.Color.White;
            this.Cmd_leave.Location = new System.Drawing.Point(357, 469);
            this.Cmd_leave.Name = "Cmd_leave";
            this.Cmd_leave.Size = new System.Drawing.Size(302, 47);
            this.Cmd_leave.TabIndex = 8;
            this.Cmd_leave.Text = "Quitter";
            this.Cmd_leave.UseVisualStyleBackColor = false;
            // 
            // Cmd_calculer
            // 
            this.Cmd_calculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cmd_calculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_calculer.Location = new System.Drawing.Point(357, 373);
            this.Cmd_calculer.Name = "Cmd_calculer";
            this.Cmd_calculer.Size = new System.Drawing.Size(166, 59);
            this.Cmd_calculer.TabIndex = 9;
            this.Cmd_calculer.Text = "calculer";
            this.Cmd_calculer.UseVisualStyleBackColor = false;
            this.Cmd_calculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 551);
            this.Controls.Add(this.Cmd_calculer);
            this.Controls.Add(this.Cmd_leave);
            this.Controls.Add(this.Cmd_reset);
            this.Controls.Add(this.lbl_somme_final);
            this.Controls.Add(this.Lbl_Final);
            this.Controls.Add(this.ChBox_taxe);
            this.Controls.Add(this.Lbl_taxe);
            this.Controls.Add(this.GBox_moteur);
            this.Controls.Add(this.TxtB_prix_base);
            this.Controls.Add(this.lbl_prix_base);
            this.Name = "Form1";
            this.Text = "Traban 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBox_moteur.ResumeLayout(false);
            this.GBox_moteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prix_base;
        private System.Windows.Forms.TextBox TxtB_prix_base;
        private System.Windows.Forms.GroupBox GBox_moteur;
        private System.Windows.Forms.RadioButton RadBtn_1L6;
        private System.Windows.Forms.RadioButton RadBtn_1L4;
        private System.Windows.Forms.Label Lbl_taxe;
        private System.Windows.Forms.CheckBox ChBox_taxe;
        private System.Windows.Forms.Label Lbl_Final;
        private System.Windows.Forms.Label lbl_somme_final;
        private System.Windows.Forms.Button Cmd_reset;
        private System.Windows.Forms.Button Cmd_leave;
        private System.Windows.Forms.Button Cmd_calculer;
    }
}

