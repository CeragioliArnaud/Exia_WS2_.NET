namespace Client
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
            this.DataGridMain = new System.Windows.Forms.DataGridView();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.Btn_Changer = new System.Windows.Forms.Button();
            this.Btn_SearchName = new System.Windows.Forms.Button();
            this.TextSearchByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMain
            // 
            this.DataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMain.Location = new System.Drawing.Point(21, 21);
            this.DataGridMain.Name = "DataGridMain";
            this.DataGridMain.Size = new System.Drawing.Size(328, 306);
            this.DataGridMain.TabIndex = 0;
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.Location = new System.Drawing.Point(46, 375);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(120, 42);
            this.Btn_Reload.TabIndex = 1;
            this.Btn_Reload.Text = "&Reload";
            this.Btn_Reload.UseVisualStyleBackColor = true;
            this.Btn_Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Btn_Changer
            // 
            this.Btn_Changer.Location = new System.Drawing.Point(46, 437);
            this.Btn_Changer.Name = "Btn_Changer";
            this.Btn_Changer.Size = new System.Drawing.Size(120, 43);
            this.Btn_Changer.TabIndex = 2;
            this.Btn_Changer.Text = "&BtnCharger";
            this.Btn_Changer.UseVisualStyleBackColor = true;
            this.Btn_Changer.Click += new System.EventHandler(this.Charger_Click);
            // 
            // Btn_SearchName
            // 
            this.Btn_SearchName.Location = new System.Drawing.Point(321, 447);
            this.Btn_SearchName.Name = "Btn_SearchName";
            this.Btn_SearchName.Size = new System.Drawing.Size(137, 33);
            this.Btn_SearchName.TabIndex = 3;
            this.Btn_SearchName.Text = "&Search Nom";
            this.Btn_SearchName.UseVisualStyleBackColor = true;
            this.Btn_SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // TextSearchByName
            // 
            this.TextSearchByName.Location = new System.Drawing.Point(321, 375);
            this.TextSearchByName.Multiline = true;
            this.TextSearchByName.Name = "TextSearchByName";
            this.TextSearchByName.Size = new System.Drawing.Size(137, 50);
            this.TextSearchByName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 584);
            this.Controls.Add(this.TextSearchByName);
            this.Controls.Add(this.Btn_SearchName);
            this.Controls.Add(this.Btn_Changer);
            this.Controls.Add(this.Btn_Reload);
            this.Controls.Add(this.DataGridMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMain;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.Button Btn_Changer;
        private System.Windows.Forms.Button Btn_SearchName;
        private System.Windows.Forms.TextBox TextSearchByName;
    }
}

