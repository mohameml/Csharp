using BookApp.Classes;

namespace BookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.ShowAllComondes();

            bool notQuit = true; 
            
            do
            {
                char input;

                input = (char)Console.Read();

                switch (input)
                {
                    case '1':
                        context.showAllBiblo();
                        int nb = context.nbLivres();
                        Console.WriteLine(nb);
                        break;
                    case '2':
                        Console.WriteLine(input); break;
                    case '3':
                        Console.WriteLine(input); break;
                    case 'Q':
                        notQuit = false;
                        break;
                    case 'M':
                        Console.Clear();
                        context.ShowAllComondes();
                        break;
                    default:
                        break;
                }


            } while (notQuit);



        }

    }
}
