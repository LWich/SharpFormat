namespace CsharpFormat.src
{
    using System.IO;

    public interface ITag
    {
        int Name {get;}
        TagsBuilder Builder {get;}

        void Init(Stream stream);
    }
}