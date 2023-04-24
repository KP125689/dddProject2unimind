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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logintitle.Location = new System.Drawing.Point(110, 51);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(418, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.logintitle);
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logintitle;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label label1;
    }
}