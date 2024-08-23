// See https://aka.ms/new-console-template for more information
namespace menuUser
{


    internal class Program
    {


        // message de bienvenu pour l'utilisateur 

        static void CorrEx01()
        {
            string choix = "";
            string[] choixAut = { "1", "2" };
            string nom = "";
            do
            {
                Console.Clear();

                if (!string.IsNullOrEmpty(choix) && !choixAut.Contains(choix))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"votre choix :{choix} n'est pas autoriser");
                    Console.ResetColor();
                }
                // Affichage de regles : 
                Console.WriteLine("=========== Rgles de jeux =========");
                Console.WriteLine("1 => Saisie de nom.");
                Console.WriteLine("2 => Affichae d'un message.");
                Console.WriteLine("Q => pour quitez le jeux.");
                Console.Write("choix :");
                choix = Console.ReadLine();
                Console.WriteLine($"votre choix était :{choix}");
                switch (choix)
                {
                    case "1":
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("========== Choix du Nom ============");
                            Console.Write("Tapez votre nom :");
                            nom = Console.ReadLine();
                        } while (string.IsNullOrEmpty(nom));
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("choix 2");
                        if (string.IsNullOrEmpty(nom))
                        {
                            Console.Write("Salut , nom inconnu");
                        }
                        else
                        {
                            Console.Write($"Salut {nom}");
                        }
                        Console.Read();
                        break;

                    default:
                        break;

                }
            }
            while (string.IsNullOrEmpty(choix) || !choix.Equals("Q"));
        }



        static void Main(string[] args)
        {
            CorrEx01();
        }
    }
}
