using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculateShippingCosts;

// Declaring delegate
delegate double zoneCalculator(double price);

namespace CalculateShippingCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            

            zoneCalculator zoneCalc1 = ShippingCalculatorDelegate.Zone1;
            zoneCalculator zoneCalc2 = ShippingCalculatorDelegate.Zone2;
            zoneCalculator zoneCalc3 = ShippingCalculatorDelegate.Zone3;
            zoneCalculator zoneCalc4 = ShippingCalculatorDelegate.Zone4;

            Console.Write("Please enter zone: ");
            // Throw exception when entered number is null
            int zoneSwitch = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            switch (zoneSwitch)
            {
                case 1:
                    Console.Write("Please enter price: ");
                    // Throw exception when entered number is null
                    double zone1 = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    double Zone1 = zoneCalc1(zone1);
                    Console.WriteLine("Calculated price is {0}", Zone1);
                    break;

                case 2:
                    Console.Write("Please enter price: ");
                    // Throw exception when entered number is null
                    double zone2 = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    double Zone2 = zoneCalc2(zone2);
                    Console.WriteLine("Calculated price is {0}", Zone2);
                    break;

                case 3:
                    Console.Write("Please enter price: ");
                    // Throw exception when entered number is null
                    double zone3 = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    double Zone3 = zoneCalc3(zone3);
                    Console.WriteLine("Calculated price is {0}", Zone3);
                    break;

                case 4:
                    Console.Write("Please enter price: ");
                    // Throw exception when entered number is null
                    double zone4 = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    double Zone4 = zoneCalc4(zone4);
                    Console.WriteLine("Calculated price is {0}", Zone4);
                    break;

                default:
                    break;
            }

            Console.Write("Hit ENTER to exit or enter zone number: ");
            Console.ReadKey();


        }
    }
}
