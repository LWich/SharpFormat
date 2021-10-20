namespace CsharpFormat.src.Header
{
    using System.IO;

    public class Head : ITag
    {
        public int Name {get => 0x435346;}// CSF (4 bytes)
        public TagsBuilder Builder {get;} = new TagsBuilder();

        public Head()
        {
            Builder.Add(this);
        }

        public void Init(Stream stream)
        {
            StreamHelper.WriteBigEndianInt32(stream, Name);// Name
        }
    }
}