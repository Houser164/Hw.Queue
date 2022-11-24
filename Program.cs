class Program
{
    static void Main(string[] args)
    {

        Queue<char> FP = new Queue<char>(); 

        while (true)
        {
            Console.WriteLine("Input your fruit size (S/M/L)");
            char FruitSize = char.Parse(Console.ReadLine());

            if (FruitSize != 'S' && FruitSize != 'M' && FruitSize != 'L')
            {
                break;
            }

            else
            {
                FP.Push(FruitSize);
            }
        }

        while (true)
        {
            char FX = FP.Pop();

            if (FX == 'L' )
            {
                Console.Write("1");
                FP.Push('M'); 
                FP.Push('M');
            }

            else if (FX == 'M' )
            {
                Console.Write("2");
                FP.Push('S'); 
                FP.Push('S');
                FP.Push('S');
            }

            else if (FX == 'S' )
            {
                Console.Write("3");
            }
            
            if (FP.GetLength() == 0)
            {
                break;
            }
        }
    }
}