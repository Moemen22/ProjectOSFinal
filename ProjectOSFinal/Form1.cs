using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sallocate;
        string[] sprocess;
        int[] allocate;
        int[] process;
        int i, j,pos,pos2,b=0,b1=0,b2=0,b3=0,b4=0,b5=0;

        private void button2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
            for(i=0;i<5;i++)
            {
                allocate[i] = Convert.ToInt32(sallocate[i]);
            }
            for(j=0;j<4;j++)
            {
                process[j] = Convert.ToInt32(sprocess[j]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            input();
            for(i=0;i<5;i++)
            {
               if(allocate[i]>process[0])
               {
                   label3.Text = process[0]+ " is put in " + allocate[i];
                   pos = i;
                   //pos2 = j;
                   b++;
                   break;
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
            //////////////////1//////////////////
            for (i=0;i<5;i++)
            {
                if(allocate[i]>process[1])
                {
                    label4.Text = process[1] + " is put in " + allocate[i];
                    pos = i;
                    b1++;
                    break;
                }
            }
            if (b1 == 0)
            {
                label4.Text = process[1] + " must wait";
            }
            else
            {
                allocate[pos] -= process[1];
            }
            ////////////////2//////////////////
            for (i=0;i<5;i++)
            {
                if(allocate[i]>process[2])
                {
                    label5.Text = process[2] + " is put in " + allocate[i];
                    pos = i;
                    b2++;
                    break;
                }
            }
            if(b2 == 0)
            {
                label5.Text = process[2] + " must wait";
            }
            else
            {
                allocate[pos] -= process[2];
            }
           //////////3//////////
           for(i=0;i<5;i++)
            {
                if (allocate[i] > process[3])
                {
                    label6.Text = process[3] + " is put in " + allocate[i];
                    pos = i;
                    b3++;
                    break;
                }
            }
            if (b3 == 0)
            {
                label6.Text = process[3] + " must wait";
            }
            else
            {
                allocate[pos] -= process[3];
            }
           
        }
    }
}
