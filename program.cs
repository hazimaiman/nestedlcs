
namespace MyFirstProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("HOW MANY ROWS?: ");
             int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("HOW MANY COLUMNS?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("WHAT SYMBOL?: ");
            String symbol = Console.ReadLine();


            for (int i = 0; i < rows; i ++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            }
        }
    }





  
