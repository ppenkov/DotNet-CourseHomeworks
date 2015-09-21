using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text).Contains('@') == false || (textBox3.Text).Contains('.') == false)
            {
                label4.Text = "Please enter a correct e-mail!";
            }
            else
            {
                label4.Text = "";
            }

            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                string.Format(textBox1.Text);
                string.Format(textBox2.Text);
                string.Format(textBox3.Text);

                writer.WriteLine(label1.Text + " " + textBox1.Text);
                writer.WriteLine(label2.Text + " " + textBox2.Text);
                writer.WriteLine(label3.Text + " " + textBox3.Text);
            }
        }
    }
}
