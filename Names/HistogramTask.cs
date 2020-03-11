using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            string[] xLabels = new string[31];
            for (int i = 0; i < xLabels.Length; i++)
                xLabels[i] = (i + 1).ToString();

            double[] yData = new double[31];
            foreach (var man in names)
                if (man.Name.Equals(name) && man.BirthDate.Day != 1)
                    yData[man.BirthDate.Day - 1]++;


            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                xLabels, 
                yData);
        }
    }
}