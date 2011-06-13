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
            this.button_change = new System.Windows.Forms.Button();
            this.textBox_pword_suer = new System.Windows.Forms.TextBox();
            this.textBox_pword = new System.Windows.Forms.TextBox();
            this.textBox_newpword = new System.Windows.Forms.TextBox();
            this.textBox_newuname = new System.Windows.Forms.TextBox();
            this.label_pword = new System.Windows.Forms.Label();
            this.label_uname_suer = new System.Windows.Forms.Label();
            this.label_newpword = new System.Windows.Forms.Label();
            this.label_newuname = new System.Windows.Forms.Label();
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.label_uname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(70, 190);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 13;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // textBox_pword_suer
            // 
            this.textBox_pword_suer.Location = new System.Drawing.Point(98, 146);
            this.textBox_pword_suer.Name = "textBox_pword_suer";
            this.textBox_pword_suer.Size = new System.Drawing.Size(100, 21);
            this.textBox_pword_suer.TabIndex = 8;
            // 
            // textBox_pword
            // 
            this.textBox_pword.Location = new System.Drawing.Point(98, 80);
            this.textBox_pword.Name = "textBox_pword";
            this.textBox_pword.Size = new System.Drawing.Size(100, 21);
            this.textBox_pword.TabIndex = 12;
            // 
            // textBox_newpword
            // 
            this.textBox_newpword.Location = new System.Drawing.Point(98, 118);
            this.textBox_newpword.Name = "textBox_newpword";
            this.textBox_newpword.Size = new System.Drawing.Size(100, 21);
            this.textBox_newpword.TabIndex = 11;
            // 
            // textBox_newuname
            // 
            this.textBox_newuname.Location = new System.Drawing.Point(98, 38);
            this.textBox_newuname.Name = "textBox_newuname";
            this.textBox_newuname.Size = new System.Drawing.Size(100, 21);
            this.textBox_newuname.TabIndex = 10;
            // 
            // label_pword
            // 
            this.label_pword.AutoSize = true;
            this.label_pword.Location = new System.Drawing.Point(11, 83);
            this.label_pword.Name = "label_pword";
            this.label_pword.Size = new System.Drawing.Size(41, 12);
            this.label_pword.TabIndex = 7;
            this.label_pword.Text = "原密码";
            // 
            // label_uname_suer
            // 
            this.label_uname_suer.AutoSize = true;
            this.label_uname_suer.Location = new System.Drawing.Point(11, 155);
            this.label_uname_suer.Name = "label_uname_suer";
            this.label_uname_suer.Size = new System.Drawing.Size(53, 12);
            this.label_uname_suer.TabIndex = 3;
            this.label_uname_suer.Text = "确认密码";
            // 
            // label_newpword
            // 
            this.label_newpword.AutoSize = true;
            this.label_newpword.Location = new System.Drawing.Point(11, 127);
            this.label_newpword.Name = "label_newpword";
            this.label_newpword.Size = new System.Drawing.Size(41, 12);
            this.label_newpword.TabIndex = 6;
            this.label_newpword.Text = "新密码";
            // 
            // label_newuname
            // 
            this.label_newuname.AutoSize = true;
            this.label_newuname.Location = new System.Drawing.Point(11, 47);
            this.label_newuname.Name = "label_newuname";
            this.label_newuname.Size = new System.Drawing.Size(53, 12);
            this.label_newuname.TabIndex = 5;
            this.label_newuname.Text = "新用户名";
            // 
            // textBox_uname
            // 
            this.textBox_uname.Location = new System.Drawing.Point(98, 11);
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(100, 21);
            this.textBox_uname.TabIndex = 9;
            // 
            // label_uname
            // 
            this.label_uname.AutoSize = true;
            this.label_uname.Location = new System.Drawing.Point(11, 20);
            this.label_uname.Name = "label_uname";
            this.label_uname.Size = new System.Drawing.Size(53, 12);
            this.label_uname.TabIndex = 4;
            this.label_uname.Text = "原用户名";
            // 
            // ChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 227);
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
            this.Text = "ChangeInfo";
            this.Load += new System.EventHandler(this.ChangeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.TextBox textBox_pword_suer;
        private System.Windows.Forms.TextBox textBox_pword;
        private System.Windows.Forms.TextBox textBox_newpword;
        private System.Windows.Forms.TextBox textBox_newuname;
        private System.Windows.Forms.Label label_pword;
        private System.Windows.Forms.Label label_uname_suer;
        private System.Windows.Forms.Label label_newpword;
        private System.Windows.Forms.Label label_newuname;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.Label label_uname;
    }
}