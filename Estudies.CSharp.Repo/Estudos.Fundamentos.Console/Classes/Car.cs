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
        private string _model;
        public Car(string carName, string color, string model)
        {
          _color = color;
          _carName = carName;
          _model = model;
        }

        public string Describe()
        {
            return $"This car is {_color}";
        }

        public string DescribeModel()
        {
            return $"This i the model = {_model}";
        }
        public string CarName { get { return _carName; } set { _carName = value; } }
        public string Color { get { return _color; } set { _color = value; } }
    }
}
