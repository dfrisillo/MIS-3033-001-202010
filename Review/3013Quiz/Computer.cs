using System;
using System.Collections.Generic;
using System.Text;

namespace _3013Quiz
{
    class Computer
    {
        public double HardDriveSize { get; set; }
        public double CPUSpeed      {get;set;}
        public int CPUCores         {get;set;}
        public string Brand         {get;set;}
        public bool IsOverClocked   {get;set;}

        public Computer ()
        {
            HardDriveSize = 0;
            CPUCores = 0;
            CPUSpeed = 0;
            Brand = "Dell";
            IsOverClocked = false;
        }

        public double CalculatePrice()
        {
            return 55.5;
        }
    }
}
