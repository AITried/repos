namespace Computer_Shop
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.RegLabel = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.Location = new System.Drawing.Point(30, 166);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(122, 26);
            this.LogButton.TabIndex = 0;
            this.LogButton.Text = "Войти";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.LogBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogBox.Location = new System.Drawing.Point(30, 87);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(120, 22);
            this.LogBox.TabIndex = 2;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            this.LogBox.Enter += new System.EventHandler(this.LogBox_Enter);
            this.LogBox.Leave += new System.EventHandler(this.LogBox_Leave);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(30, 115);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(120, 22);
            this.PassBox.TabIndex = 3;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.logLabel.Enabled = false;
            this.logLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(35, 90);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(41, 13);
            this.logLabel.TabIndex = 4;
            this.logLabel.Text = "Логин";
            this.logLabel.Click += new System.EventHandler(this.logLabel_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.passLabel.Enabled = false;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(35, 119);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(48, 13);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Пароль";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLabel.Location = new System.Drawing.Point(58, 40);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(71, 30);
            this.RegLabel.TabIndex = 6;
            this.RegLabel.Text = "Вход";
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rememberCheckBox.Location = new System.Drawing.Point(37, 143);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(115, 17);
            this.rememberCheckBox.TabIndex = 7;
            this.rememberCheckBox.Text = "Запоинить меня";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            this.rememberCheckBox.CheckedChanged += new System.EventHandler(this.rememberCheckBox_CheckedChanged);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downButton.Location = new System.Drawing.Point(122, 9);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(30, 28);
            this.downButton.TabIndex = 8;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(158, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 28);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(30, 198);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(122, 26);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Регистрация";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(195, 240);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.LogButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(195, 240);
            this.MinimumSize = new System.Drawing.Size(195, 240);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.CheckBox rememberCheckBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button regButton;
    }
}

