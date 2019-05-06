namespace Ex2_Bonjour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.TxtB_Nom = new System.Windows.Forms.TextBox();
            this.Btn_bienvenue = new System.Windows.Forms.Button();
            this.Lbl_Bjr_ = new System.Windows.Forms.Label();
            this.Btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nom.Location = new System.Drawing.Point(66, 53);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(152, 31);
            this.Lbl_Nom.TabIndex = 0;
            this.Lbl_Nom.Text = "Votre Nom";
            this.Lbl_Nom.Click += new System.EventHandler(this.Lbl_Nom_Click);
            // 
            // TxtB_Nom
            // 
            this.TxtB_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_Nom.Location = new System.Drawing.Point(243, 49);
            this.TxtB_Nom.Name = "TxtB_Nom";
            this.TxtB_Nom.Size = new System.Drawing.Size(399, 40);
            this.TxtB_Nom.TabIndex = 1;
            this.TxtB_Nom.TextChanged += new System.EventHandler(this.TxtB_Nom_TextChanged);
            // 
            // Btn_bienvenue
            // 
            this.Btn_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_bienvenue.Location = new System.Drawing.Point(243, 300);
            this.Btn_bienvenue.Name = "Btn_bienvenue";
            this.Btn_bienvenue.Size = new System.Drawing.Size(298, 92);
            this.Btn_bienvenue.TabIndex = 2;
            this.Btn_bienvenue.Text = "Bienvenue";
            this.Btn_bienvenue.UseVisualStyleBackColor = true;
            this.Btn_bienvenue.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Bjr_
            // 
            this.Lbl_Bjr_.AutoSize = true;
            this.Lbl_Bjr_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bjr_.Location = new System.Drawing.Point(69, 209);
            this.Lbl_Bjr_.Name = "Lbl_Bjr_";
            this.Lbl_Bjr_.Size = new System.Drawing.Size(41, 31);
            this.Lbl_Bjr_.TabIndex = 3;
            this.Lbl_Bjr_.Text = "...";
            this.Lbl_Bjr_.Click += new System.EventHandler(this.Lbl_Bjr__Click);
            // 
            // Btn_quitter
            // 
            this.Btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_quitter.Image = ((System.Drawing.Image)(resources.GetObject("Btn_quitter.Image")));
            this.Btn_quitter.Location = new System.Drawing.Point(632, 290);
            this.Btn_quitter.Name = "Btn_quitter";
            this.Btn_quitter.Size = new System.Drawing.Size(99, 92);
            this.Btn_quitter.TabIndex = 4;
            this.Btn_quitter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_quitter);
            this.Controls.Add(this.Lbl_Bjr_);
            this.Controls.Add(this.Btn_bienvenue);
            this.Controls.Add(this.TxtB_Nom);
            this.Controls.Add(this.Lbl_Nom);
            this.Name = "Form1";
            this.Text = "Bonjour Qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.TextBox TxtB_Nom;
        private System.Windows.Forms.Button Btn_bienvenue;
        private System.Windows.Forms.Label Lbl_Bjr_;
        private System.Windows.Forms.Button Btn_quitter;
    }
}

