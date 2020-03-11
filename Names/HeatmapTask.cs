using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] xLabels = new string[31];
            for (int i = 0; i < xLabels.Length; i++)
                xLabels[i] = (i + 1).ToString();

            string[] yLabels = new string[12];
            for (int i = 0; i < yLabels.Length; i++)
                xLabels[i] = (i + 1).ToString();

            var data = new double[31,12];
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i, j] = 1;
            data[0, 0] = 2;
            return new HeatmapData(
               "Пример карты интенсивностей",
               data,
               xLabels,
               yLabels);

            //return new HeatmapData(
            //    "Пример карты интенсивностей",
            //    new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 4 }, { 4, 4, 4 } }, 
            //    new[] { "a", "b", "c", "d" }, 
            //    new[] { "X", "Y", "Z" });
        }
    }
}