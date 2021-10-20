namespace CsharpFormat.src.Header
{
    using System.IO;
    using Colors;
    using System.Linq;
    using System;

    public class Head : ITag
    {
        // public int Name {get => 0x435346;}// CSF (4 bytes)
        public int Name {get => 0x48656164;}
        public ushort Width {get;}// Width photo(2 byte)
        public ushort Heidth {get;}// Height photo(2 byte)
        public ColorType Color {get;}
        public byte Depth {get;}

        public TagsBuilder Builder {get;} = new TagsBuilder();

        public Head(ushort width, ushort height, ColorType color, byte depth)
        {
            if(!(new byte[] {2, 4, 8}.Any(v => v == depth)))
                    throw new ArgumentException("In Head: Not correct depth");
            Color = color;
            Width = width;
            Heidth = height;
            Depth = depth;
            Builder.Add(this);
        }

        public void Init(Stream stream)
        {
            StreamHelper.WriteBigEndianInt32(stream, Name);
            StreamHelper.WriteLittleEndianInt16(stream, Width);
            StreamHelper.WriteLittleEndianInt16(stream, Heidth);
            stream.WriteByte((byte) Color);
            stream.WriteByte((byte) Depth);
        }
    }
}