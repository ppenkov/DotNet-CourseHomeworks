using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Companies> company = new List<Companies>();
            Companies company1 = new Companies();
            company1.Name = "Miscrosoft";
            company1.Count = 3000;

            Companies company2 = new Companies();
            company2.Name = "HP";
            company2.Count = 4000;

            Companies company3 = new Companies();
            company3.Name = "Google";
            company3.Count = 5000;

            company.Add(company1);
            company.Add(company2);
            company.Add(company3);

            int MaxNumber = company1.Count;
            foreach (var item in company)
            {
                if (MaxNumber < item.Count)
                {
                    void.Remove(item);
                }
            }
        }
    }
}
