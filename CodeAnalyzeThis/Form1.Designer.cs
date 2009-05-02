namespace CodeAnalyzeThis
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
            this.disableButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(12, 12);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 0;
            this.disableButton.Text = "Disable CA";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(93, 12);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 0;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 47);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.disableButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button restoreButton;

    }
}