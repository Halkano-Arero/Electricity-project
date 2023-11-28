using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {

                    //commercial price=12.50kes
                    //industial price=15.75kes
                    //domestic price=18.90kes
                    double chargeAmount, crtrdng, prvrdng;
                    string cusName;
                    double total;
                    double type;
                    Console.WriteLine("                                                 Welcome To Electricity Bill calculator     ");
                    Console.WriteLine("                                             ...................................");

                    Console.WriteLine("\t Enter the Customer Name:");
                    cusName = Console.ReadLine();
                    while (true) {
                        Console.WriteLine("\t Enter the Current Meter Reading:");
                        crtrdng = Convert.ToDouble(Console.ReadLine());
                        if (crtrdng >= 0)
                        {
                            Console.WriteLine($"Your current meter reading is:{crtrdng}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Check and try again");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("\t Enter the Previous Meter Reading:");
                        prvrdng = Convert.ToDouble(Console.ReadLine());
                        if (prvrdng >= 0)
                        {
                            Console.WriteLine($"Your previous Meter Reading is:{prvrdng}");
                            break;
                        }
                        else
                        { 
                            Console.WriteLine("Invalid input! Check and try again"); 
                        }

                    }
                        double amount = crtrdng - prvrdng;
                        Console.WriteLine($"\tThis Month Consumption is: {amount}");
                    
                    try {
                        while (true)
                        {
                            Console.WriteLine("Choose your Type of Usage:");
                            Console.WriteLine("\t1:commercial\n");
                            Console.WriteLine("\t2:industrial\n");
                            Console.WriteLine("\t3:domestic\n");
                            Console.WriteLine("Enter your Type of Usage:");
                            type = Convert.ToDouble(Console.ReadLine());

                            if (type == 1)
                            {
                                chargeAmount = 12.50;
                                Console.WriteLine($"Your Bill is:\n{chargeAmount}*{amount} = {chargeAmount * amount}", chargeAmount, amount);
                                break;
                            }
                            else if (type == 2)
                            {
                                chargeAmount = 15.75;
                                Console.WriteLine($"Your Bill is:\n{chargeAmount}*{amount} ={chargeAmount * amount}", chargeAmount, amount);
                                break;
                            }
                            else if (type == 3)
                            {
                                chargeAmount = 18.90;
                                Console.WriteLine($"Your Bill is:\n{chargeAmount}*{amount} ={chargeAmount * amount}", chargeAmount, amount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Please Try Again!");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                     Console.WriteLine("Invalid Code!");
                    }
                    Console.ReadKey();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!!");
                }
                Console.WriteLine("Do you want to continue?(Y=yes,N=no):");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");

            Console.ReadKey(true);
        }
    }
}
