namespace Computer_Shop
{
    partial class newGoodTypeForm
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
            this.goodTypeLabel = new System.Windows.Forms.Label();
            this.goodTypeBox = new System.Windows.Forms.TextBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.percentBox = new System.Windows.Forms.TextBox();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.techBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // goodTypeLabel
            // 
            this.goodTypeLabel.AutoSize = true;
            this.goodTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.goodTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.goodTypeLabel.Location = new System.Drawing.Point(12, 29);
            this.goodTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goodTypeLabel.Name = "goodTypeLabel";
            this.goodTypeLabel.Size = new System.Drawing.Size(66, 13);
            this.goodTypeLabel.TabIndex = 55;
            this.goodTypeLabel.Text = "Тип товара";
            // 
            // goodTypeBox
            // 
            this.goodTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.goodTypeBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.goodTypeBox.Location = new System.Drawing.Point(15, 45);
            this.goodTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goodTypeBox.Name = "goodTypeBox";
            this.goodTypeBox.Size = new System.Drawing.Size(117, 22);
            this.goodTypeBox.TabIndex = 51;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.percentLabel.Location = new System.Drawing.Point(141, 29);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(107, 13);
            this.percentLabel.TabIndex = 56;
            this.percentLabel.Text = "Процент накрутки";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(153, 73);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 27);
            this.addButton.TabIndex = 50;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // percentBox
            // 
            this.percentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.percentBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.percentBox.Location = new System.Drawing.Point(144, 45);
            this.percentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.percentBox.Name = "percentBox";
            this.percentBox.Size = new System.Drawing.Size(131, 22);
            this.percentBox.TabIndex = 53;
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(237, 8);
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
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(259, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 48;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // techBox
            // 
            this.techBox.AutoSize = true;
            this.techBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.techBox.Location = new System.Drawing.Point(15, 79);
            this.techBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.techBox.Name = "techBox";
            this.techBox.Size = new System.Drawing.Size(134, 17);
            this.techBox.TabIndex = 57;
            this.techBox.Text = "Тех. сложный товар";
            this.techBox.UseVisualStyleBackColor = true;
            // 
            // newGoodTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.techBox);
            this.Controls.Add(this.goodTypeLabel);
            this.Controls.Add(this.goodTypeBox);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.percentBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newGoodTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newGoodTypeForm";
            this.Load += new System.EventHandler(this.newGoodTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodTypeLabel;
        private System.Windows.Forms.TextBox goodTypeBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox percentBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox techBox;
    }
}