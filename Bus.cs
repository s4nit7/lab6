﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Bus : Vehicle
    {
        public Bus() : base(50, 30)
        {
            Speed = 50;
            Capacity = 30;
        }

        public override void Move()
        {
            Console.WriteLine("Bus is traveling on the route.");
        }
    }
}
