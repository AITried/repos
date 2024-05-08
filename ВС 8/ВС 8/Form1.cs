using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВС_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float target = 0;
        double signal = 0;//сигнал регулятора
        double Omega = 0;//угловая скорость мотора
        double om_k = 0;//мощность мотора
        double valve = 0;//угол поворота клапана
        double valve_k = 0;//передаточное чистого клапана
        double T_k = 0;//мощность котла
        double T = 0;//температура котла
        double fb = 0;//коэффициент обратной связи
        double T_prev = 0;
        double eps = 0;
        int steady_st = 0;
        int steady_x = 0;
        int oscil = 0;
        Graphics g_T;
        List<double> lst_Ts = new List<double>();
        int x = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g_T = pictureBox1.CreateGraphics();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            T = 0;
            progressBar1.Value = 0;
            g_T = pictureBox1.CreateGraphics();
            g_T.Clear(Color.Cyan);
            target = float.Parse(textBoxG.Text);
            float norm = target * 0.05f;
            g_T.DrawLine(new Pen(Brushes.Lavender), 0, 200 - target + norm, pictureBox1.Width, 200 - target + norm);
            g_T.DrawLine(new Pen(Brushes.Lavender), 0, 200 - target - norm, pictureBox1.Width, 200 - target - norm);
            signal = target;
            om_k = hScrollBar3.Value;
            Omega = 0;
            valve = 0;
            valve_k = hScrollBar1.Value;
            T_k = hScrollBar2.Value;
            fb = hScrollBar4.Value * 0.01;
            steady_st = 0;
            lst_Ts.Clear();
            oscil = 0;
            x = 0;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            groupBox2.Text = "Мотор управления клапаном " + hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            groupBox3.Text = "Топливный клапан " + hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            groupBox4.Text = "Котел " + hScrollBar3.Value.ToString();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            groupBox5.Text = "Обратная связь " + (hScrollBar4.Value * 0.01).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                double Td_prev = 0;
                Omega += (signal - Omega) * om_k * 0.19;//функция изменения скорости привода
                textBox2.Text = Omega.ToString();//температура
                valve += Omega * valve_k * 0.091;//функция положения клапана
                textBox3.Text = valve.ToString();//сигнал
                T += (valve - T) * T_k * (0.110 / 2);//функция температуры котла
                signal = target - (fb * T);//функция обратной связи
                textBox1.Text = signal.ToString();//положение
                try
                {
                    progressBar1.Value = (int)T;
                }
                catch { }
                textBox4.Text = T.ToString();
                lst_Ts.Add(T);
                Pen p = new Pen(Brushes.Black, 2);
                if (target > 0)
                {
                    g_T.DrawEllipse(p, x, (200 - (int)T), 2, 2);
                    x += 4;
                }
                if (steady_st != -1)
                {
                    if (Math.Abs(T - T_prev) < Math.Abs(T * 0.03))
                        steady_st++;
                    else
                        steady_st = 0;
                    if (steady_st > 15)
                    {
                        g_T.DrawLine(p, x, 0, x, 500);
                        steady_x = x;
                        steady_st = -1;
                        eps = T - target;
                        Td_prev = T;
                        foreach (double Td in lst_Ts)
                        {
                            if (Td > T && Td_prev < T)
                                oscil++;
                            Td_prev = Td;
                        }
                        textBox7.Text = (Math.Abs((Math.Round(((eps * 100) / target), 2)))).ToString() + "%";
                        textBox6.Text = (steady_x / 4).ToString() + " такт(ов)";
                        textBox5.Text = oscil.ToString() + " волн(ы)";
                    }
                }
                T_prev = T;
            }

        }
    }
}
