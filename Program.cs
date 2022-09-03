namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Program");

            Console.WriteLine("Enter the program number \n 1. Enter the satrting position \n 2. Check the number on die \n 3.checking the Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                  
                  UC1Startingpoint.startPosition();
                    break;
                case 2:
                    UC2DieCheck.dieCheck(); 
                    break;
                    case 3:
                    UC3Option_Check.Checkoption();
                    break;
            }
        }
               
        }
    }
