namespace WindowsFormsApplication4
{
    partial class Horocope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horocope));
            this.openButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Cornsilk;
            this.openButton.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.DarkRed;
            this.openButton.Location = new System.Drawing.Point(72, 34);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(172, 146);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open Horoscope Card\r\n";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(106, 212);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "By, Brooke Huffman ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(105, 225);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(106, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "September, 29, 2016";
            // 
            // Horocope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(325, 305);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.openButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Horocope";
            this.Text = "Virgo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

