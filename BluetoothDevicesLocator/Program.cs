﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace BluetoothDevicesLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start(@"..\..\BlueToothApp.BAT");
            Console.ReadLine();
        }
    }
}
