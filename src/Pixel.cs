namespace CsharpFormat.src
{
    using Colors;

    public class Pixel
    {
        private readonly uint X;
        private readonly uint Y;
        private readonly IColor Color;

        public Pixel(uint x, uint y, IColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}