using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_6_07.Models
{
    internal class Car<T1> 
        where T1 : Engine
        
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart)where T2 : CarPart
        {

        }
    }
}
