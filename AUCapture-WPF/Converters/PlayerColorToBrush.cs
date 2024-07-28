using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using AmongUsCapture;

namespace AUCapture_WPF.Converters
{
    public class PlayerColorToBrush : IValueConverter
    {
        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,             new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,            new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,           new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,            new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,          new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,          new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,           new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,           new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,          new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,           new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,            new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,            new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Maroon,          new SolidColorBrush(Color.FromRgb(95, 29, 46))},
            { PlayerColor.Rose,            new SolidColorBrush(Color.FromRgb(236, 192, 211))},
            { PlayerColor.Banana,          new SolidColorBrush(Color.FromRgb(240, 231, 168))},
            { PlayerColor.Gray,            new SolidColorBrush(Color.FromRgb(117, 133, 147))},
            { PlayerColor.Tan,             new SolidColorBrush(Color.FromRgb(145, 136, 119))},
            { PlayerColor.Coral,           new SolidColorBrush(Color.FromRgb(215, 100, 100))},
            { PlayerColor.Kusazungreen,    new SolidColorBrush(Color.FromRgb(17, 82, 98))},
            { PlayerColor.DarkRed,         new SolidColorBrush(Color.FromRgb(139, 0, 0))},
            { PlayerColor.MediumVioletRed, new SolidColorBrush(Color.FromRgb(199, 21, 133))},
            { PlayerColor.MediumPurple,    new SolidColorBrush(Color.FromRgb(147, 112, 219))},
            { PlayerColor.RosyBrown,       new SolidColorBrush(Color.FromRgb(188, 143, 143))},
            { PlayerColor.DarkMagenta,     new SolidColorBrush(Color.FromRgb(139, 0, 139))},
            { PlayerColor.Olive,           new SolidColorBrush(Color.FromRgb(128, 128, 0))},
            { PlayerColor.SteelBlue,       new SolidColorBrush(Color.FromRgb(70, 130, 180))},
            { PlayerColor.DodgerBlue,      new SolidColorBrush(Color.FromRgb(30, 144, 255))},
            { PlayerColor.DarkSeaGreen,    new SolidColorBrush(Color.FromRgb(143, 188, 143))},
            { PlayerColor.Sikon,           new SolidColorBrush(Color.FromRgb(66, 44, 65))},
            { PlayerColor.Konjou,          new SolidColorBrush(Color.FromRgb(17, 43, 76))},
            { PlayerColor.Vermilion,       new SolidColorBrush(Color.FromRgb(253, 60, 47))},
            { PlayerColor.IvyGreen,        new SolidColorBrush(Color.FromRgb(76, 103, 51))},
            { PlayerColor.Tilleul,         new SolidColorBrush(Color.FromRgb(186, 205, 49))},
            { PlayerColor.Ivory,           new SolidColorBrush(Color.FromRgb(255, 255, 240))},
            { PlayerColor.Kenpou,          new SolidColorBrush(Color.FromRgb(48, 47, 43))},
            { PlayerColor.Grisbleu,        new SolidColorBrush(Color.FromRgb(161, 169, 186))},
            { PlayerColor.Melon,           new SolidColorBrush(Color.FromRgb(245, 175, 78))},
            { PlayerColor.Clan,            new SolidColorBrush(Color.FromRgb(0, 109, 102))},
            { PlayerColor.Shiraaiiro,      new SolidColorBrush(Color.FromRgb(247, 228, 245))},
            { PlayerColor.WhitePink,       new SolidColorBrush(Color.FromRgb(235, 176, 226))},
            { PlayerColor.ThinPurple,      new SolidColorBrush(Color.FromRgb(208, 202, 253))},
            { PlayerColor.Sienna,          new SolidColorBrush(Color.FromRgb(157, 89, 49))},
            { PlayerColor.LightAvocado,    new SolidColorBrush(Color.FromRgb(224, 254, 205))},
            { PlayerColor.LightIwaitya,    new SolidColorBrush(Color.FromRgb(123, 126, 116))},
            { PlayerColor.DiardRed,        new SolidColorBrush(Color.FromRgb(227, 126, 126))},
            { PlayerColor.DiardGreen,      new SolidColorBrush(Color.FromRgb(174, 254, 173))},
            { PlayerColor.DiardBlue,       new SolidColorBrush(Color.FromRgb(255, 210, 253))},
            { PlayerColor.Chaos,           new SolidColorBrush(Color.FromRgb(238, 239, 241))},
            { PlayerColor.Inverted,        new SolidColorBrush(Color.FromRgb(47, 49, 49))},
            { PlayerColor.OddGreen,        new SolidColorBrush(Color.FromRgb(71, 126, 29))},
            { PlayerColor.Tigr,            new SolidColorBrush(Color.FromRgb(190, 190, 190))},
            { PlayerColor.Kigi,            new SolidColorBrush(Color.FromRgb(87, 87, 87))},
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
             var color = value as PlayerColor? ?? PlayerColor.Red;
             return BrushMapping[color];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class PlayerColorToBrushShaded : IValueConverter
    {
        public static Color shadeColor(Color inColor, float percent) {
            
            float R = (inColor.R * (100 + percent)) / 100;
            float G = (inColor.G * (100 + percent)) / 100;
            float B = (inColor.B * (100 + percent)) / 100;
            R = R < 255 ? R : 255;
            G = G < 255 ? G : 255;
            B = B < 255 ? B : 255;
            return Color.FromArgb(255, (byte) R, (byte) G, (byte) B);
        }

        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,              new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,             new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,            new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,             new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,           new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,           new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,            new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,            new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,           new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,            new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,             new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,             new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Maroon,           new SolidColorBrush(Color.FromRgb(95, 29, 46))},
            { PlayerColor.Rose,             new SolidColorBrush(Color.FromRgb(236, 192, 211))},
            { PlayerColor.Banana,           new SolidColorBrush(Color.FromRgb(240, 231, 168))},
            { PlayerColor.Gray,             new SolidColorBrush(Color.FromRgb(117, 133, 147))},
            { PlayerColor.Tan,              new SolidColorBrush(Color.FromRgb(145, 136, 119))},
            { PlayerColor.Coral,            new SolidColorBrush(Color.FromRgb(215, 100, 100))},
            { PlayerColor.Kusazungreen,     new SolidColorBrush(Color.FromRgb(8, 32, 55))},
            { PlayerColor.DarkRed,          new SolidColorBrush(Color.FromRgb(83, 0, 0))},
            { PlayerColor.MediumVioletRed,  new SolidColorBrush(Color.FromRgb(119, 12, 80))},
            { PlayerColor.MediumPurple,     new SolidColorBrush(Color.FromRgb(92, 67, 131))},
            { PlayerColor.RosyBrown,        new SolidColorBrush(Color.FromRgb(113, 86, 86))},
            { PlayerColor.DarkMagenta,      new SolidColorBrush(Color.FromRgb(83, 0, 83))},
            { PlayerColor.Olive,            new SolidColorBrush(Color.FromRgb(77, 77, 0))},
            { PlayerColor.SteelBlue,        new SolidColorBrush(Color.FromRgb(42, 78, 108))},
            { PlayerColor.DodgerBlue,       new SolidColorBrush(Color.FromRgb(18, 86, 153))},
            { PlayerColor.DarkSeaGreen,     new SolidColorBrush(Color.FromRgb(86, 113, 86))},
            { PlayerColor.Sikon,            new SolidColorBrush(Color.FromRgb(40, 26, 39))},
            { PlayerColor.Konjou,           new SolidColorBrush(Color.FromRgb(10, 26, 52))},
            { PlayerColor.Vermilion,        new SolidColorBrush(Color.FromRgb(152, 36, 28))},
            { PlayerColor.IvyGreen,         new SolidColorBrush(Color.FromRgb(46, 62, 31))},
            { PlayerColor.Tilleul,          new SolidColorBrush(Color.FromRgb(112, 123, 29))},
            { PlayerColor.Ivory,            new SolidColorBrush(Color.FromRgb(153, 153, 144))},
            { PlayerColor.Kenpou,           new SolidColorBrush(Color.FromRgb(29, 28, 26))},
            { PlayerColor.Grisbleu,         new SolidColorBrush(Color.FromRgb(97, 101, 112))},
            { PlayerColor.Melon,            new SolidColorBrush(Color.FromRgb(147, 105, 47))},
            { PlayerColor.Clan,             new SolidColorBrush(Color.FromRgb(0, 65, 61))},
            { PlayerColor.Shiraaiiro,       new SolidColorBrush(Color.FromRgb(184, 170, 182))},
            { PlayerColor.WhitePink,        new SolidColorBrush(Color.FromRgb(175, 131, 169))},
            { PlayerColor.ThinPurple,       new SolidColorBrush(Color.FromRgb(155, 151, 188))},
            { PlayerColor.Sienna,           new SolidColorBrush(Color.FromRgb(154, 64, 14))},
            { PlayerColor.LightAvocado,     new SolidColorBrush(Color.FromRgb(167, 189, 153))},
            { PlayerColor.LightIwaitya,     new SolidColorBrush(Color.FromRgb(120, 135, 121))},
            { PlayerColor.DiardRed,         new SolidColorBrush(Color.FromRgb(174, 254, 255))},
            { PlayerColor.DiardGreen,       new SolidColorBrush(Color.FromRgb(227, 125, 208))},
            { PlayerColor.DiardBlue,        new SolidColorBrush(Color.FromRgb(234, 168, 128))},
            { PlayerColor.Chaos,            new SolidColorBrush(Color.FromRgb(47, 49, 49))},
            { PlayerColor.Inverted,         new SolidColorBrush(Color.FromRgb(238, 239, 241))},
            { PlayerColor.OddGreen,         new SolidColorBrush(Color.FromRgb(108, 0, 124))},
            { PlayerColor.Tigr,             new SolidColorBrush(Color.FromRgb(244, 213, 49))},
            { PlayerColor.Kigi,             new SolidColorBrush(Color.FromRgb(243, 212, 175))},

        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as PlayerColor? ?? PlayerColor.Red;
            var mainColor = BrushMapping[color];
            var shaded = shadeColor(mainColor.Color, -20f);
            return new SolidColorBrush(shaded);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
