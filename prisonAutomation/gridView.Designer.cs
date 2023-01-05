namespace prisonAutomation
{
    partial class gridView
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
            this.table = new System.Windows.Forms.DataGridView();
            this.personalBut = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(652, 375);
            this.table.TabIndex = 0;
            // 
            // personalBut
            // 
            this.personalBut.BackColor = System.Drawing.SystemColors.Info;
            this.personalBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBut.Location = new System.Drawing.Point(12, 400);
            this.personalBut.Name = "personalBut";
            this.personalBut.Size = new System.Drawing.Size(212, 38);
            this.personalBut.TabIndex = 24;
            this.personalBut.Text = "PERSONAL PANEL";
            this.personalBut.UseMnemonic = false;
            this.personalBut.UseVisualStyleBackColor = false;
            this.personalBut.Click += new System.EventHandler(this.personalBut_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Info;
            this.searchBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBox.Location = new System.Drawing.Point(230, 412);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(323, 20);
            this.searchBox.TabIndex = 25;
            // 
            // searchBut
            // 
            this.searchBut.BackColor = System.Drawing.SystemColors.Info;
            this.searchBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBut.Location = new System.Drawing.Point(559, 400);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(105, 38);
            this.searchBut.TabIndex = 26;
            this.searchBut.Text = "SEARCH";
            this.searchBut.UseMnemonic = false;
            this.searchBut.UseVisualStyleBackColor = false;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // gridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prisonAutomation.Properties.Resources.lawAndOrder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.personalBut);
            this.Controls.Add(this.table);
            this.Name = "gridView";
            this.Text = "girdView";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button personalBut;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBut;
    }
}