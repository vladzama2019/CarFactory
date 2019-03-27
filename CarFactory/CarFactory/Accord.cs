using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    class Accord : Car
    {
        public string BluetoothSupport{ get; set; }

        public Accord(string bluetoothSupport, string model, string color, decimal price, decimal safetyRating)
        {
            Model = model;
            Color = color;
            Price = price;
            SafetyRating = safetyRating;
            BluetoothSupport = bluetoothSupport;
        }
    }
}
