namespace prisonAutomation
{
    partial class startPage
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
            this.personalBut = new System.Windows.Forms.Button();
            this.visitorBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalBut
            // 
            this.personalBut.BackColor = System.Drawing.SystemColors.Info;
            this.personalBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBut.Location = new System.Drawing.Point(566, 400);
            this.personalBut.Name = "personalBut";
            this.personalBut.Size = new System.Drawing.Size(98, 38);
            this.personalBut.TabIndex = 0;
            this.personalBut.Text = "Personal";
            this.personalBut.UseMnemonic = false;
            this.personalBut.UseVisualStyleBackColor = false;
            this.personalBut.Click += new System.EventHandler(this.personalBut_Click);
            // 
            // visitorBut
            // 
            this.visitorBut.BackColor = System.Drawing.SystemColors.Info;
            this.visitorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitorBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorBut.Location = new System.Drawing.Point(462, 400);
            this.visitorBut.Name = "visitorBut";
            this.visitorBut.Size = new System.Drawing.Size(98, 38);
            this.visitorBut.TabIndex = 1;
            this.visitorBut.Text = "Visitor";
            this.visitorBut.UseMnemonic = false;
            this.visitorBut.UseVisualStyleBackColor = false;
            this.visitorBut.Click += new System.EventHandler(this.visitorBut_Click);
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::prisonAutomation.Properties.Resources.lawAndOrder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.visitorBut);
            this.Controls.Add(this.personalBut);
            this.Name = "startPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalBut;
        private System.Windows.Forms.Button visitorBut;
    }
}

