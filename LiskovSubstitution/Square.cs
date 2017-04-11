namespace LiskovSubstitution
{
    public class Square : Shape
    {
        public int SideLength;

        public int Area()
        {
            return SideLength * SideLength;
        }
    }
}