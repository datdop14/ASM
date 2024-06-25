using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = GetuserName();

            Console.Write("Enter last month's water meter reading:");
            double lastMonthReading = double.Parse(Console.ReadLine());
            Console.Write("Enter this month's water meter reading:");
            double thisMonthReading = double.Parse(Console.ReadLine());

            while (thisMonthReading < lastMonthReading)
            {
                Console.WriteLine("Error: Current water meter number is greater than last month's water meter number, Please re-enter: ");
                Console.Write("Enter this month's water meter reading: ");
                thisMonthReading = double.Parse(Console.ReadLine());

            }
            double consumption = thisMonthReading - lastMonthReading;
            TypeOfCustomer();
            double bill = Calculate(consumption, thisMonthReading, lastMonthReading);
            Console.ReadKey();
        }
       
        static string GetuserName()
        {
            Console.Write("Enter customer name: ");
            return Console.ReadLine();
        }

        static void TypeOfCustomer()
        {
            Console.WriteLine("Enter customer type (1-Household, 2-Administrative, 3-Production, 4-Business):");
        }

        static double Calculate(double consumption, double lastMonthReading, double thisMonthReading)
        {
            Console.Write("Please choose type of customer: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateHouseholdBilling(consumption);
                    break;
                case 2:
                    CalculateAgencyBilling(consumption, 9.955);
                    break;
                case 3:
                    CalculateProductionBilling(consumption, 11.615);
                    break;
                case 4:
                    CalculateBusinessServiceBilling(consumption, 22.608);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
            return consumption;
           
        }

        static void CalculateHouseholdBilling(double consumption)
        {
            Console.WriteLine("Enter the number of people in your household:");
            if (int.TryParse(Console.ReadLine(), out int numberOfPeople) && numberOfPeople > 0)
            {
                double waterbill;
                if (consumption < 10 && consumption > 0)
                {
                    waterbill = consumption * 5.973;
                }
                else if (consumption < 20 && consumption >= 10)
                {
                    waterbill = (10 * 5.973) + ((consumption - 10) * 7.052);
                }
                else if (consumption >= 20 && consumption < 30)
                {
                    waterbill = (10 * 5.973) + (10 * 7.052) + ((consumption - 20) * 8.699);
                }
                else
                {
                    waterbill = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + (consumption - 30) * 15.929;
                }
                Console.WriteLine("Water bill: " + waterbill + "VND");

                double priceEnviromentFee = (waterbill / 100) * 10;
                Console.WriteLine("Environment Fee: " + priceEnviromentFee + "VND");

                double priceVAT = (waterbill / 100) * 10;
                Console.WriteLine("VAT: " + priceVAT + "VND");

                double finalTotalAmount = waterbill + priceEnviromentFee + priceVAT;
                Console.WriteLine("Total Bill: " + finalTotalAmount + "VND");
            }
            else
            {
                Console.WriteLine("Invalid number of people.");
            }

            Console.ReadKey();
        }


        static void CalculateAgencyBilling(double consumption, double price)
        {
            double waterbill = consumption * price;
            Console.WriteLine("Water bill: " + waterbill + "VND");

            double priceEnviromentFee = (waterbill / 100) * 10;
            Console.WriteLine("Environment Fee: " + priceEnviromentFee + "VND");

            double priceVAT = (waterbill / 100) * 10;
            Console.WriteLine("VAT: " + priceVAT + "VND");

            double finalTotalAmount = waterbill + priceEnviromentFee + priceVAT;
            Console.WriteLine("Total Bill: " + finalTotalAmount + "VND");
        }

        static void CalculateProductionBilling(double consumption, double price)
        {
            double waterbill = consumption * price;
            Console.WriteLine("Water bill: " + waterbill + "VND");

            double priceEnviromentFee = (waterbill / 100) * 10;
            Console.WriteLine("Environment Fee: " + priceEnviromentFee + "VND");

            double priceVAT = (waterbill / 100) * 10;
            Console.WriteLine("VAT: " + priceVAT + "VND");
            double finalTotalAmount = waterbill + priceEnviromentFee + priceVAT;
            Console.WriteLine("Total Bill: " + finalTotalAmount + "VND");
        }

        static void CalculateBusinessServiceBilling(double consumption, double price)
        {
            double waterbill = consumption * price;
            Console.WriteLine("Water bill: " + waterbill + "VND");

            double priceEnviromentFee = (waterbill / 100) * 10;
            Console.WriteLine("Environment Fee: " + priceEnviromentFee + "VND");

            double priceVAT = (waterbill / 100) * 10;
            Console.WriteLine("VAT: " + priceVAT + "VND");

            double finalTotalAmount = waterbill + priceEnviromentFee + priceVAT;
            Console.WriteLine("Total Bill: " + finalTotalAmount + "VND");
        }

    }
    
}
