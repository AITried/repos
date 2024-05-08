namespace Computer_Shop
{
    partial class newOrderForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(11, 100);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(55, 13);
            this.idLabel.TabIndex = 29;
            this.idLabel.Text = "IDТовара";
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(187, 10);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 33;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(209, 10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 32;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(119, 100);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 13);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Телефон";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.adressLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.adressLabel.Location = new System.Drawing.Point(41, 21);
            this.adressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(92, 13);
            this.adressLabel.TabIndex = 28;
            this.adressLabel.Text = "Адрес доставки";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.surnameLabel.Location = new System.Drawing.Point(11, 140);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(58, 13);
            this.surnameLabel.TabIndex = 27;
            this.surnameLabel.Text = "Фамилия";
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.surnameBox.Location = new System.Drawing.Point(11, 155);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(93, 22);
            this.surnameBox.TabIndex = 19;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(115, 146);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 37);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // adressBox
            // 
            this.adressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.adressBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.adressBox.Location = new System.Drawing.Point(43, 36);
            this.adressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(151, 22);
            this.adressBox.TabIndex = 21;
            this.adressBox.TextChanged += new System.EventHandler(this.adressBox_TextChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.phoneBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.phoneBox.Location = new System.Drawing.Point(122, 116);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(108, 22);
            this.phoneBox.TabIndex = 24;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(69, 71);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.dateTimePicker.TabIndex = 34;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idBox.Location = new System.Drawing.Point(11, 116);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(93, 22);
            this.idBox.TabIndex = 18;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.dateLabel.Enabled = false;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(35, 75);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "Дата";
            // 
            // newOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(239, 197);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.phoneBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(239, 197);
            this.MinimumSize = new System.Drawing.Size(239, 197);
            this.Name = "newOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newOrderForm";
            this.Load += new System.EventHandler(this.newOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label dateLabel;
    }
}