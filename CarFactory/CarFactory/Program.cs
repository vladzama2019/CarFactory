using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = string.Empty;
            string color = string.Empty;
            decimal price = 0;
            decimal safetyRating = 0;
            string navigationSystem = string.Empty;
            string bluetoothSupport = string.Empty;

            Console.WriteLine("Type 1 to create Camry, type 2 to create Accord");
            string result = Console.ReadLine();
            if (result.Equals("1", StringComparison.OrdinalIgnoreCase))
            {
                Camry newCamry = null;
                model = "Camry";
                Console.WriteLine("Enter color");
                color = Console.ReadLine();
                Console.WriteLine("Enter price");
                result = Console.ReadLine();
                decimal.TryParse(result, out price);
                Console.WriteLine("Enter safety rating");
                result = Console.ReadLine();
                decimal.TryParse(result, out safetyRating);
                Console.WriteLine("Enter navigation system, for example, GPS");
                navigationSystem = Console.ReadLine();
                newCamry = (Camry) CarFactory.CreateCar(model, color, price, safetyRating, navigationSystem, string.Empty);

                Console.WriteLine($"New car was:\n Model: {newCamry.Model}\n NavigationSystem: {newCamry.NavigationSystem}\n Navigation system: {newCamry.NavigationSystem} \n Price: {newCamry.Price}\n Safety Rating {newCamry.SafetyRating}\n\n");
            }
            else if (result.Equals("2", StringComparison.OrdinalIgnoreCase))
            {
                Accord newAccord = null;
                model = "Accord";
                Console.WriteLine("Enter color");
                color = Console.ReadLine();
                Console.WriteLine("Enter price");
                result = Console.ReadLine();
                decimal.TryParse(result, out price);
                Console.WriteLine("Enter safety rating");
                result = Console.ReadLine();
                decimal.TryParse(result, out safetyRating);
                Console.WriteLine("Enter bluetooth support, for example, Y/N");
                bluetoothSupport = Console.ReadLine();
                newAccord = (Accord)CarFactory.CreateCar(model, color, price, safetyRating, string.Empty, bluetoothSupport);
                Console.WriteLine($"New car was:\n Model: {newAccord.Model}\n Support bluetooth: {newAccord.BluetoothSupport}\n Price: {newAccord.Price}\n Safety Rating {newAccord.SafetyRating}\n\n");
            }

            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
