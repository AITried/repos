namespace Computer_Shop
{
    partial class newBreakForm
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
            this.masterIdLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.masterIdBox = new System.Windows.Forms.TextBox();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.canBeFixedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // masterIdLabel
            // 
            this.masterIdLabel.AutoSize = true;
            this.masterIdLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIdLabel.Location = new System.Drawing.Point(8, 38);
            this.masterIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.masterIdLabel.Name = "masterIdLabel";
            this.masterIdLabel.Size = new System.Drawing.Size(64, 13);
            this.masterIdLabel.TabIndex = 21;
            this.masterIdLabel.Text = "IDМастера";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(134, 38);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Дата";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(14, 68);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(55, 13);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "IDТовара";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(83, 93);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 34);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(71, 66);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(51, 22);
            this.idBox.TabIndex = 15;
            // 
            // masterIdBox
            // 
            this.masterIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.masterIdBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIdBox.Location = new System.Drawing.Point(71, 36);
            this.masterIdBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masterIdBox.Name = "masterIdBox";
            this.masterIdBox.Size = new System.Drawing.Size(51, 22);
            this.masterIdBox.TabIndex = 13;
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downButton.Location = new System.Drawing.Point(243, 8);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 12;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(265, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(170, 36);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker.TabIndex = 22;
            // 
            // canBeFixedCheckBox
            // 
            this.canBeFixedCheckBox.AutoSize = true;
            this.canBeFixedCheckBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canBeFixedCheckBox.Location = new System.Drawing.Point(150, 67);
            this.canBeFixedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canBeFixedCheckBox.Name = "canBeFixedCheckBox";
            this.canBeFixedCheckBox.Size = new System.Drawing.Size(133, 17);
            this.canBeFixedCheckBox.TabIndex = 23;
            this.canBeFixedCheckBox.Text = "Починка возможна";
            this.canBeFixedCheckBox.UseVisualStyleBackColor = true;
            // 
            // newBreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.canBeFixedCheckBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.masterIdLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.masterIdBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(292, 138);
            this.MinimumSize = new System.Drawing.Size(292, 138);
            this.Name = "newBreakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newBreakForm";
            this.Load += new System.EventHandler(this.newBreakForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masterIdLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox masterIdBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox canBeFixedCheckBox;
    }
}