﻿using System;

namespace Enu
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());
            var methodname = "Express";
            var shippingmethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodname);
        }
    }
}
