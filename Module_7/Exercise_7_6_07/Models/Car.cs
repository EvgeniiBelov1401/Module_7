using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_6_07.Models
{
    internal class Car<TEngine> 
        where TEngine : Engine
        
    {
        public T1 Engine;

        public virtual void ChangePart<TCarPart>(TCarPart newPart)where TCarPart : CarPart
        {

        }
    }
}
