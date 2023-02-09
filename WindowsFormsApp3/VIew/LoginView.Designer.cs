namespace WindowsFormsApp3.VIew
{
    partial class LoginView
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernametxtBox = new System.Windows.Forms.TextBox();
            this.passwordtxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(22, 175);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(190, 38);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(22, 219);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(190, 38);
            this.registerbtn.TabIndex = 1;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(17, 31);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(116, 25);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "Username:";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(21, 107);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(112, 25);
            this.passwordlbl.TabIndex = 3;
            this.passwordlbl.Text = "Password:";
            this.passwordlbl.Click += new System.EventHandler(this.passwordlbl_Click);
            // 
            // usernametxtBox
            // 
            this.usernametxtBox.Location = new System.Drawing.Point(22, 68);
            this.usernametxtBox.Name = "usernametxtBox";
            this.usernametxtBox.Size = new System.Drawing.Size(190, 20);
            this.usernametxtBox.TabIndex = 4;
            this.usernametxtBox.TextChanged += new System.EventHandler(this.usernametxtBox_TextChanged);
            // 
            // passwordtxtBox
            // 
            this.passwordtxtBox.Location = new System.Drawing.Point(22, 135);
            this.passwordtxtBox.Name = "passwordtxtBox";
            this.passwordtxtBox.PasswordChar = '*';
            this.passwordtxtBox.Size = new System.Drawing.Size(190, 20);
            this.passwordtxtBox.TabIndex = 5;
            this.passwordtxtBox.TextChanged += new System.EventHandler(this.passwordtxtBox_TextChanged);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 276);
            this.Controls.Add(this.passwordtxtBox);
            this.Controls.Add(this.usernametxtBox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.loginbtn);
            this.Name = "LoginView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox usernametxtBox;
        private System.Windows.Forms.TextBox passwordtxtBox;
    }
}