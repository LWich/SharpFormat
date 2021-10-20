namespace CsharpFormat.src
{
    using System.IO;

    public static class StreamHelper
    {
        public static void WriteBigEndianInt32(Stream stream, int value)
        {
            stream.WriteByte((byte) (value >> 24));
            stream.WriteByte((byte) (value >> 16));
            stream.WriteByte((byte) (value >> 8));
            stream.WriteByte((byte) value);
        }
    }
}