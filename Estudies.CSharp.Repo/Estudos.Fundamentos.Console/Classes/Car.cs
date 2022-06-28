using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Fundamentos.Console.Classes
{
    public class Car
    {
        private string _carName;
        private string _color;
        public Car(string carName, string color)
        {
          _color = color;
          _carName = carName;
        }

        public string Describe()
        {
            return $"This car is {_color}";
        }

        public string CarName { get { return _carName; } set { _carName = value; } }
        public string Color { get { return _color; } set { _color = value; } }
    }
}
