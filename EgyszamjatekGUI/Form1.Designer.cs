namespace EgyszamjatekGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NevTxtBox = new System.Windows.Forms.TextBox();
            this.TippTxtBox = new System.Windows.Forms.TextBox();
            this.HozzaAdBtn = new System.Windows.Forms.Button();
            this.DarabLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos tippjei";
            // 
            // NevTxtBox
            // 
            this.NevTxtBox.Location = new System.Drawing.Point(106, 29);
            this.NevTxtBox.Name = "NevTxtBox";
            this.NevTxtBox.Size = new System.Drawing.Size(217, 20);
            this.NevTxtBox.TabIndex = 2;
            // 
            // TippTxtBox
            // 
            this.TippTxtBox.Location = new System.Drawing.Point(106, 69);
            this.TippTxtBox.Name = "TippTxtBox";
            this.TippTxtBox.Size = new System.Drawing.Size(288, 20);
            this.TippTxtBox.TabIndex = 3;
            this.TippTxtBox.TextChanged += new System.EventHandler(this.TippTxtBox_TextChanged);
            // 
            // HozzaAdBtn
            // 
            this.HozzaAdBtn.Location = new System.Drawing.Point(151, 118);
            this.HozzaAdBtn.Name = "HozzaAdBtn";
            this.HozzaAdBtn.Size = new System.Drawing.Size(198, 23);
            this.HozzaAdBtn.TabIndex = 4;
            this.HozzaAdBtn.Text = "Játékos hozzáadása";
            this.HozzaAdBtn.UseVisualStyleBackColor = true;
            // 
            // DarabLbl
            // 
            this.DarabLbl.AutoSize = true;
            this.DarabLbl.Location = new System.Drawing.Point(424, 75);
            this.DarabLbl.Name = "DarabLbl";
            this.DarabLbl.Size = new System.Drawing.Size(0, 13);
            this.DarabLbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 166);
            this.Controls.Add(this.DarabLbl);
            this.Controls.Add(this.HozzaAdBtn);
            this.Controls.Add(this.TippTxtBox);
            this.Controls.Add(this.NevTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egyszámjáték GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NevTxtBox;
        private System.Windows.Forms.TextBox TippTxtBox;
        private System.Windows.Forms.Button HozzaAdBtn;
        private System.Windows.Forms.Label DarabLbl;
    }
}

