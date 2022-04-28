namespace BranchingExample
{
    public class Program
    {
        public static void Main()
        {

            Dungeon d = new Dungeon("The sock drawer of dark and evil magics", 11);
            Console.WriteLine(d.Name);

            Treasure t = new Treasure(1000, "Silver");

        }
    }
}

