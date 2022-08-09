using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class Best_Fit : Form
    {
        public Best_Fit()
        {
            InitializeComponent();
        }
        string[] sallocate;
        string[] sprocess;
        int[] allocate;
        int[] process;
        int i, j, pos, pos2, pos3, pos4, b = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, max = 0,max2=0;

        private void Best_Fit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        void input()
        {
            sallocate = new string[5];
            sprocess = new string[4];
            allocate = new int[5];
            process = new int[4];
            sallocate[0] = textBox1.Text;
            sallocate[1] = textBox2.Text;
            sallocate[2] = textBox3.Text;
            sallocate[3] = textBox4.Text;
            sallocate[4] = textBox5.Text;
            sprocess[0] = textBox6.Text;
            sprocess[1] = textBox7.Text;
            sprocess[2] = textBox8.Text;
            sprocess[3] = textBox9.Text;
            for (i = 0; i < 5; i++)
            {
                allocate[i] = Convert.ToInt32(sallocate[i]);
            }
            for (j = 0; j < 4; j++)
            {
                process[j] = Convert.ToInt32(sprocess[j]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            input();
            /////////////////1/////////////////
            for(i=0;i<5;i++)
            {
               if( allocate[i]>max)
                {
                    max = allocate[i];
                    pos = i;
                }
            }
            for(j=0;j<4;j++)
            {
                if(process[j]>max2)
                {
                    max2 = process[j];
                    pos2 = j;
                }
            }
            if(max>max2)
            {
                label6.Text = max2 + " is put in " + max;
                allocate[pos] -= process[pos2];
                process[pos2] = 0;
            }
            //////////////////////2///////////////////////
            pos = 0;
            pos2 = 0;
            max = 0;
            max2 = 0;
            for (i = 0; i < 5; i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos = i;
                }
            }
            for (j = 0; j < 4; j++)
            {
                if (process[j] > max2)
                {
                    max2 = process[j];
                    pos2 = j;
                }
            }
            if (max > max2)
            {
                label4.Text = max2 + " is put in " + max;
                allocate[pos] -= process[pos2];
                process[pos2] = 0;
            }
            /////////////////3/////////////////////
            pos = 0;
            pos2 = 0;
            max = 0;
            max2 = 0;
            for (i = 0; i < 5; i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos = i;
                }
            }
            for (j = 0; j < 4; j++)
            {
                if (process[j] > max2)
                {
                    max2 = process[j];
                    pos2 = j;
                }
            }
            if (max > max2)
            {
                label3.Text = max2 + " is put in " + max;
                allocate[pos] -= process[pos2];
                process[pos2] = 0;
            }
            //////////////////4/////////////////////
            pos = 0;
            pos2 = 0;
            max = 0;
            max2 = 0;
            for (i = 0; i < 5; i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos = i;
                }
            }
            for (j = 0; j < 4; j++)
            {
                if (process[j] > max2)
                {
                    max2 = process[j];
                    pos2 = j;
                }
            }
            if (max > max2)
            {
                label5.Text = max2 + " is put in " + max;
                allocate[pos] -= process[pos2];
                process[pos2] = 0;
            }
        }
    }
}
