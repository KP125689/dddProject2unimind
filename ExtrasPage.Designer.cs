namespace dddProject2
{
    partial class ExtrasPage
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
            this.ExtraTitle = new System.Windows.Forms.Label();
            this.JHbutton = new System.Windows.Forms.Button();
            this.SpeakToSomeoneButton = new System.Windows.Forms.Button();
            this.getSocialButton = new System.Windows.Forms.Button();
            this.EmergencyContactButton = new System.Windows.Forms.Button();
            this.MnMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExtraTitle
            // 
            this.ExtraTitle.AutoSize = true;
            this.ExtraTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ExtraTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtraTitle.Location = new System.Drawing.Point(121, 43);
            this.ExtraTitle.Name = "ExtraTitle";
            this.ExtraTitle.Size = new System.Drawing.Size(191, 58);
            this.ExtraTitle.TabIndex = 0;
            this.ExtraTitle.Text = "EXTRA";
            // 
            // JHbutton
            // 
            this.JHbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JHbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JHbutton.Location = new System.Drawing.Point(84, 131);
            this.JHbutton.Name = "JHbutton";
            this.JHbutton.Size = new System.Drawing.Size(252, 43);
            this.JHbutton.TabIndex = 1;
            this.JHbutton.Text = "Journal histoy";
            this.JHbutton.UseVisualStyleBackColor = false;
            this.JHbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpeakToSomeoneButton
            // 
            this.SpeakToSomeoneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpeakToSomeoneButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SpeakToSomeoneButton.Location = new System.Drawing.Point(83, 278);
            this.SpeakToSomeoneButton.Name = "SpeakToSomeoneButton";
            this.SpeakToSomeoneButton.Size = new System.Drawing.Size(252, 43);
            this.SpeakToSomeoneButton.TabIndex = 2;
            this.SpeakToSomeoneButton.Text = "speak to someone";
            this.SpeakToSomeoneButton.UseVisualStyleBackColor = false;
            // 
            // getSocialButton
            // 
            this.getSocialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getSocialButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.getSocialButton.Location = new System.Drawing.Point(84, 358);
            this.getSocialButton.Name = "getSocialButton";
            this.getSocialButton.Size = new System.Drawing.Size(252, 43);
            this.getSocialButton.TabIndex = 3;
            this.getSocialButton.Text = "Get Social";
            this.getSocialButton.UseVisualStyleBackColor = false;
            // 
            // EmergencyContactButton
            // 
            this.EmergencyContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmergencyContactButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmergencyContactButton.Location = new System.Drawing.Point(83, 445);
            this.EmergencyContactButton.Name = "EmergencyContactButton";
            this.EmergencyContactButton.Size = new System.Drawing.Size(252, 43);
            this.EmergencyContactButton.TabIndex = 4;
            this.EmergencyContactButton.Text = "Emergency Contact";
            this.EmergencyContactButton.UseVisualStyleBackColor = false;
            // 
            // MnMButton
            // 
            this.MnMButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MnMButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MnMButton.Location = new System.Drawing.Point(84, 203);
            this.MnMButton.Name = "MnMButton";
            this.MnMButton.Size = new System.Drawing.Size(252, 43);
            this.MnMButton.TabIndex = 5;
            this.MnMButton.Text = "Mindfullness";
            this.MnMButton.UseVisualStyleBackColor = false;
            // 
            // ExtrasPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(397, 586);
            this.Controls.Add(this.MnMButton);
            this.Controls.Add(this.EmergencyContactButton);
            this.Controls.Add(this.getSocialButton);
            this.Controls.Add(this.SpeakToSomeoneButton);
            this.Controls.Add(this.JHbutton);
            this.Controls.Add(this.ExtraTitle);
            this.Name = "ExtrasPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtrasPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExtraTitle;
        private System.Windows.Forms.Button JHbutton;
        private System.Windows.Forms.Button SpeakToSomeoneButton;
        private System.Windows.Forms.Button getSocialButton;
        private System.Windows.Forms.Button EmergencyContactButton;
        private System.Windows.Forms.Button MnMButton;
    }
}