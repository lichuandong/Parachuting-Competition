namespace Parachuting_Competition
{
    partial class Login
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
            this.label_uname = new System.Windows.Forms.Label();
            this.label_pword = new System.Windows.Forms.Label();
            this.textBox_pword = new System.Windows.Forms.TextBox();
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_uname
            // 
            this.label_uname.AutoSize = true;
            this.label_uname.Location = new System.Drawing.Point(38, 33);
            this.label_uname.Name = "label_uname";
            this.label_uname.Size = new System.Drawing.Size(41, 12);
            this.label_uname.TabIndex = 0;
            this.label_uname.Text = "用户名";
            // 
            // label_pword
            // 
            this.label_pword.AutoSize = true;
            this.label_pword.Location = new System.Drawing.Point(38, 79);
            this.label_pword.Name = "label_pword";
            this.label_pword.Size = new System.Drawing.Size(29, 12);
            this.label_pword.TabIndex = 0;
            this.label_pword.Text = "密码";
            // 
            // textBox_pword
            // 
            this.textBox_pword.Location = new System.Drawing.Point(95, 76);
            this.textBox_pword.Name = "textBox_pword";
            this.textBox_pword.Size = new System.Drawing.Size(100, 21);
            this.textBox_pword.TabIndex = 1;
            // 
            // textBox_uname
            // 
            this.textBox_uname.Location = new System.Drawing.Point(95, 30);
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(100, 21);
            this.textBox_uname.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(40, 148);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "登陆";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(154, 148);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 3;
            this.button_change.Text = "修改密码";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 193);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_uname);
            this.Controls.Add(this.textBox_pword);
            this.Controls.Add(this.label_pword);
            this.Controls.Add(this.label_uname);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_uname;
        private System.Windows.Forms.Label label_pword;
        private System.Windows.Forms.TextBox textBox_pword;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_change;
    }
}