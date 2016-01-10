using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamProject
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Country newCountry = new Country()
            {
                Name = countryTxtBox.Text,
                Capital = capitalTxtBox.Text,
                Population = long.Parse(populationTxtBox.Text)
            };

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(newCountry);
            }
        }
    }
}