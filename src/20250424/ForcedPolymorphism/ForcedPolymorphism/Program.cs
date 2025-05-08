using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcedPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] listOfShapes;
            foreach (var shape in listOfShapes)
            {
                Debug.WriteLine($"Drawing shape {shape.Name}...");
                shape.Draw();
            }
        }
    }
}
