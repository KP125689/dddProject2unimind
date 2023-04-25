namespace dddProject2
{
    partial class LoginPage
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
            this.logintitle = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbutton2 = new System.Windows.Forms.Button();
            this.gobackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logintitle.Location = new System.Drawing.Point(132, 43);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(167, 58);
            this.logintitle.TabIndex = 0;
            this.logintitle.Text = "Log in";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamelabel.Location = new System.Drawing.Point(12, 193);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(124, 29);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernametextbox.Location = new System.Drawing.Point(142, 196);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(252, 26);
            this.usernametextbox.TabIndex = 2;
            this.usernametextbox.TextChanged += new System.EventHandler(this.usernametextbox_TextChanged);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordlabel.Location = new System.Drawing.Point(12, 317);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(120, 29);
            this.passwordlabel.TabIndex = 3;
            this.passwordlabel.Text = "Password";
            // 
            // passwordbox
            // 
            this.passwordbox.CausesValidation = false;
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordbox.Location = new System.Drawing.Point(142, 317);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(252, 26);
            this.passwordbox.TabIndex = 4;
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            // 
            // loginbutton2
            // 
            this.loginbutton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginbutton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginbutton2.Location = new System.Drawing.Point(76, 398);
            this.loginbutton2.Name = "loginbutton2";
            this.loginbutton2.Size = new System.Drawing.Size(269, 43);
            this.loginbutton2.TabIndex = 5;
            this.loginbutton2.Text = "Log In";
            this.loginbutton2.UseVisualStyleBackColor = false;
            this.loginbutton2.Click += new System.EventHandler(this.loginbutton2_Click);
            // 
            // gobackbutton
            // 
            this.gobackbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gobackbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gobackbutton.Location = new System.Drawing.Point(151, 506);
            this.gobackbutton.Name = "gobackbutton";
            this.gobackbutton.Size = new System.Drawing.Size(115, 34);
            this.gobackbutton.TabIndex = 6;
            this.gobackbutton.Text = "Go back ";
            this.gobackbutton.UseVisualStyleBackColor = false;
            this.gobackbutton.Click += new System.EventHandler(this.gobackbutton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(418, 602);
            this.Controls.Add(this.gobackbutton);
            this.Controls.Add(this.loginbutton2);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.logintitle);
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button loginbutton2;
        private System.Windows.Forms.Button gobackbutton;
    }
}