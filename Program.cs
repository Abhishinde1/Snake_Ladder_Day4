namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Program");

            Console.WriteLine("Enter the program number \n 1. Enter the satrting position  2. Check the number on die");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                  
                  UC1Startingpoint.startPosition();
                    break;
                case 2:
                    UC2DieCheck.dieCheck(); 
                    break;
            }
        }
               
        }
    }
