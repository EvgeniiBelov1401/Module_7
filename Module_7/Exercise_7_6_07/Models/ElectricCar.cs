using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_6_07.Models
{
    internal class ElectricCar<TEngine>:Car<TEngine>where TEngine:Engine
    {
        public override void ChangePart<TCarPart>(TCarPart newPart)
        {
            
        }
    }
}
