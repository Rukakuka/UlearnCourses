using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] xLabels = new string[30];
            for (int i = 0; i < xLabels.Length; i++)
                xLabels[i] = (i+2).ToString();
            
            string[] yLabels = new string[12];
            for (int i = 0; i < yLabels.Length; i++)
                yLabels[i] = (i + 1).ToString();

            var data = new double[30,12];
            foreach (var man in names)
                if (man.BirthDate.Day != 1)
                    data[man.BirthDate.Day - 2, man.BirthDate.Month - 1]++;

            return new HeatmapData(
               "Пример карты интенсивностей",
               data,
               xLabels,
               yLabels);
        }
    }
}