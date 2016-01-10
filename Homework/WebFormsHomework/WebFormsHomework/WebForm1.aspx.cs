using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsHomework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if ((TextBox5.Text).Contains('@') == false || (TextBox5.Text).Contains('.') == false)
            {
                label6.Text = "Please enter a correct e-mail!";
            }
            else
            {
                label6.Text = "";
            }

            using (StreamWriter writer = new StreamWriter(Server.MapPath("WriteLines.txt"), true))
            {
                writer.WriteLine(label1.Text + " " + TextBox1.Text);
                writer.WriteLine(label2.Text + " " + TextBox2.Text);
                writer.WriteLine(label3.Text + " " + TextBox3.Text);
                writer.WriteLine(label4.Text + " " + TextBox4.Text);
                writer.WriteLine(label5.Text + " " + TextBox5.Text);
            }
        }
    }
}