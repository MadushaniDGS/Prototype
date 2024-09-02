namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle("red", 20);
            circle.Draw();

            Circle circleCopy = (Circle)circle.Clone();
            circleCopy.size = 10;
            circleCopy.Draw();
        }
    }
}