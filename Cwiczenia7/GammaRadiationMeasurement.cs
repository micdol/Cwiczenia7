using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class GammaRadiationMeasurement : Measurement
    {
        public double RadiationLevel { get; set; } = 0.0;

        public GammaRadiationMeasurement(string name) : base(name) { }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Radiation Level: {0}", RadiationLevel);
        }
    }
}
