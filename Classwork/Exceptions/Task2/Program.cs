using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            try
            {
                Console.WriteLine("Enter an e-mail: ");
                customer1.Email = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                customer1.Password = Console.ReadLine();
            }
            catch (InvalidE_mail)
            {

                Console.WriteLine("Enter a valid e-mail!");
            }
            catch (InvalidPassword)
            {
                Console.WriteLine("Enter a valid password!");
            }
            finally
            {
                Console.WriteLine("The end!");
            }
        }
    }
}
