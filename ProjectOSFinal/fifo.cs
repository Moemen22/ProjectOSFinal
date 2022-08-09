using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class fifo : Form
    {
        string frames; int pages;
        int frames2;

        int flag = 0;
        int pos = 0;
        int Hit = 0;
        string HitRate ;
        string FaultRate;

        string[] refstring = new string[17];
        string[] refstring2 = new string[10];
        string[] refstring3 = new string[3];
        string[] refstring4 = new string[10];
        // string[] l = new string[10];
        // string[] l = new string[10];
        //int pagefaults = 3;
        int[] frame = new int[3];
        int m, n, s;
        int var = 1;
        public fifo()
        {
            InitializeComponent();
        }

        private void fifo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            frames = textBox1.Text.ToString();
            frames2 = Int32.Parse(frames);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pagefaults = 3;
            refstring[0] = textBox2.Text.ToString();
            refstring[1] = textBox3.Text.ToString();
            refstring[2] = textBox4.Text.ToString();
            refstring[3] = textBox5.Text.ToString();
            refstring[4] = textBox6.Text.ToString();
            refstring[5] = textBox7.Text.ToString();
            refstring[6] = textBox8.Text.ToString();
            refstring[7] = textBox9.Text.ToString();
            refstring[8] = textBox10.Text.ToString();
            refstring[9] = textBox11.Text.ToString();
            refstring2[0] = textBox2.Text.ToString();
            refstring2[1] = textBox3.Text.ToString();
            refstring2[2] = textBox4.Text.ToString();
            refstring2[3] = textBox5.Text.ToString();
            refstring2[4] = textBox6.Text.ToString();
            refstring2[5] = textBox7.Text.ToString();
            refstring2[6] = textBox8.Text.ToString();
            refstring2[7] = textBox9.Text.ToString();
            refstring2[8] = textBox10.Text.ToString();
            refstring2[9] = textBox11.Text.ToString();
            
            int i = 3;
            int flag = 10;
            int min = 9999;
            refstring3[0] = refstring[i - 1];
            refstring3[1] = refstring[i - 2];
            refstring3[2] = refstring[i - 3];
            textBox21.Text = refstring3[2].ToString();
            textBox19.Text = refstring3[1].ToString();
            textBox13.Text = refstring3[2].ToString();

            textBox24.Text = refstring3[2].ToString();
            textBox22.Text = refstring3[1].ToString();
            textBox23.Text = refstring3[0].ToString();
            for (i = 3; i < 10; i++)
            {
                if (refstring[i] != refstring[i - 1] && refstring[i] != refstring[i - 2] && refstring[i] != refstring[i - 3])
                {
                    int pos = i;

                    for (int k = 0; k < pos; k++)
                    {
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring3[0]))
                        {
                            if (k < min)
                            {
                                min = k;
                                flag = 0;
                                
                               
                            }

                        }
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring3[1]))
                        {
                            if (k < min)
                            {
                                min = k;
                                flag = 1;
                               
                                
                            }

                        }
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring3[2]))
                        {
                            if (k < min)
                            {
                                
                                min = k;
                                flag = 2;
                               
                                
                            }

                        }
                    }
                    if (flag == 0)
                    {
                        
                        refstring3[0] = refstring[i];
                        if (i == 3)
                        {
                            textBox26.Text=refstring3[0].ToString();
                        }


                        pagefaults++;
                        

                    }
                    if (flag == 1)
                    {
                        refstring3[1] = refstring[i];
                        if (i == 3)
                        {
                            textBox25.Text = refstring3[1].ToString();
                        }

                        pagefaults++;


                    }
                    if (flag == 2)
                    {
                        refstring3[2] = refstring[i];
                        if (i == 3)
                        {
                            textBox27.Text = refstring[0].ToString();
                            textBox25.Text = refstring3[2].ToString();
                            textBox26.Text = refstring3[0].ToString();
                        }

                        pagefaults++;
                    }


                }
            }
            Hit = 10 - pagefaults;
            textBox14.Text = Hit.ToString();
            HitRate = (Hit.ToString() + "/ " + "10");
            textBox15.Text = HitRate;

            FaultRate = (pagefaults.ToString() + "/ " + "10");
            textBox16.Text = FaultRate;
           
            textBox12.Text = pagefaults.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pagefaults = 3;
            refstring[0] = textBox2.Text.ToString();
            refstring[1] = textBox3.Text.ToString();
            refstring[2] = textBox4.Text.ToString();
            refstring[3] = textBox5.Text.ToString();
            refstring[4] = textBox6.Text.ToString();
            refstring[5] = textBox7.Text.ToString();
            refstring[6] = textBox8.Text.ToString();
            refstring[7] = textBox9.Text.ToString();
            refstring[8] = textBox10.Text.ToString();
            refstring[9] = textBox11.Text.ToString();
            refstring2[0] = textBox2.Text.ToString();
            refstring2[1] = textBox3.Text.ToString();
            refstring2[2] = textBox4.Text.ToString();
            refstring2[3] = textBox5.Text.ToString();
            refstring2[4] = textBox6.Text.ToString();
            refstring2[5] = textBox7.Text.ToString();
            refstring2[6] = textBox8.Text.ToString();
            refstring2[7] = textBox9.Text.ToString();
            refstring2[8] = textBox10.Text.ToString();
            refstring2[9] = textBox11.Text.ToString();
           
            int i = 3;
            int flag = 10;
            int max = -9999;
            refstring4[0] = refstring[i + 1];
            refstring4[1] = refstring[i + 2];
            refstring4[2] = refstring[i + 3];
            refstring4[3] = refstring[i + 4];
            refstring4[4] = refstring[i + 5];
            refstring4[5] = refstring[i + 6];
            refstring4[6] = refstring[i + 7];
            for (i = 3; i < 10; i++)
            {
             //   if (refstring[i] != refstring[i + 1] && refstring[i] != refstring[i +2] && refstring[i] != refstring[i +3])
              //  {
                    int pos = i;

                    for (int k = 0; k < pos; k++)
                    {
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring4[0]))
                        {
                            if (k > max)
                            {
                                max = k;
                                flag = 0;
                            }

                        }
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring4[1]))
                        {
                            if (k > max)
                            {
                                max = k;
                                flag = 1;
                            }

                        }
                        if (Int32.Parse(refstring[k]) == Int32.Parse(refstring4[2]))
                        {
                            if (k > max)
                            {
                                max = k;
                                flag = 2;
                            }

                        }
                    }
                    if (flag == 0)
                    {
                        refstring4[0] = refstring[i];

                    
                        pagefaults++;
                    }
                    if (flag == 1)
                    {
                        refstring4[1] = refstring[i];
                        pagefaults++;
                    }
                    if (flag == 2)
                    {
                        refstring4[2] = refstring[i];
                        pagefaults++;
                    }
                    if (flag == 3)
                    {
                        refstring4[3] = refstring[i];
                        pagefaults++;
                    }
                    if (flag == 4)
                    {
                        refstring4[4] = refstring[i];
                        pagefaults++;
                    }
                    if (flag == 5)
                    {
                        refstring4[5] = refstring[i];
                        pagefaults++;
                    }
                     if (flag == 6)
                    {
                        refstring4[6] = refstring[i];
                        pagefaults++;
                    }
                     


                //}
            }

            Hit = 10 - pagefaults;
            textBox14.Text = Hit.ToString();
            HitRate = (Hit.ToString() + "/ " + "10");
            textBox15.Text = HitRate;
            

            FaultRate = (pagefaults.ToString() + "/ " + "10");
            textBox16.Text = FaultRate;

            textBox12.Text = pagefaults.ToString();
            


        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pagefaults = 3;
            refstring[0] = textBox2.Text.ToString();
            refstring[1] = textBox3.Text.ToString();
            refstring[2] = textBox4.Text.ToString();
            refstring[3] = textBox5.Text.ToString();
            refstring[4] = textBox6.Text.ToString();
            refstring[5] = textBox7.Text.ToString();
            refstring[6] = textBox8.Text.ToString();
            refstring[7] = textBox9.Text.ToString();
            refstring[8] = textBox10.Text.ToString();
            refstring[9] = textBox11.Text.ToString();
            /* for (int i = 0; i < 10; i++)
             {
                 pages2[i] = l[i];
             }

             for (m = 0; m < 10; m++)
             {
                 int k = 0;
                 s = 0;
                 if (m > 2)
                 {
                     k = m - 2;
                     for (n = k; n < frames2; n++)
                     {

                         if (l[m] == l[n])
                         {

                             s++;
                             pagefaults--;


                         }
                     }
                 }
                 pagefaults++;

                /* if ((pagefaults <= frames2) && (s == 0))
                 {
                     l[m] = refstring[m];
                 }
                 else if (s == 0)
                 {
                     l[(pagefaults - 1) % frames2] = refstring[m];
                 }
                 //printf("\n");
                 for (n = 0; n < frames2; n++)
                 {
                    // printf("%d\t", temp[n]);
                 }
                */

            /* for (int i = 0; i < 3; i++)
             {
                 frame[i] = -1;
             }

             for (int c=0; c <10 ;c++ )

             {

                 int i = 0;
                 for (int j = 0; j < frames2; j++)
                 {

                     if(Int32.Parse(refstring[j])==frame[i])
                     {
                         flag = 1;
                         break;
                     }



                 }
                 int a = 0;
                 if (flag == 0)
                 {

                     frame[pos] = Int32.Parse(refstring[a]);
                     pos++;
                     if (pos >= 1)
                     {
                         for (int b = 1; b < pos+1;b++)
                         {
                             if (frame[b] == frame[pos])
                             {
                                 pagefaults--;

                             }

                         }
                     }




                 }
                 if (pos >= frames2)
                 {

                     pos = 0;
                 }








             }

             */
            
          
                if(refstring[3]!= refstring[2] && refstring[3] != refstring[1] && refstring[3] != refstring[0])
                {
                    pagefaults++;
                }
                if (refstring[4] != refstring[3] && refstring[4] != refstring[2] && refstring[4] != refstring[1])
                {
                    pagefaults++;
                }
                if (refstring[5] != refstring[4] && refstring[5] != refstring[3] && refstring[5] != refstring[2])
                {
                    pagefaults++;
                }
                if (refstring[6] != refstring[5] && refstring[6] != refstring[4] && refstring[6] != refstring[3])
                {
                    pagefaults++;
                }
                if (refstring[7] != refstring[6] && refstring[7] != refstring[5] && refstring[7] != refstring[4])
                {
                    pagefaults++;
                }
                if (refstring[8] != refstring[7] && refstring[8] != refstring[6] && refstring[8] != refstring[5])
                {
                    pagefaults++;
                }
                if (refstring[9] != refstring[8] && refstring[9] != refstring[7] && refstring[9] != refstring[6])
                {
                    pagefaults++;
                }
            Hit = 10 - pagefaults ;
            textBox14.Text = Hit.ToString();
            HitRate = (Hit.ToString() + "/ " + "10");
            textBox15.Text = HitRate;

            FaultRate = (pagefaults.ToString() + "/ " + "10");
            textBox16.Text = FaultRate;
            textBox12.Text = pagefaults.ToString();
            
          
        }
    }
}



