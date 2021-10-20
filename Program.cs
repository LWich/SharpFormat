using System;
using CsharpFormat.src.Colors;
using CsharpFormat.src.Header;
using CsharpFormat.src;

namespace CsharpFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Head head = new Head();
            TagsBuilder tagsBuilder = new TagsBuilder();
            tagsBuilder.Add(head);
            foreach(var tag in tagsBuilder)
            {
                Console.WriteLine(tag);
            }
        }
    }
}
