namespace Parachuting_Competition
{
    partial class ChangeInfo
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
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.label_newuname = new System.Windows.Forms.Label();
            this.textBox_newuname = new System.Windows.Forms.TextBox();
            this.label_newpword = new System.Windows.Forms.Label();
            this.textBox_newpword = new System.Windows.Forms.TextBox();
            this.label_uname_suer = new System.Windows.Forms.Label();
            this.textBox_pword_suer = new System.Windows.Forms.TextBox();
            this.label_pword = new System.Windows.Forms.Label();
            this.textBox_pword = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_uname
            // 
            this.label_uname.AutoSize = true;
            this.label_uname.Location = new System.Drawing.Point(47, 40);
            this.label_uname.Name = "label_uname";
            this.label_uname.Size = new System.Drawing.Size(53, 12);
            this.label_uname.TabIndex = 0;
            this.label_uname.Text = "原用户名";
            // 
            // textBox_uname
            // 
            this.textBox_uname.Location = new System.Drawing.Point(134, 31);
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(100, 21);
            this.textBox_uname.TabIndex = 1;
            // 
            // label_newuname
            // 
            this.label_newuname.AutoSize = true;
            this.label_newuname.Location = new System.Drawing.Point(47, 67);
            this.label_newuname.Name = "label_newuname";
            this.label_newuname.Size = new System.Drawing.Size(53, 12);
            this.label_newuname.TabIndex = 0;
            this.label_newuname.Text = "新用户名";
            // 
            // textBox_newuname
            // 
            this.textBox_newuname.Location = new System.Drawing.Point(134, 58);
            this.textBox_newuname.Name = "textBox_newuname";
            this.textBox_newuname.Size = new System.Drawing.Size(100, 21);
            this.textBox_newuname.TabIndex = 1;
            // 
            // label_newpword
            // 
            this.label_newpword.AutoSize = true;
            this.label_newpword.Location = new System.Drawing.Point(47, 147);
            this.label_newpword.Name = "label_newpword";
            this.label_newpword.Size = new System.Drawing.Size(41, 12);
            this.label_newpword.TabIndex = 0;
            this.label_newpword.Text = "新密码";
            // 
            // textBox_newpword
            // 
            this.textBox_newpword.Location = new System.Drawing.Point(134, 138);
            this.textBox_newpword.Name = "textBox_newpword";
            this.textBox_newpword.Size = new System.Drawing.Size(100, 21);
            this.textBox_newpword.TabIndex = 1;
            // 
            // label_uname_suer
            // 
            this.label_uname_suer.AutoSize = true;
            this.label_uname_suer.Location = new System.Drawing.Point(47, 175);
            this.label_uname_suer.Name = "label_uname_suer";
            this.label_uname_suer.Size = new System.Drawing.Size(53, 12);
            this.label_uname_suer.TabIndex = 0;
            this.label_uname_suer.Text = "确认密码";
            // 
            // textBox_pword_suer
            // 
            this.textBox_pword_suer.Location = new System.Drawing.Point(134, 166);
            this.textBox_pword_suer.Name = "textBox_pword_suer";
            this.textBox_pword_suer.Size = new System.Drawing.Size(100, 21);
            this.textBox_pword_suer.TabIndex = 1;
            // 
            // label_pword
            // 
            this.label_pword.AutoSize = true;
            this.label_pword.Location = new System.Drawing.Point(47, 103);
            this.label_pword.Name = "label_pword";
            this.label_pword.Size = new System.Drawing.Size(41, 12);
            this.label_pword.TabIndex = 0;
            this.label_pword.Text = "原密码";
            // 
            // textBox_pword
            // 
            this.textBox_pword.Location = new System.Drawing.Point(134, 100);
            this.textBox_pword.Name = "textBox_pword";
            this.textBox_pword.Size = new System.Drawing.Size(100, 21);
            this.textBox_pword.TabIndex = 1;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(106, 210);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 2;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // ChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_pword_suer);
            this.Controls.Add(this.textBox_pword);
            this.Controls.Add(this.textBox_newpword);
            this.Controls.Add(this.textBox_newuname);
            this.Controls.Add(this.label_pword);
            this.Controls.Add(this.label_uname_suer);
            this.Controls.Add(this.label_newpword);
            this.Controls.Add(this.label_newuname);
            this.Controls.Add(this.textBox_uname);
            this.Controls.Add(this.label_uname);
            this.Name = "ChangeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_uname;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.Label label_newuname;
        private System.Windows.Forms.TextBox textBox_newuname;
        private System.Windows.Forms.Label label_newpword;
        private System.Windows.Forms.TextBox textBox_newpword;
        private System.Windows.Forms.Label label_uname_suer;
        private System.Windows.Forms.TextBox textBox_pword_suer;
        private System.Windows.Forms.Label label_pword;
        private System.Windows.Forms.TextBox textBox_pword;
        private System.Windows.Forms.Button button_change;
    }
}