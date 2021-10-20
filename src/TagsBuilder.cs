namespace CsharpFormat.src
{
    using System.Collections;
    public class TagsBuilder : IEnumerable
    {
        static ITag[] Tags = new ITag[0];

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach(var tag in Tags)
            {
                yield return tag;
            }
        }
        
        public void Add(ITag tag)
        {
            ITag[] bait = new ITag[Tags.Length + 1];
            for(int i = 0; i < Tags.Length; i++)
                bait[i] = Tags[i];
            bait[Tags.Length] = tag;
            Tags = null;
            Tags = bait;
        }

        public void Remove()
        {
            ITag[] bait = new ITag[Tags.Length - 1];
            for(int i = 0; i < Tags.Length - 1; i++)
                bait[i] = Tags[i];
            Tags = null;
            Tags = bait;
        }

        public ITag this[int i]
        {
            get=>Tags[i];
        }
    }
}