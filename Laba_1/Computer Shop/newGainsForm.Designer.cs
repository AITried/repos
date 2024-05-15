namespace Computer_Shop
{
    partial class newGainsForm
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
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idGoodLabel = new System.Windows.Forms.Label();
            this.idGoodBox = new System.Windows.Forms.TextBox();
            this.countlabel = new System.Windows.Forms.Label();
            this.idGiverLabel = new System.Windows.Forms.Label();
            this.idGiverBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(235, 8);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 14;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(257, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.dateLabel.Enabled = false;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(152, 76);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 47;
            this.dateLabel.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(155, 91);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker.TabIndex = 46;
            // 
            // idGoodLabel
            // 
            this.idGoodLabel.AutoSize = true;
            this.idGoodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.idGoodLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idGoodLabel.Location = new System.Drawing.Point(14, 31);
            this.idGoodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idGoodLabel.Name = "idGoodLabel";
            this.idGoodLabel.Size = new System.Drawing.Size(55, 13);
            this.idGoodLabel.TabIndex = 44;
            this.idGoodLabel.Text = "IDТовара";
            // 
            // idGoodBox
            // 
            this.idGoodBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.idGoodBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idGoodBox.Location = new System.Drawing.Point(17, 46);
            this.idGoodBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idGoodBox.Name = "idGoodBox";
            this.idGoodBox.Size = new System.Drawing.Size(117, 22);
            this.idGoodBox.TabIndex = 38;
            this.idGoodBox.TextChanged += new System.EventHandler(this.idGoodBox_TextChanged);
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.countlabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.countlabel.Location = new System.Drawing.Point(155, 31);
            this.countlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(71, 13);
            this.countlabel.TabIndex = 45;
            this.countlabel.Text = "Количество";
            // 
            // idGiverLabel
            // 
            this.idGiverLabel.AutoSize = true;
            this.idGiverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.idGiverLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idGiverLabel.Location = new System.Drawing.Point(14, 77);
            this.idGiverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idGiverLabel.Name = "idGiverLabel";
            this.idGiverLabel.Size = new System.Drawing.Size(84, 13);
            this.idGiverLabel.TabIndex = 42;
            this.idGiverLabel.Text = "IDПоставщика";
            // 
            // idGiverBox
            // 
            this.idGiverBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.idGiverBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.idGiverBox.Location = new System.Drawing.Point(17, 91);
            this.idGiverBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idGiverBox.Name = "idGiverBox";
            this.idGiverBox.Size = new System.Drawing.Size(117, 22);
            this.idGiverBox.TabIndex = 39;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(75, 127);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 27);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countBox
            // 
            this.countBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.countBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.countBox.Location = new System.Drawing.Point(155, 46);
            this.countBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(108, 22);
            this.countBox.TabIndex = 41;
            // 
            // newGainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(281, 165);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.idGoodLabel);
            this.Controls.Add(this.idGoodBox);
            this.Controls.Add(this.countlabel);
            this.Controls.Add(this.idGiverLabel);
            this.Controls.Add(this.idGiverBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(281, 165);
            this.MinimumSize = new System.Drawing.Size(281, 165);
            this.Name = "newGainsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newGainsForm";
            this.Load += new System.EventHandler(this.newGainsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label idGoodLabel;
        private System.Windows.Forms.TextBox idGoodBox;
        private System.Windows.Forms.Label countlabel;
        private System.Windows.Forms.Label idGiverLabel;
        private System.Windows.Forms.TextBox idGiverBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox countBox;
    }
}