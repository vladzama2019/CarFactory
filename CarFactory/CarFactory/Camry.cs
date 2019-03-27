using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    class Camry : Car
    {
        public string NavigationSystem { get; set; }

        public Camry(string navigationSystem, string model, string color, decimal price, decimal safetyRating)
        {
            Model = model;
            Color = color;
            Price = price;
            SafetyRating = safetyRating;
            NavigationSystem = navigationSystem;
        }
    }
}
