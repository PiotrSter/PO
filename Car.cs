﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5
{
    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem.");
        }
    }
}
