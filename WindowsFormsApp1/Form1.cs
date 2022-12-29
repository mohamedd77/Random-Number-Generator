using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long a = long.Parse(textBox1.Text);
            long seed = long.Parse(textBox2.Text);
            long c = long.Parse(textBox3.Text);
            long m = long.Parse(textBox4.Text);
            //   long num_of_it = long.Parse(textBox5.Text);
            List<long> ST = new List<long>();
            

            Class1 class1 = new Class1();
            bool fa = true;
            if (class1.num_sen(c, m, a, seed) == 1) 
            {
               ST= class1.sen1(a, c, seed, m);
            }
            else  if (class1.num_sen(c, m, a, seed) == 2)
            {
               ST= class1.sen2(a, c, seed, m);
            }
            else if (class1.num_sen(c, m, a, seed) == 3)
            {
               ST= class1.sen3(a, c, seed, m);
            }
            else if (class1.num_sen(c, m, a, seed) == 4)
            {
              ST=  class1.sen4(a, c, seed, m);
                fa = false;
                for (int i = 0; i < ST.Count-2; i++)
                {
                    dataGridView1.Rows.Add(
                        ST[i]
                        );
                }
                textBox6.Text =ST[ST.Count-1].ToString();
            }
            if (fa == true)
            {
                for (int i = 0; i < ST.Count-1; i++)
                {
                    dataGridView1.Rows.Add(
                        ST[i]
                        );
                    textBox6.Text = ST[ST.Count - 1].ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
