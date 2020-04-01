namespace Form_MF
{
    partial class FMere
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
            this.lbLesFIlles = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLesFIlles
            // 
            this.lbLesFIlles.FormattingEnabled = true;
            this.lbLesFIlles.Location = new System.Drawing.Point(380, 113);
            this.lbLesFIlles.Name = "lbLesFIlles";
            this.lbLesFIlles.Size = new System.Drawing.Size(197, 160);
            this.lbLesFIlles.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(380, 74);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "New()";
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnClose);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnShow);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hide";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnHide);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(384, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 21);
            this.button5.TabIndex = 5;
            this.button5.Text = "ShowDialog";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnShowDialog);
            // 
            // FMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.lbLesFIlles);
            this.Name = "FMere";
            this.Text = "FMere";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLesFIlles;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

