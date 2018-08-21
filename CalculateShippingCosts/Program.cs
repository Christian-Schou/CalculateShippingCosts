using System;

// Declaring delegate
internal delegate double ZoneCalculator(double price);

namespace CalculateShippingCosts
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
            ZoneCalculator zoneCalc1 = ShippingCalculatorDelegate.Zone1;
            ZoneCalculator zoneCalc2 = ShippingCalculatorDelegate.Zone2;
            ZoneCalculator zoneCalc3 = ShippingCalculatorDelegate.Zone3;
            ZoneCalculator zoneCalc4 = ShippingCalculatorDelegate.Zone4;

            Console.Write("Please enter zone (1 - 4): ");
            // Throw exception when entered number is null
            var zoneSwitch = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (zoneSwitch > 0 || zoneSwitch <= 4)
            {
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
            } else
                {
                    Console.WriteLine("Please enter a valid zone (1 - 4)"); 
                }

            Console.ReadKey();
        }
    }
}
