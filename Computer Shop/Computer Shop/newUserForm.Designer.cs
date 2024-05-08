namespace Computer_Shop
{
    partial class newUserForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.userPassBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.userAddBox = new System.Windows.Forms.ComboBox();
            this.userFatherNameBox = new System.Windows.Forms.TextBox();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.userSurnameBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.userPhoneBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(61, 184);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userPassBox
            // 
            this.userPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userPassBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userPassBox.Location = new System.Drawing.Point(122, 128);
            this.userPassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPassBox.Name = "userPassBox";
            this.userPassBox.Size = new System.Drawing.Size(93, 22);
            this.userPassBox.TabIndex = 6;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.passLabel.Location = new System.Drawing.Point(121, 112);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(48, 13);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Пароль";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.logLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.logLabel.Location = new System.Drawing.Point(121, 69);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(41, 13);
            this.logLabel.TabIndex = 3;
            this.logLabel.Text = "Логин";
            // 
            // userLoginBox
            // 
            this.userLoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userLoginBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userLoginBox.Location = new System.Drawing.Point(122, 85);
            this.userLoginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(93, 22);
            this.userLoginBox.TabIndex = 5;
            // 
            // userAddBox
            // 
            this.userAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userAddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAddBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userAddBox.FormattingEnabled = true;
            this.userAddBox.Items.AddRange(new object[] {
            "Админ",
            "Продавец",
            "Техник"});
            this.userAddBox.Location = new System.Drawing.Point(81, 159);
            this.userAddBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userAddBox.Name = "userAddBox";
            this.userAddBox.Size = new System.Drawing.Size(115, 21);
            this.userAddBox.TabIndex = 6;
            // 
            // userFatherNameBox
            // 
            this.userFatherNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userFatherNameBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userFatherNameBox.Location = new System.Drawing.Point(15, 85);
            this.userFatherNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userFatherNameBox.Name = "userFatherNameBox";
            this.userFatherNameBox.Size = new System.Drawing.Size(93, 22);
            this.userFatherNameBox.TabIndex = 2;
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.fatherNameLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.fatherNameLabel.Location = new System.Drawing.Point(12, 69);
            this.fatherNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(56, 13);
            this.fatherNameLabel.TabIndex = 7;
            this.fatherNameLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.surnameLabel.Location = new System.Drawing.Point(15, 112);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(58, 13);
            this.surnameLabel.TabIndex = 8;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(12, 27);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(31, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Имя";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(121, 27);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Телефон";
            // 
            // userSurnameBox
            // 
            this.userSurnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userSurnameBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userSurnameBox.Location = new System.Drawing.Point(15, 128);
            this.userSurnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userSurnameBox.Name = "userSurnameBox";
            this.userSurnameBox.Size = new System.Drawing.Size(93, 22);
            this.userSurnameBox.TabIndex = 3;
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userNameBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userNameBox.Location = new System.Drawing.Point(15, 42);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(93, 22);
            this.userNameBox.TabIndex = 1;
            // 
            // userPhoneBox
            // 
            this.userPhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userPhoneBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userPhoneBox.Location = new System.Drawing.Point(122, 42);
            this.userPhoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPhoneBox.Name = "userPhoneBox";
            this.userPhoneBox.Size = new System.Drawing.Size(93, 22);
            this.userPhoneBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Должность";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(202, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(180, 8);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 16;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // newUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(231, 227);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.userFatherNameBox);
            this.Controls.Add(this.userAddBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userPassBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userSurnameBox);
            this.Controls.Add(this.userLoginBox);
            this.Controls.Add(this.userPhoneBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(231, 227);
            this.MinimumSize = new System.Drawing.Size(231, 227);
            this.Name = "newUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.newUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox userPassBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox userLoginBox;
        private System.Windows.Forms.ComboBox userAddBox;
        private System.Windows.Forms.TextBox userFatherNameBox;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox userSurnameBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userPhoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button downButton;
    }
}