namespace Ex3_familiarisation
{
    partial class Form_Déduction
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
            this.Lbl_Revenue = new System.Windows.Forms.Label();
            this.Lbl_coefficient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChBox_Jeune = new System.Windows.Forms.CheckBox();
            this.ChBox_Transport = new System.Windows.Forms.CheckBox();
            this.ChBox_Rabais = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Cmd_Calcul = new System.Windows.Forms.Button();
            this.Lbl_revnue_imposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Revenue
            // 
            this.Lbl_Revenue.AutoSize = true;
            this.Lbl_Revenue.Location = new System.Drawing.Point(90, 66);
            this.Lbl_Revenue.Name = "Lbl_Revenue";
            this.Lbl_Revenue.Size = new System.Drawing.Size(101, 13);
            this.Lbl_Revenue.TabIndex = 0;
            this.Lbl_Revenue.Text = "Revenu annuel brut";
            // 
            // Lbl_coefficient
            // 
            this.Lbl_coefficient.AutoSize = true;
            this.Lbl_coefficient.Location = new System.Drawing.Point(90, 112);
            this.Lbl_coefficient.Name = "Lbl_coefficient";
            this.Lbl_coefficient.Size = new System.Drawing.Size(99, 13);
            this.Lbl_coefficient.TabIndex = 1;
            this.Lbl_coefficient.Text = "Coefficient familliale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // ChBox_Jeune
            // 
            this.ChBox_Jeune.AutoSize = true;
            this.ChBox_Jeune.Location = new System.Drawing.Point(144, 223);
            this.ChBox_Jeune.Name = "ChBox_Jeune";
            this.ChBox_Jeune.Size = new System.Drawing.Size(102, 17);
            this.ChBox_Jeune.TabIndex = 5;
            this.ChBox_Jeune.Text = "déduction jeune";
            this.ChBox_Jeune.UseVisualStyleBackColor = true;
            this.ChBox_Jeune.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChBox_Transport
            // 
            this.ChBox_Transport.AutoSize = true;
            this.ChBox_Transport.Location = new System.Drawing.Point(144, 254);
            this.ChBox_Transport.Name = "ChBox_Transport";
            this.ChBox_Transport.Size = new System.Drawing.Size(119, 17);
            this.ChBox_Transport.TabIndex = 6;
            this.ChBox_Transport.Text = "Déduction transport";
            this.ChBox_Transport.UseVisualStyleBackColor = true;
            // 
            // ChBox_Rabais
            // 
            this.ChBox_Rabais.AutoSize = true;
            this.ChBox_Rabais.Location = new System.Drawing.Point(144, 283);
            this.ChBox_Rabais.Name = "ChBox_Rabais";
            this.ChBox_Rabais.Size = new System.Drawing.Size(109, 17);
            this.ChBox_Rabais.TabIndex = 7;
            this.ChBox_Rabais.Text = "Rabais fidélité (%)";
            this.ChBox_Rabais.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(430, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(430, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(430, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 12;
            // 
            // Cmd_Calcul
            // 
            this.Cmd_Calcul.Location = new System.Drawing.Point(258, 351);
            this.Cmd_Calcul.Name = "Cmd_Calcul";
            this.Cmd_Calcul.Size = new System.Drawing.Size(105, 30);
            this.Cmd_Calcul.TabIndex = 13;
            this.Cmd_Calcul.Text = "Calcul";
            this.Cmd_Calcul.UseVisualStyleBackColor = true;
            this.Cmd_Calcul.Click += new System.EventHandler(this.Cmd_Calcul_Click);
            // 
            // Lbl_revnue_imposable
            // 
            this.Lbl_revnue_imposable.AutoSize = true;
            this.Lbl_revnue_imposable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_revnue_imposable.Location = new System.Drawing.Point(427, 402);
            this.Lbl_revnue_imposable.Name = "Lbl_revnue_imposable";
            this.Lbl_revnue_imposable.Size = new System.Drawing.Size(35, 18);
            this.Lbl_revnue_imposable.TabIndex = 14;
            this.Lbl_revnue_imposable.Text = "abc";
            // 
            // Form_Déduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_revnue_imposable);
            this.Controls.Add(this.Cmd_Calcul);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChBox_Rabais);
            this.Controls.Add(this.ChBox_Transport);
            this.Controls.Add(this.ChBox_Jeune);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_coefficient);
            this.Controls.Add(this.Lbl_Revenue);
            this.Name = "Form_Déduction";
            this.Text = "Déductions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Revenue;
        private System.Windows.Forms.Label Lbl_coefficient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChBox_Jeune;
        private System.Windows.Forms.CheckBox ChBox_Transport;
        private System.Windows.Forms.CheckBox ChBox_Rabais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Cmd_Calcul;
        private System.Windows.Forms.Label Lbl_revnue_imposable;
    }
}

