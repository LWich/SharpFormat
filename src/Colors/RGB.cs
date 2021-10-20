namespace CsharpFormat.src.Colors
{
    using System.Collections.Generic;
    public class RGB : IColor
    {
        private static Dictionary<int, string> _hexTable = new Dictionary<int, string> 
        {
            {0, "0"}, {1, "1"}, {2, "2"},
            {3, "3"}, {4, "4"}, {5, "5"}, 
            {6, "6"}, {7, "7"}, {8, "8"},
            {9, "9"}, {10, "A"}, {11, "B"},
            {12, "C"}, {13, "D"}, {14, "E"},
            {15, "F"}
        };

        private readonly byte _r, _g, _b;
        public byte R {get => _r;}
        public byte G {get => _g;}
        public byte B {get => _b;}

        public RGB(byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        public string GetHex()
        {
            string res = System.String.Empty;
            res += _hexTable[_r / 16];
            res += _hexTable[_r % 16];
            res += _hexTable[_g / 16];
            res += _hexTable[_g % 16];
            res += _hexTable[_b / 16];
            res += _hexTable[_b % 16];
            return res;
        }

        public static string GetHex(byte r, byte g, byte b)
        {
            string res = System.String.Empty;
            res += _hexTable[r / 16];
            res += _hexTable[r % 16];
            res += _hexTable[g / 16];
            res += _hexTable[g % 16];
            res += _hexTable[b / 16];
            res += _hexTable[b % 16];
            return res;
        }
    }
}