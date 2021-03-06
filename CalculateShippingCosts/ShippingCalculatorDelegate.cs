﻿namespace CalculateShippingCosts
{
    public static class ShippingCalculatorDelegate
    {
        public static double Zone1(double price)
        {
            return price * 1.25;
        }

        public static double Zone2(double price)
        {
            return price * 1.12 + 25;
        }

        public static double Zone3(double price)
        {
            return price * 1.08;
        }

        public static double Zone4(double price)
        {
            return price * 1.04 + 25;
        }
    }
}
