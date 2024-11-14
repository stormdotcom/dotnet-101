using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPI
{
    public class Car
    {
        private readonly IDriver _driver;

        public Car(IDriver driver)
        {
            _driver = driver;
        }

        public void Start()
        {
            Console.WriteLine($"{_driver.GetName()} start the car");
        }
    }
}
