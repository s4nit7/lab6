using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Car : Vehicle
    {
        public Car() : base(70, 5)
        {
            Speed = 70;
            Capacity = 5;
        }

        public override void Move()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }
}
