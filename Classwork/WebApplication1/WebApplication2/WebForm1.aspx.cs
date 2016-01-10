using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked && dropList1.SelectedIndex != 0)
            {
                Button.Enabled = true;
            }
        }

        protected void dropList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked && dropList1.SelectedIndex != 0)
            {
                Button.Enabled = true;
            }
        }
    }
}