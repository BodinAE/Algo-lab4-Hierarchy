namespace Algo_lab4_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var test = new Rectangle("Rect1", 0, 0, 2, 6);
            //test.Print();
            //Console.WriteLine("---------");
            //var sq1 = new Square("Sqar1", 0, 0, 10);
            //sq1.Print();
            var lin = new Line("Lin1", 0, 0, 3, 4);
            var lin2 = new Interval("Int1", 0, 0, 3, 4);
            lin.Print();
            lin2.Print();
        }
    }
}
