namespace Parachuting_Competition
{
    partial class AddAthlete
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Bearer = new System.Windows.Forms.ComboBox();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Team = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label_Bearer = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Team = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(209, 176);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 23;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(79, 176);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 22;
            this.button_Add.Text = "确定";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_Bearer
            // 
            this.comboBox_Bearer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bearer.FormattingEnabled = true;
            this.comboBox_Bearer.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox_Bearer.Location = new System.Drawing.Point(59, 129);
            this.comboBox_Bearer.Name = "comboBox_Bearer";
            this.comboBox_Bearer.Size = new System.Drawing.Size(100, 20);
            this.comboBox_Bearer.TabIndex = 20;
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_Sex.Location = new System.Drawing.Point(237, 50);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(100, 20);
            this.comboBox_Sex.TabIndex = 21;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(59, 91);
            this.textBox_Age.MaxLength = 2;
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(100, 21);
            this.textBox_Age.TabIndex = 17;
            this.textBox_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Age_KeyPress);
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(237, 91);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(100, 21);
            this.textBox_Country.TabIndex = 16;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(59, 49);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 19;
            // 
            // textBox_Team
            // 
            this.textBox_Team.Location = new System.Drawing.Point(237, 11);
            this.textBox_Team.Name = "textBox_Team";
            this.textBox_Team.Size = new System.Drawing.Size(100, 21);
            this.textBox_Team.TabIndex = 18;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(59, 11);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(100, 21);
            this.textBox_Number.TabIndex = 15;
            this.textBox_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
           
            // 
            // label_Bearer
            // 
            this.label_Bearer.AutoSize = true;
            this.label_Bearer.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Bearer.Location = new System.Drawing.Point(6, 130);
            this.label_Bearer.Name = "label_Bearer";
            this.label_Bearer.Size = new System.Drawing.Size(47, 19);
            this.label_Bearer.TabIndex = 11;
            this.label_Bearer.Text = "记名";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_country.Location = new System.Drawing.Point(184, 93);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(47, 19);
            this.label_country.TabIndex = 10;
            this.label_country.Text = "国家";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_age.Location = new System.Drawing.Point(6, 93);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(47, 19);
            this.label_age.TabIndex = 12;
            this.label_age.Text = "年龄";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Sex.Location = new System.Drawing.Point(184, 51);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(47, 19);
            this.label_Sex.TabIndex = 14;
            this.label_Sex.Text = "性别";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name.Location = new System.Drawing.Point(6, 51);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(47, 19);
            this.label_Name.TabIndex = 13;
            this.label_Name.Text = "姓名";
            // 
            // label_Team
            // 
            this.label_Team.AutoSize = true;
            this.label_Team.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Team.Location = new System.Drawing.Point(184, 11);
            this.label_Team.Name = "label_Team";
            this.label_Team.Size = new System.Drawing.Size(47, 19);
            this.label_Team.TabIndex = 9;
            this.label_Team.Text = "队别";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Number.Location = new System.Drawing.Point(6, 11);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(47, 19);
            this.label_Number.TabIndex = 8;
            this.label_Number.Text = "编号";
            // 
            // AddAthlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 224);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Bearer);
            this.Controls.Add(this.comboBox_Sex);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Team);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label_Bearer);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Team);
            this.Controls.Add(this.label_Number);
            this.MaximizeBox = false;
            this.Name = "AddAthlete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_Bearer;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Team;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label_Bearer;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Team;
        private System.Windows.Forms.Label label_Number;
    }
}