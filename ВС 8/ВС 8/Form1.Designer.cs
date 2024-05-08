
namespace ВС_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkBox1 = new System.Windows.Forms.CheckBox();
            textBoxG = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            hScrollBar2 = new System.Windows.Forms.HScrollBar();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            hScrollBar3 = new System.Windows.Forms.HScrollBar();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            hScrollBar4 = new System.Windows.Forms.HScrollBar();
            groupBox6 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(66, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Вкл";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBoxG
            // 
            textBoxG.Location = new System.Drawing.Point(12, 180);
            textBoxG.Name = "textBoxG";
            textBoxG.Size = new System.Drawing.Size(207, 31);
            textBoxG.TabIndex = 1;
            textBoxG.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 152);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 25);
            label1.TabIndex = 2;
            label1.Text = "Уставка температуры %";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 217);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new System.Drawing.Point(329, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(157, 199);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Регулятор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Сигнал";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(144, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hScrollBar1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new System.Drawing.Point(492, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(280, 199);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мотор управления клапаном";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(6, 80);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(271, 38);
            hScrollBar1.TabIndex = 9;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Скорость";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 25);
            label3.TabIndex = 0;
            label3.Text = "Мощность";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(6, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(144, 31);
            textBox2.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(hScrollBar2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new System.Drawing.Point(778, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(280, 199);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Топливный клапан";
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new System.Drawing.Point(6, 80);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new System.Drawing.Size(271, 38);
            hScrollBar2.TabIndex = 10;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 134);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 25);
            label5.TabIndex = 7;
            label5.Text = "Положение";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 55);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 25);
            label6.TabIndex = 0;
            label6.Text = "Передача";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(6, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(144, 31);
            textBox3.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(hScrollBar3);
            groupBox4.Controls.Add(progressBar1);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new System.Drawing.Point(1064, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(280, 285);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Котёл";
            // 
            // hScrollBar3
            // 
            hScrollBar3.Location = new System.Drawing.Point(6, 80);
            hScrollBar3.Name = "hScrollBar3";
            hScrollBar3.Size = new System.Drawing.Size(271, 38);
            hScrollBar3.TabIndex = 10;
            hScrollBar3.Scroll += hScrollBar3_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(6, 202);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(268, 77);
            progressBar1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 134);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(118, 25);
            label7.TabIndex = 7;
            label7.Text = "Температура";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(99, 25);
            label8.TabIndex = 0;
            label8.Text = "Мощность";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(6, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(144, 31);
            textBox4.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(hScrollBar4);
            groupBox5.Location = new System.Drawing.Point(778, 214);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(280, 83);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Обратная связь";
            // 
            // hScrollBar4
            // 
            hScrollBar4.Location = new System.Drawing.Point(6, 39);
            hScrollBar4.Maximum = 200;
            hScrollBar4.Minimum = -200;
            hScrollBar4.Name = "hScrollBar4";
            hScrollBar4.Size = new System.Drawing.Size(271, 38);
            hScrollBar4.TabIndex = 10;
            hScrollBar4.Scroll += hScrollBar4_Scroll;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(textBox7);
            groupBox6.Controls.Add(textBox6);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Location = new System.Drawing.Point(1350, 15);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(209, 276);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Качество управления";
            groupBox6.Enter += groupBox6_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 38);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(78, 25);
            label11.TabIndex = 11;
            label11.Text = "Ошибка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 119);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(145, 25);
            label10.TabIndex = 10;
            label10.Text = "Быстродействие";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(7, 66);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(144, 31);
            textBox7.TabIndex = 10;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(7, 147);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(144, 31);
            textBox6.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 211);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(93, 25);
            label9.TabIndex = 1;
            label9.Text = "Затухание";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(6, 238);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(144, 31);
            textBox5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1547, 288);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1571, 627);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxG);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Система автоматического управления котла";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

