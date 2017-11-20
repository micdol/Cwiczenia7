using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{

    class AirPollutionMeasurement : Measurement
    {

        public int PM2_5 { get; set; } = 0;
        public int PM10 { get; set; } = 0;

        public AirPollutionMeasurement(string name) : base(name) { }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Air pollution: - PM2.5: {0}, PM10: {1}", PM2_5, PM10);
        }
    }
}
