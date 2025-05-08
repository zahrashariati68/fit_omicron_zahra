using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcedPolymorphism
{
    public abstract class Vehicle
    {
        public abstract string Brand { get; }
        public abstract bool SpeedUp(int delta);
    }
}
