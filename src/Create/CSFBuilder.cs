namespace CsharpFormat.src.Create
{
    using System.IO;
    using Header;

    public class CSFBuilder
    {
        private TagsBuilder _builder = new TagsBuilder();
        private Head _head;
        private const int SIGNATURE = 0x435346;

        public CSFBuilder(Head header)
        {
            _head = header;
        }

        public void Create(Stream stream)
        {
            StreamHelper.WriteBigEndianInt32(stream, SIGNATURE);
            stream.WriteByte((byte)0x0A);
            foreach(ITag tag in _builder)
            {
                tag.Init(stream);
            }
        }
    }
}