﻿namespace Ex4_Bleu_Rouge
{
    partial class Form_fenetre
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
            this.cmd_HD = new System.Windows.Forms.Button();
            this.cmd_HG = new System.Windows.Forms.Button();
            this.cmd_BG = new System.Windows.Forms.Button();
            this.cmd_BD = new System.Windows.Forms.Button();
            this.Bleu = new System.Windows.Forms.Button();
            this.rouge = new System.Windows.Forms.Button();
            this.cmd_stats = new System.Windows.Forms.Button();
            this.cmd_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_HD
            // 
            this.cmd_HD.Location = new System.Drawing.Point(434, 12);
            this.cmd_HD.Name = "cmd_HD";
            this.cmd_HD.Size = new System.Drawing.Size(126, 55);
            this.cmd_HD.TabIndex = 0;
            this.cmd_HD.Text = "Haut Droite";
            this.cmd_HD.UseVisualStyleBackColor = true;
            this.cmd_HD.Click += new System.EventHandler(this.cmd_HD_Click);
            // 
            // cmd_HG
            // 
            this.cmd_HG.Location = new System.Drawing.Point(12, 12);
            this.cmd_HG.Name = "cmd_HG";
            this.cmd_HG.Size = new System.Drawing.Size(126, 55);
            this.cmd_HG.TabIndex = 1;
            this.cmd_HG.Text = "Haut Gauche";
            this.cmd_HG.UseVisualStyleBackColor = true;
            this.cmd_HG.Click += new System.EventHandler(this.cmd_HG_Click);
            // 
            // cmd_BG
            // 
            this.cmd_BG.Location = new System.Drawing.Point(12, 380);
            this.cmd_BG.Name = "cmd_BG";
            this.cmd_BG.Size = new System.Drawing.Size(126, 55);
            this.cmd_BG.TabIndex = 2;
            this.cmd_BG.Text = "Bas Gauche";
            this.cmd_BG.UseVisualStyleBackColor = true;
            // 
            // cmd_BD
            // 
            this.cmd_BD.Location = new System.Drawing.Point(434, 380);
            this.cmd_BD.Name = "cmd_BD";
            this.cmd_BD.Size = new System.Drawing.Size(126, 55);
            this.cmd_BD.TabIndex = 3;
            this.cmd_BD.Text = "Bas Droite";
            this.cmd_BD.UseVisualStyleBackColor = true;
            // 
            // Bleu
            // 
            this.Bleu.Location = new System.Drawing.Point(225, 83);
            this.Bleu.Name = "Bleu";
            this.Bleu.Size = new System.Drawing.Size(126, 55);
            this.Bleu.TabIndex = 4;
            this.Bleu.Text = "Bleu";
            this.Bleu.UseVisualStyleBackColor = true;
            this.Bleu.Click += new System.EventHandler(this.Bleu_Click);
            // 
            // rouge
            // 
            this.rouge.Location = new System.Drawing.Point(225, 144);
            this.rouge.Name = "rouge";
            this.rouge.Size = new System.Drawing.Size(126, 55);
            this.rouge.TabIndex = 5;
            this.rouge.Text = "Rouge";
            this.rouge.UseVisualStyleBackColor = true;
            this.rouge.Click += new System.EventHandler(this.rouge_Click);
            // 
            // cmd_stats
            // 
            this.cmd_stats.Location = new System.Drawing.Point(225, 244);
            this.cmd_stats.Name = "cmd_stats";
            this.cmd_stats.Size = new System.Drawing.Size(126, 55);
            this.cmd_stats.TabIndex = 6;
            this.cmd_stats.Text = "Stats";
            this.cmd_stats.UseVisualStyleBackColor = true;
            // 
            // cmd_quitter
            // 
            this.cmd_quitter.Location = new System.Drawing.Point(225, 331);
            this.cmd_quitter.Name = "cmd_quitter";
            this.cmd_quitter.Size = new System.Drawing.Size(126, 55);
            this.cmd_quitter.TabIndex = 7;
            this.cmd_quitter.Text = "Quitter";
            this.cmd_quitter.UseVisualStyleBackColor = true;
            // 
            // Form_fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 447);
            this.Controls.Add(this.cmd_quitter);
            this.Controls.Add(this.cmd_stats);
            this.Controls.Add(this.rouge);
            this.Controls.Add(this.Bleu);
            this.Controls.Add(this.cmd_BD);
            this.Controls.Add(this.cmd_BG);
            this.Controls.Add(this.cmd_HG);
            this.Controls.Add(this.cmd_HD);
            this.Name = "Form_fenetre";
            this.Text = "fenetre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_HD;
        private System.Windows.Forms.Button cmd_HG;
        private System.Windows.Forms.Button cmd_BG;
        private System.Windows.Forms.Button cmd_BD;
        private System.Windows.Forms.Button Bleu;
        private System.Windows.Forms.Button rouge;
        private System.Windows.Forms.Button cmd_stats;
        private System.Windows.Forms.Button cmd_quitter;
    }
}

