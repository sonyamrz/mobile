namespace cnsEnum
{
    internal class Program
    {
        public enum SingleColor { Red, Green, Blue = 100500 }

        static void Main(string[] args)
        {
            SingleColor singleColor = SingleColor.Red;
            Console.WriteLine(singleColor);
            Console.WriteLine(singleColor.ToString("D"));
            singleColor = SingleColor.Blue;
            Console.WriteLine(singleColor.ToString("D"));


        }
    }
}