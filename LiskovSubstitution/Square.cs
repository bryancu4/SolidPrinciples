namespace LiskovSubstitution
{
    public class Square : Shape
    {
        public int SideLength;

        public override int Area()
        {
            return SideLength * SideLength;
        }
    }
}