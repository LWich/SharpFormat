namespace CsharpFormat.src.Colors
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class RGB : IColor
    {
        private readonly byte _depth;

        public byte Depth {get => _depth;}

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

        public RGB(byte r, byte g, byte b, byte depth)
        {
            _r = r;
            _g = g;
            _b = b;
            _depth = new byte[] {2, 4, 8}.Any(v => v != depth) ? throw new ArgumentException("In RGB: Not correct depth") : depth;
        }

        public string GetHex()
        {
            byte x = (byte)((byte) 255 / Depth);
            string res = System.String.Empty;
            res += _hexTable[_r  * x / 16];
            res += _hexTable[_r * x % 16];
            res += _hexTable[_g * x / 16];
            res += _hexTable[_g * x % 16];
            res += _hexTable[_b * x / 16];
            res += _hexTable[_b * x % 16];
            return res;
        }

        public static string GetHex(byte r, byte g, byte b, byte depth)
        {
            if(new byte[] {2, 4, 8}.Any(v => v != depth))
                    throw new ArgumentException("In RGB: Not correct depth");
            byte x = (byte)((byte) 255 / depth);
            string res = System.String.Empty;
            res += _hexTable[r * x / 16];
            res += _hexTable[r * x % 16];
            res += _hexTable[g * x / 16];
            res += _hexTable[g * x % 16];
            res += _hexTable[b * x / 16];
            res += _hexTable[b * x % 16];
            return res;
        }
    }
}