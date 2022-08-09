using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class C_Scan : Form
    {
        int j = 0;
        int[] N1 = new int[11];
        int[] N3 = new int[11];
        string[] N2 = new string[11];
        string[] N4 = new string[11];
        int min = 99999999;
        int pos = 0, pos2 = 0;
        int m = 0;
        int n;
        int total = 0;
        string stotal;
        string mintal;
        int mintal2;
        public C_Scan()
        {
            InitializeComponent();
        }

        private void C_Scan_Load(object sender, EventArgs e)
        {

        }
        void done()
        {
            mintal = textBox9.Text;
            mintal2 = Convert.ToInt32(mintal);
            N2[0] = textBox1.Text;
            N2[1] = textBox2.Text;
            N2[2] = textBox3.Text;
            N2[3] = textBox4.Text;
            N2[4] = textBox5.Text;
            N2[5] = textBox6.Text;
            N2[6] = textBox7.Text;
            N2[7] = textBox8.Text;
            N2[8] = textBox9.Text;
            N2[9] = "0";
            N2[10] = "199";
            for (int i = 0; i < 11; i++)
            {
                N1[i] = Convert.ToInt32(N2[j]);
                j++;
            }
            for (int j = 0; j < 11; j++)
            {
                for (int n = 0; n < 11; n++)
                {
                    if (N1[j] < min)
                    {
                        //  N3[0] = N1[n];
                        //  pos = n;
                        Array.Sort(N1);

                    }
                }
                // N1[pos] = 99999999;
            }

            for (int i = 0; i < 11; i++)
            {
                N4[i] = Convert.ToString(N1[m]);
                m++;
            }
            for (int i = 0; i < 11; i++)
            {
                if (N1[i] == mintal2)
                {
                    pos = i;
                }
            }
            for (int j = pos; j < 10; j++)
            {
                total += N1[j + 1] - N1[j];
            }
            total += 199 - 0;
            for (int i = 0; i < pos; i++)
            {
                total += N1[i + 1] - N1[i];
            }
            stotal = Convert.ToString(total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            done();
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw f2 = new Draw();
            f2.Show();
        }

        void output()
        {
            label3.Text = N4[0];
            label4.Text = N4[1];
            label5.Text = N4[2];
            label6.Text = N4[3];
            label7.Text = N4[4];
            label8.Text = N4[5];
            label9.Text = N4[6];
            label10.Text = N4[7];
            label11.Text = N4[8];
            label12.Text = N4[9];
            label13.Text = N4[10];
            label15.Text = stotal;

        }
    }
}
