namespace COMP123_Assignment07
{
    partial class StreamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.TankLabel = new System.Windows.Forms.Label();
            this.CreditChargedLabel = new System.Windows.Forms.Label();
            this.BeginStreamingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(134, 171);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(86, 26);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TankLabel
            // 
            this.TankLabel.AutoSize = true;
            this.TankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel.Location = new System.Drawing.Point(41, 7);
            this.TankLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TankLabel.Name = "TankLabel";
            this.TankLabel.Size = new System.Drawing.Size(290, 20);
            this.TankLabel.TabIndex = 1;
            this.TankLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // CreditChargedLabel
            // 
            this.CreditChargedLabel.AutoSize = true;
            this.CreditChargedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditChargedLabel.Location = new System.Drawing.Point(9, 117);
            this.CreditChargedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreditChargedLabel.Name = "CreditChargedLabel";
            this.CreditChargedLabel.Size = new System.Drawing.Size(18, 20);
            this.CreditChargedLabel.TabIndex = 2;
            this.CreditChargedLabel.Text = "0";
            // 
            // BeginStreamingLabel
            // 
            this.BeginStreamingLabel.AutoSize = true;
            this.BeginStreamingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginStreamingLabel.Location = new System.Drawing.Point(9, 137);
            this.BeginStreamingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BeginStreamingLabel.Name = "BeginStreamingLabel";
            this.BeginStreamingLabel.Size = new System.Drawing.Size(18, 20);
            this.BeginStreamingLabel.TabIndex = 3;
            this.BeginStreamingLabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 207);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BeginStreamingLabel);
            this.Controls.Add(this.CreditChargedLabel);
            this.Controls.Add(this.TankLabel);
            this.Controls.Add(this.OKButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TankLabel;
        private System.Windows.Forms.Label CreditChargedLabel;
        private System.Windows.Forms.Label BeginStreamingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}