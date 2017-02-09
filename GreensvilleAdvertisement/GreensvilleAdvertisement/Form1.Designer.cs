namespace GreensvilleAdvertisement
{
    partial class GVAForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.spectateCB = new System.Windows.Forms.CheckBox();
            this.competeCB = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(283, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Greenville Idol\r\nTalent Competition and Showcase\r\n\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spectateCB
            // 
            this.spectateCB.AutoSize = true;
            this.spectateCB.Location = new System.Drawing.Point(100, 82);
            this.spectateCB.Name = "spectateCB";
            this.spectateCB.Size = new System.Drawing.Size(110, 17);
            this.spectateCB.TabIndex = 1;
            this.spectateCB.Text = "I\'d Like to Watch!";
            this.spectateCB.UseVisualStyleBackColor = true;
            // 
            // competeCB
            // 
            this.competeCB.AutoSize = true;
            this.competeCB.Location = new System.Drawing.Point(100, 126);
            this.competeCB.Name = "competeCB";
            this.competeCB.Size = new System.Drawing.Size(120, 17);
            this.competeCB.TabIndex = 2;
            this.competeCB.Text = "I\'d Like to Compete!";
            this.competeCB.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(117, 170);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel.Location = new System.Drawing.Point(7, 225);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 4;
            // 
            // GVAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.competeCB);
            this.Controls.Add(this.spectateCB);
            this.Controls.Add(this.titleLabel);
            this.Name = "GVAForm";
            this.Text = "Greenville Idol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox spectateCB;
        private System.Windows.Forms.CheckBox competeCB;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

