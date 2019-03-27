using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    public static class CarFactory
    {
        public static object CreateCar(string model, string color, decimal price, decimal safetyRating, string navigationSystem, 
            string bluetoothSupport)
        {
            //Car newCar = null;
            object newCar = null;
            switch (model.ToUpper())
            {
                case "CAMRY":
                    newCar = new Camry(navigationSystem, model, color, price, safetyRating);
                    break;

                case "ACCORD":
                    newCar = new Accord(bluetoothSupport, model, color, price, safetyRating);
                    Console.WriteLine("New Accord was created!");
                    break;
            }

            return newCar;
        }
    }
}
