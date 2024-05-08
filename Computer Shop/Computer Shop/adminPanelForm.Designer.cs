namespace Computer_Shop
{
    partial class adminPanelForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nowTableBox = new System.Windows.Forms.ComboBox();
            this.nowTableLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateViewButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.Button();
            this.supportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userBox);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(170, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пользователя";
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.userBox.Location = new System.Drawing.Point(74, 42);
            this.userBox.Margin = new System.Windows.Forms.Padding(2);
            this.userBox.Name = "userBox";
            this.userBox.ReadOnly = true;
            this.userBox.Size = new System.Drawing.Size(89, 22);
            this.userBox.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(7, 45);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(69, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Должность";
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.surnameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.surnameBox.Location = new System.Drawing.Point(74, 21);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.ReadOnly = true;
            this.surnameBox.Size = new System.Drawing.Size(89, 22);
            this.surnameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(503, 81);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(110, 27);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(8, 117);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(605, 174);
            this.dataGridView.TabIndex = 2;
            // 
            // nowTableBox
            // 
            this.nowTableBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.nowTableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nowTableBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nowTableBox.FormattingEnabled = true;
            this.nowTableBox.Items.AddRange(new object[] {
            "Сотрудники",
            "Поставщики",
            "Заказы",
            "Отмены",
            "Поломки",
            "Поставки",
            "Ревизии",
            "ТипыТоваров",
            "Товары"});
            this.nowTableBox.Location = new System.Drawing.Point(11, 92);
            this.nowTableBox.Margin = new System.Windows.Forms.Padding(2);
            this.nowTableBox.Name = "nowTableBox";
            this.nowTableBox.Size = new System.Drawing.Size(108, 21);
            this.nowTableBox.TabIndex = 3;
            this.nowTableBox.SelectedIndexChanged += new System.EventHandler(this.nowTableBox_SelectedIndexChanged);
            // 
            // nowTableLabel
            // 
            this.nowTableLabel.AutoSize = true;
            this.nowTableLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nowTableLabel.Location = new System.Drawing.Point(8, 77);
            this.nowTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nowTableLabel.Name = "nowTableLabel";
            this.nowTableLabel.Size = new System.Drawing.Size(103, 13);
            this.nowTableLabel.TabIndex = 4;
            this.nowTableLabel.Text = "Текущая таблица:";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.Location = new System.Drawing.Point(592, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.Location = new System.Drawing.Point(570, 8);
            this.downButton.Margin = new System.Windows.Forms.Padding(2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 6;
            this.downButton.Text = "_";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(503, 50);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 27);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(389, 81);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 27);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateViewButton
            // 
            this.updateViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.updateViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateViewButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateViewButton.Location = new System.Drawing.Point(389, 50);
            this.updateViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateViewButton.Name = "updateViewButton";
            this.updateViewButton.Size = new System.Drawing.Size(110, 27);
            this.updateViewButton.TabIndex = 11;
            this.updateViewButton.Text = "Обновить";
            this.updateViewButton.UseVisualStyleBackColor = false;
            this.updateViewButton.Click += new System.EventHandler(this.updateViewButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(300, 85);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(195, 71);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(43, 13);
            this.searchLabel.TabIndex = 26;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(198, 85);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(99, 22);
            this.searchBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "Панель управления";
            // 
            // wordButton
            // 
            this.wordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.wordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordButton.Location = new System.Drawing.Point(447, 8);
            this.wordButton.Margin = new System.Windows.Forms.Padding(2);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(110, 22);
            this.wordButton.TabIndex = 29;
            this.wordButton.Text = "Отчёт";
            this.wordButton.UseVisualStyleBackColor = false;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // supportButton
            // 
            this.supportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supportButton.Location = new System.Drawing.Point(253, 32);
            this.supportButton.Margin = new System.Windows.Forms.Padding(2);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(103, 22);
            this.supportButton.TabIndex = 45;
            this.supportButton.Text = "Справка";
            this.supportButton.UseVisualStyleBackColor = false;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // adminPanelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(621, 293);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.updateViewButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nowTableLabel);
            this.Controls.Add(this.nowTableBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(621, 293);
            this.MinimumSize = new System.Drawing.Size(621, 293);
            this.Name = "adminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пагнль управления";
            this.Load += new System.EventHandler(this.adminPanelForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox nowTableBox;
        private System.Windows.Forms.Label nowTableLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button updateViewButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button supportButton;
    }
}