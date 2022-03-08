using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPenjualanAlatTulis
{
    //fields

    //constructor
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set;  }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string> {
            "#336B87",
            "#AEBD38",
            "#003B46",
            "#486B00"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                blue *= correctionFactor;
                green *= correctionFactor;
            }

            //If correction factor is greater than 0, lighten color
            else
            {
                green = (255-green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
                red = (255 - red) * correctionFactor + red;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }

    //Methods
}
