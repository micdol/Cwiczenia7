using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Measurement : IGenerateHTML
    {
        private string m_stationName;
        private DateTime m_date;
        private double[] m_conditions;
        private static int m_noOfMeasurements = 0;

        public enum MeasurementConditions { Temperature = 0, Pressure = 1, Humidity = 2 };
        public static int NoOfMeasurements { get { return m_noOfMeasurements; } }

        public Measurement(string stationName = "No Name!")
        {
            m_stationName = stationName;
            m_date = DateTime.Now;
            m_conditions = new double[] { 0.0, 0.0, 0.0 };
            m_noOfMeasurements++;
        }

        // Indexer
        public double this[int pos]
        {
            get
            {
                return m_conditions[pos];
            }
            set
            {
                m_conditions[pos] = value;
            }
        }
        private new string ToString()
        {
            return string.Format(
                "Station name: {0}, time of measurment: {1} \n" +
                "Conditions - temperature: {2:0.0}, pressure: {3:0.}, humidity: {4:0}",
                m_stationName, m_date,
                this[(int)MeasurementConditions.Temperature],
                this[(int)MeasurementConditions.Pressure],
                this[(int)MeasurementConditions.Humidity]);
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString() + "\n");
        }

        public string ToHTMLString()
        {
            return "<font color='red' > =========POMIAR=========</font> <br />\n" +
                ToString();
        }
    }
}
