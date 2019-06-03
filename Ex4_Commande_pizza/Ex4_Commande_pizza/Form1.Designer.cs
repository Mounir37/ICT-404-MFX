namespace Ex4_Commande_pizza
{
    partial class Form_Pizza
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
            this.TxtB_table = new System.Windows.Forms.TextBox();
            this.lbl_table = new System.Windows.Forms.Label();
            this.RadBtn_ExFine = new System.Windows.Forms.RadioButton();
            this.RadBtn_fine = new System.Windows.Forms.RadioButton();
            this.RadBtn_Normal = new System.Windows.Forms.RadioButton();
            this.RadBtn_Epaisse = new System.Windows.Forms.RadioButton();
            this.GBox_pate = new System.Windows.Forms.GroupBox();
            this.CbBox_Anchois = new System.Windows.Forms.CheckBox();
            this.ChBox_Capres = new System.Windows.Forms.CheckBox();
            this.ChBox_Jambon = new System.Windows.Forms.CheckBox();
            this.ChBox_Crevettes = new System.Windows.Forms.CheckBox();
            this.Cmd_commander = new System.Windows.Forms.Button();
            this.lbl_commande = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtB_table
            // 
            this.TxtB_table.Location = new System.Drawing.Point(95, 38);
            this.TxtB_table.Name = "TxtB_table";
            this.TxtB_table.Size = new System.Drawing.Size(30, 20);
            this.TxtB_table.TabIndex = 0;
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table.Location = new System.Drawing.Point(45, 39);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(44, 16);
            this.lbl_table.TabIndex = 1;
            this.lbl_table.Text = "Table";
            this.lbl_table.Click += new System.EventHandler(this.label1_Click);
            // 
            // RadBtn_ExFine
            // 
            this.RadBtn_ExFine.AutoSize = true;
            this.RadBtn_ExFine.Location = new System.Drawing.Point(48, 111);
            this.RadBtn_ExFine.Name = "RadBtn_ExFine";
            this.RadBtn_ExFine.Size = new System.Drawing.Size(69, 17);
            this.RadBtn_ExFine.TabIndex = 2;
            this.RadBtn_ExFine.TabStop = true;
            this.RadBtn_ExFine.Text = "Extra-fine";
            this.RadBtn_ExFine.UseVisualStyleBackColor = true;
            // 
            // RadBtn_fine
            // 
            this.RadBtn_fine.AutoSize = true;
            this.RadBtn_fine.Location = new System.Drawing.Point(48, 134);
            this.RadBtn_fine.Name = "RadBtn_fine";
            this.RadBtn_fine.Size = new System.Drawing.Size(45, 17);
            this.RadBtn_fine.TabIndex = 3;
            this.RadBtn_fine.TabStop = true;
            this.RadBtn_fine.Text = "Fine";
            this.RadBtn_fine.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Normal
            // 
            this.RadBtn_Normal.AutoSize = true;
            this.RadBtn_Normal.Location = new System.Drawing.Point(48, 157);
            this.RadBtn_Normal.Name = "RadBtn_Normal";
            this.RadBtn_Normal.Size = new System.Drawing.Size(64, 17);
            this.RadBtn_Normal.TabIndex = 4;
            this.RadBtn_Normal.TabStop = true;
            this.RadBtn_Normal.Text = "Normale";
            this.RadBtn_Normal.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Epaisse
            // 
            this.RadBtn_Epaisse.AutoSize = true;
            this.RadBtn_Epaisse.Location = new System.Drawing.Point(48, 180);
            this.RadBtn_Epaisse.Name = "RadBtn_Epaisse";
            this.RadBtn_Epaisse.Size = new System.Drawing.Size(62, 17);
            this.RadBtn_Epaisse.TabIndex = 5;
            this.RadBtn_Epaisse.TabStop = true;
            this.RadBtn_Epaisse.Text = "Epaisse";
            this.RadBtn_Epaisse.UseVisualStyleBackColor = true;
            // 
            // GBox_pate
            // 
            this.GBox_pate.Location = new System.Drawing.Point(16, 78);
            this.GBox_pate.Name = "GBox_pate";
            this.GBox_pate.Size = new System.Drawing.Size(135, 140);
            this.GBox_pate.TabIndex = 6;
            this.GBox_pate.TabStop = false;
            this.GBox_pate.Text = "Pâte";
            this.GBox_pate.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CbBox_Anchois
            // 
            this.CbBox_Anchois.AutoSize = true;
            this.CbBox_Anchois.Location = new System.Drawing.Point(278, 111);
            this.CbBox_Anchois.Name = "CbBox_Anchois";
            this.CbBox_Anchois.Size = new System.Drawing.Size(64, 17);
            this.CbBox_Anchois.TabIndex = 7;
            this.CbBox_Anchois.Text = "Anchois";
            this.CbBox_Anchois.UseVisualStyleBackColor = true;
            // 
            // ChBox_Capres
            // 
            this.ChBox_Capres.AutoSize = true;
            this.ChBox_Capres.Location = new System.Drawing.Point(278, 135);
            this.ChBox_Capres.Name = "ChBox_Capres";
            this.ChBox_Capres.Size = new System.Drawing.Size(59, 17);
            this.ChBox_Capres.TabIndex = 8;
            this.ChBox_Capres.Text = "Câpres";
            this.ChBox_Capres.UseVisualStyleBackColor = true;
            // 
            // ChBox_Jambon
            // 
            this.ChBox_Jambon.AutoSize = true;
            this.ChBox_Jambon.Location = new System.Drawing.Point(278, 158);
            this.ChBox_Jambon.Name = "ChBox_Jambon";
            this.ChBox_Jambon.Size = new System.Drawing.Size(63, 17);
            this.ChBox_Jambon.TabIndex = 9;
            this.ChBox_Jambon.Text = "Jambon";
            this.ChBox_Jambon.UseVisualStyleBackColor = true;
            // 
            // ChBox_Crevettes
            // 
            this.ChBox_Crevettes.AutoSize = true;
            this.ChBox_Crevettes.Location = new System.Drawing.Point(278, 181);
            this.ChBox_Crevettes.Name = "ChBox_Crevettes";
            this.ChBox_Crevettes.Size = new System.Drawing.Size(71, 17);
            this.ChBox_Crevettes.TabIndex = 10;
            this.ChBox_Crevettes.Text = "Crevettes";
            this.ChBox_Crevettes.UseVisualStyleBackColor = true;
            // 
            // Cmd_commander
            // 
            this.Cmd_commander.Location = new System.Drawing.Point(278, 258);
            this.Cmd_commander.Name = "Cmd_commander";
            this.Cmd_commander.Size = new System.Drawing.Size(75, 23);
            this.Cmd_commander.TabIndex = 11;
            this.Cmd_commander.Text = "Commander";
            this.Cmd_commander.UseVisualStyleBackColor = true;
            this.Cmd_commander.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_commande
            // 
            this.lbl_commande.AutoSize = true;
            this.lbl_commande.Location = new System.Drawing.Point(13, 268);
            this.lbl_commande.Name = "lbl_commande";
            this.lbl_commande.Size = new System.Drawing.Size(60, 13);
            this.lbl_commande.TabIndex = 12;
            this.lbl_commande.Text = "Commande";
            this.lbl_commande.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 84);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form_Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_commande);
            this.Controls.Add(this.Cmd_commander);
            this.Controls.Add(this.ChBox_Crevettes);
            this.Controls.Add(this.ChBox_Jambon);
            this.Controls.Add(this.ChBox_Capres);
            this.Controls.Add(this.CbBox_Anchois);
            this.Controls.Add(this.RadBtn_Epaisse);
            this.Controls.Add(this.RadBtn_Normal);
            this.Controls.Add(this.RadBtn_fine);
            this.Controls.Add(this.RadBtn_ExFine);
            this.Controls.Add(this.lbl_table);
            this.Controls.Add(this.TxtB_table);
            this.Controls.Add(this.GBox_pate);
            this.Name = "Form_Pizza";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB_table;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.RadioButton RadBtn_ExFine;
        private System.Windows.Forms.RadioButton RadBtn_fine;
        private System.Windows.Forms.RadioButton RadBtn_Normal;
        private System.Windows.Forms.RadioButton RadBtn_Epaisse;
        private System.Windows.Forms.GroupBox GBox_pate;
        private System.Windows.Forms.CheckBox CbBox_Anchois;
        private System.Windows.Forms.CheckBox ChBox_Capres;
        private System.Windows.Forms.CheckBox ChBox_Jambon;
        private System.Windows.Forms.CheckBox ChBox_Crevettes;
        private System.Windows.Forms.Button Cmd_commander;
        private System.Windows.Forms.Label lbl_commande;
        private System.Windows.Forms.Label label1;
    }
}

