namespace prisonAutomation
{
    partial class visitorPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.birthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.bookBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(460, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date of Birth:";
            // 
            // birthBox
            // 
            this.birthBox.BackColor = System.Drawing.SystemColors.Info;
            this.birthBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.birthBox.Location = new System.Drawing.Point(564, 64);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(100, 20);
            this.birthBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(459, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Full Name:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nameBox.Location = new System.Drawing.Point(564, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(460, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.SystemColors.Info;
            this.idText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.idText.Location = new System.Drawing.Point(564, 12);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 28;
            // 
            // bookBut
            // 
            this.bookBut.BackColor = System.Drawing.SystemColors.Info;
            this.bookBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBut.Location = new System.Drawing.Point(505, 400);
            this.bookBut.Name = "bookBut";
            this.bookBut.Size = new System.Drawing.Size(159, 38);
            this.bookBut.TabIndex = 41;
            this.bookBut.Text = "BOOK A VISIT";
            this.bookBut.UseMnemonic = false;
            this.bookBut.UseVisualStyleBackColor = false;
            this.bookBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.SystemColors.Info;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(12, 400);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(134, 38);
            this.backBut.TabIndex = 42;
            this.backBut.Text = "BACK";
            this.backBut.UseMnemonic = false;
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // visitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prisonAutomation.Properties.Resources.lawAndOrder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.bookBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idText);
            this.Name = "visitorPage";
            this.Text = "visitorPage";
            this.Load += new System.EventHandler(this.visitorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button bookBut;
        private System.Windows.Forms.Button backBut;
    }
}