using System;
using CsharpFormat.src.Colors;
using CsharpFormat.src.Header;
using CsharpFormat.src;
using CsharpFormat.src.Create;
using System.IO;

namespace CsharpFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            CSFBuilder builder = new CSFBuilder(new Head(100, 100, ColorType.RGB, 2));
            using(FileStream fs = new FileStream("photo.csf", FileMode.OpenOrCreate))
            {
                builder.Create(fs);
            }
        }
    }
}
