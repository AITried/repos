namespace Computer_Shop
{
    partial class newRevisionForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idWorkerLabel = new System.Windows.Forms.Label();
            this.idWorkerBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(143, 32);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker.TabIndex = 57;
            // 
            // idWorkerLabel
            // 
            this.idWorkerLabel.AutoSize = true;
            this.idWorkerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.idWorkerLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idWorkerLabel.Location = new System.Drawing.Point(11, 17);
            this.idWorkerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idWorkerLabel.Name = "idWorkerLabel";
            this.idWorkerLabel.Size = new System.Drawing.Size(83, 13);
            this.idWorkerLabel.TabIndex = 55;
            this.idWorkerLabel.Text = "IDСотрудника";
            // 
            // idWorkerBox
            // 
            this.idWorkerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.idWorkerBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idWorkerBox.Location = new System.Drawing.Point(14, 32);
            this.idWorkerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idWorkerBox.Name = "idWorkerBox";
            this.idWorkerBox.Size = new System.Drawing.Size(117, 22);
            this.idWorkerBox.TabIndex = 51;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.moneyLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.moneyLabel.Location = new System.Drawing.Point(11, 57);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(64, 13);
            this.moneyLabel.TabIndex = 54;
            this.moneyLabel.Text = "Недостача";
            // 
            // moneyBox
            // 
            this.moneyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.moneyBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.moneyBox.Location = new System.Drawing.Point(14, 73);
            this.moneyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(117, 22);
            this.moneyBox.TabIndex = 52;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(142, 58);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 24);
            this.addButton.TabIndex = 50;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(234, 7);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 49;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(256, 7);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 48;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(141, 17);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 58;
            this.dateLabel.Text = "Дата";
            // 
            // newRevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(282, 108);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.idWorkerLabel);
            this.Controls.Add(this.idWorkerBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(282, 108);
            this.MinimumSize = new System.Drawing.Size(282, 108);
            this.Name = "newRevisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newRevisionForm";
            this.Load += new System.EventHandler(this.newRevisionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label idWorkerLabel;
        private System.Windows.Forms.TextBox idWorkerBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label dateLabel;
    }
}