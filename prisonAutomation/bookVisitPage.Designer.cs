namespace prisonAutomation
{
    partial class bookVisitPage
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
            this.crimeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crimeBox
            // 
            this.crimeBox.BackColor = System.Drawing.SystemColors.Info;
            this.crimeBox.FormattingEnabled = true;
            this.crimeBox.Items.AddRange(new object[] {
            "Wednesday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.crimeBox.Location = new System.Drawing.Point(564, 12);
            this.crimeBox.Name = "crimeBox";
            this.crimeBox.Size = new System.Drawing.Size(100, 21);
            this.crimeBox.TabIndex = 23;
            this.crimeBox.SelectedIndexChanged += new System.EventHandler(this.crimeBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(511, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Day:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.comboBox1.Location = new System.Drawing.Point(564, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(511, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Time:";
            // 
            // createBut
            // 
            this.createBut.BackColor = System.Drawing.SystemColors.Info;
            this.createBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBut.Location = new System.Drawing.Point(437, 400);
            this.createBut.Name = "createBut";
            this.createBut.Size = new System.Drawing.Size(227, 38);
            this.createBut.TabIndex = 26;
            this.createBut.Text = "BOOK IF AVAILABLE";
            this.createBut.UseMnemonic = false;
            this.createBut.UseVisualStyleBackColor = false;
            this.createBut.Click += new System.EventHandler(this.createBut_Click);
            // 
            // bookVisitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prisonAutomation.Properties.Resources.lawAndOrder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.createBut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crimeBox);
            this.Controls.Add(this.label3);
            this.Name = "bookVisitPage";
            this.Text = "bookVisitPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox crimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBut;
    }
}