using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    //Vlad is here!
        }
        //[-1 42]

        private void button1_Click(object sender, EventArgs e)
        {
            int a = -1, b = 42;
            listBox1.Items.Clear();
            Random r = new Random();
            int i = 0;
            while (i < 50)
            {
                float n = r.Next() % (b - a + 1) + a;
                if (n < a || n > b) continue;
                i++;
                listBox1.Items.Add(i + ")  " + n);
            }
        }
        // -0,3 30,9
        private void button2_Click(object sender, EventArgs e)
        {
            float a = -0.3f, b = 30.9f;
            listBox1.Items.Clear();
            Random r = new Random();
            int i = 0;
            while (i < 50)
            {
                float n = (float)r.Next(-1000, 0x7fff) / (b * (b - a) + a);
                if (n < -0.3 || n >= 30.9) continue;
                i++;
                listBox1.Items.Add(string.Format(i + ") {0:F2}", n));  
            }
        }
    }
}
