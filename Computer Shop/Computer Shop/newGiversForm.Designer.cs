namespace Computer_Shop
{
    partial class newGiversForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.companyPhoneBox = new System.Windows.Forms.TextBox();
            this.companyAdressBox = new System.Windows.Forms.TextBox();
            this.companyPostBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.adressLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(255, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.downButton.Location = new System.Drawing.Point(233, 8);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(18, 18);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // companyNameBox
            // 
            this.companyNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.companyNameBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.companyNameBox.Location = new System.Drawing.Point(9, 42);
            this.companyNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(125, 22);
            this.companyNameBox.TabIndex = 2;
            // 
            // companyPhoneBox
            // 
            this.companyPhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.companyPhoneBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.companyPhoneBox.Location = new System.Drawing.Point(147, 85);
            this.companyPhoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyPhoneBox.Name = "companyPhoneBox";
            this.companyPhoneBox.Size = new System.Drawing.Size(127, 22);
            this.companyPhoneBox.TabIndex = 3;
            // 
            // companyAdressBox
            // 
            this.companyAdressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.companyAdressBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.companyAdressBox.Location = new System.Drawing.Point(9, 85);
            this.companyAdressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyAdressBox.Name = "companyAdressBox";
            this.companyAdressBox.Size = new System.Drawing.Size(125, 22);
            this.companyAdressBox.TabIndex = 4;
            // 
            // companyPostBox
            // 
            this.companyPostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.companyPostBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.companyPostBox.Location = new System.Drawing.Point(147, 42);
            this.companyPostBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyPostBox.Name = "companyPostBox";
            this.companyPostBox.Size = new System.Drawing.Size(127, 22);
            this.companyPostBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(115)))), ((int)(((byte)(48)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(80, 116);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 25);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.adressLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.adressLabel.Location = new System.Drawing.Point(8, 70);
            this.adressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(40, 13);
            this.adressLabel.TabIndex = 7;
            this.adressLabel.Text = "Адрес";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.postLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.postLabel.Location = new System.Drawing.Point(145, 27);
            this.postLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(60, 13);
            this.postLabel.TabIndex = 8;
            this.postLabel.Text = "Эл. Почта";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(145, 70);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Номер";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(8, 27);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Название";
            // 
            // newGiversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.companyPostBox);
            this.Controls.Add(this.companyAdressBox);
            this.Controls.Add(this.companyPhoneBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(288, 152);
            this.MinimumSize = new System.Drawing.Size(288, 152);
            this.Name = "newGiversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newGiversForm";
            this.Load += new System.EventHandler(this.newGiversForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox companyPhoneBox;
        private System.Windows.Forms.TextBox companyAdressBox;
        private System.Windows.Forms.TextBox companyPostBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}