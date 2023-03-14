﻿using System.Drawing;

namespace DesignPatternASP.DesignPattern.FactoryMethod
{
    public interface IChart
    {
        string Title { get; set; }
        List<string> XData { get; set; }
        List<int> YData { get; set; }
        Bitmap GenerateChart();
    }

    public class ColorHelper
    {
        public static Color GetBrushColor(int i)
        {
            Color c;

            switch (i)
            {
                case 0:
                    c = Color.Blue;
                    break;
                case 1:
                    c = Color.Red;
                    break;
                case 2:
                    c = Color.Yellow;
                    break;
                case 3:
                    c = Color.Peru;
                    break;
                case 4:
                    c = Color.Orange;
                    break;
                case 5:
                    c = Color.Coral;
                    break;
                case 6:
                    c = Color.Gray;
                    break;
                case 7:
                    c = Color.Maroon;
                    break;
                default:
                    c = Color.SteelBlue;
                    break;
            }
            return c;
        }
    }
}
