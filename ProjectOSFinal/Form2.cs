using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] sallocate;
        string[] sprocess;
        int[] allocate;
        int[] process;
        int i, j, pos, pos2,pos3,pos4, b = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0,max=0;

        private void button2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
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
            
            ///////////////////1//////////////////////////
            for(i=0;i<5;i++)
            {
                if(allocate[i] > max)
                {
                    max = allocate[i];
                    pos = i;
                }
            }
            for(i=0;i<5;i++)
            {
                if(max>process[0])
                {
                    label3.Text = process[0] + " is put in " + max;
                    b++;
                }
            }
            if(b==0)
            {
                label3.Text = process[0] + " must wait";
            }
            else
            {
                allocate[pos] -= process[0];
            }
            ///////////////////////////2/////////////////////
            max = 0;
            for(i=0;i<5;i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos2 = i;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (max > process[1])
                {
                    label4.Text = process[1] + " is put in " + max;
                    b1++;
                }
            }
            if (b1 == 0)
            {
                label4.Text = process[1] + " must wait";
            }
            else
            {
                allocate[pos2] -= process[1];
            }
            /////////////////////3///////////////
            max = 0;
            for (i = 0; i < 5; i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos3 = i;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (max > process[2])
                {
                    label5.Text = process[2] + " is put in " + max;
                    b2++;
                }
            }
            if (b2 == 0)
            {
                label3.Text = process[2] + " must wait";
            }
            else
            {
                allocate[pos3] -= process[2];
            }
            //////////////////4////////////////////
            max = 0;
            for (i = 0; i < 5; i++)
            {
                if (allocate[i] > max)
                {
                    max = allocate[i];
                    pos4 = i;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (max > process[3])
                {
                    label6.Text = process[3] + " is put in " + max;
                    b3++;
                }
            }
            if (b3 == 0)
            {
                label6.Text = process[3] + " must wait";
            }
            else
            {
                allocate[pos4] -= process[3];
            }
        }
    }
}
