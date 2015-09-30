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
    public partial class Statistics : System.Web.UI.Page
    {
        private string country1;
        private string capital1;
        private long population1;

        List<Country> countries = new List<Country>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchCountryBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] country = line.Split('|');

                    if (countryTxtBox.Text == country[0])
                    {
                        country1 = country[0];
                        capital1 = country[1];
                        population1 = long.Parse(country[2]);
                    }
                    line = reader.ReadLine();
                }
            }
            Label1.Text = country1 + " " + capital1 + " " + population1;
        }

        protected void searchCapitalBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] country = line.Split('|');

                    if (capitalTxtBox.Text == country[1])
                    {
                        country1 = country[0];
                        capital1 = country[1];
                        population1 = long.Parse(country[2]);
                    }
                    line = reader.ReadLine();
                }
            }
            Label2.Text = country1 + " " + capital1 + " " + population1;
        }

        protected void searchPopulationBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] country = line.Split('|');

                    if ((int.Parse(searchPopulationTxtBox.Text) <= long.Parse(country[2])) && (int.Parse(searchPopulationTxtBox2.Text) >= long.Parse(country[2])))
                    {
                        country1 = country[0];
                        capital1 = country[1];
                        population1 = long.Parse(country[2]);
                    }
                    line = reader.ReadLine();
                }
            }
            Label3.Text = country1 + " " + capital1 + " " + population1;
        }
    }
}