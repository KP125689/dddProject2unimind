namespace dddProject2
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.registertitle = new System.Windows.Forms.Label();
            this.usernametitle2 = new System.Windows.Forms.Label();
            this.FNtitle = new System.Windows.Forms.Label();
            this.LNtitle = new System.Windows.Forms.Label();
            this.Pwtitle = new System.Windows.Forms.Label();
            this.confpass = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.LNbox = new System.Windows.Forms.TextBox();
            this.FNbox = new System.Windows.Forms.TextBox();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.completeRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registertitle
            // 
            resources.ApplyResources(this.registertitle, "registertitle");
            this.registertitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registertitle.Name = "registertitle";
            // 
            // usernametitle2
            // 
            resources.ApplyResources(this.usernametitle2, "usernametitle2");
            this.usernametitle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernametitle2.Name = "usernametitle2";
            // 
            // FNtitle
            // 
            resources.ApplyResources(this.FNtitle, "FNtitle");
            this.FNtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FNtitle.Name = "FNtitle";
            this.FNtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNtitle
            // 
            resources.ApplyResources(this.LNtitle, "LNtitle");
            this.LNtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LNtitle.Name = "LNtitle";
            // 
            // Pwtitle
            // 
            resources.ApplyResources(this.Pwtitle, "Pwtitle");
            this.Pwtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pwtitle.Name = "Pwtitle";
            // 
            // confpass
            // 
            resources.ApplyResources(this.confpass, "confpass");
            this.confpass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confpass.Name = "confpass";
            this.confpass.Click += new System.EventHandler(this.confpass_Click);
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // LNbox
            // 
            resources.ApplyResources(this.LNbox, "LNbox");
            this.LNbox.Name = "LNbox";
            // 
            // FNbox
            // 
            resources.ApplyResources(this.FNbox, "FNbox");
            this.FNbox.Name = "FNbox";
            // 
            // Passwordbox
            // 
            resources.ApplyResources(this.Passwordbox, "Passwordbox");
            this.Passwordbox.Name = "Passwordbox";
            // 
            // ConfirmPasswordBox
            // 
            resources.ApplyResources(this.ConfirmPasswordBox, "ConfirmPasswordBox");
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            // 
            // completeRegister
            // 
            this.completeRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.completeRegister, "completeRegister");
            this.completeRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.completeRegister.Name = "completeRegister";
            this.completeRegister.UseVisualStyleBackColor = false;
            // 
            // RegisterPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.completeRegister);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.FNbox);
            this.Controls.Add(this.LNbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.Pwtitle);
            this.Controls.Add(this.LNtitle);
            this.Controls.Add(this.FNtitle);
            this.Controls.Add(this.usernametitle2);
            this.Controls.Add(this.registertitle);
            this.Name = "RegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registertitle;
        private System.Windows.Forms.Label usernametitle2;
        private System.Windows.Forms.Label FNtitle;
        private System.Windows.Forms.Label LNtitle;
        private System.Windows.Forms.Label Pwtitle;
        private System.Windows.Forms.Label confpass;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox LNbox;
        private System.Windows.Forms.TextBox FNbox;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.Button completeRegister;
    }
}