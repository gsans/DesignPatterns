﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : Target
    {
        public Adapter()
        {
        }

        public override void Request()
        {
            Console.WriteLine("Called Adapter Request()");
            _adaptee.SpecificRequest();
        }
    }
}
