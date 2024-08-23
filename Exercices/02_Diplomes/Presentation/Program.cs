using Presentation.POO;

namespace Presentation
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Context context = new Context();

            // nombre de promotion pour chaque diplomes : 
            Console.WriteLine("========== nombre de promotion pour chaque diplomes ==========");

            // Solution 1 : 
            var liste1 = context.diplomes.Select(d => new { d.libelle, pros = d.Promotions.Count() }).ToList();

            liste1.ForEach(d => Console.WriteLine($"- {d.libelle} : {d.pros}"));

            // SOlution 2 : 
            var nbPromosParDiplomes = context.promotions.GroupBy(pro => pro.diplome, pro => pro, (diplome, pros) => new { libelle = diplome.libelle, nb = pros.Count() }).ToList();
            nbPromosParDiplomes.ForEach(d => Console.WriteLine($"- {d.libelle} : {d.nb}"));


            // Q2 : nombres des eleves par chaque diplomes :

            Console.WriteLine("========== Nb d'eleves par dipolmes ============");
            Console.WriteLine("======== Solution 1 :================");
            var nbElevesParPromo = context.eleves.GroupBy(e => e.Promotion , e => e , (pro, eleves) => new {promo = pro , nbElves = eleves.Count()  }).ToList() ;
            //nbElevesParPromo.ForEach(d => Console.WriteLine($"- {d.promo.name} : {d.nbElves}"));

            var nbElevesParDiplome = context.eleves.GroupBy(e => e.Promotion.diplome, e => e, (d, es) => new {diplome = d.libelle ,nb = es.Count() }).ToList();

            nbElevesParDiplome.ForEach(d => Console.WriteLine($"- {d.diplome} : {d.nb}"));

            Console.WriteLine("== Solution 2:===");

            var Sol2 = context.diplomes.
                                Select(d => new {diplome = d.libelle , Eleves = d.Promotions.Sum(p => p.Eleves.Count())}).
                                ToList();
            Sol2.ForEach(d => Console.WriteLine($"- {d.diplome} :{d.Eleves}"));

            // Q3 : Promotion du diplomes DDWEB:
            Console.WriteLine("==== Promotions du diplome DDWEB ===========");
            var PromotionsDDWED = context.promotions.Where(p => p.diplome.code.Equals("DDWEB")).ToList();
            PromotionsDDWED.ForEach(e => Console.WriteLine($"{e.code}"));

            // Q4 : dernier Elves de la prom DDWEB : 

            var dernierEleveDDWEB = PromotionsDDWED.Last().Eleves.Last();

            Console.WriteLine(dernierEleveDDWEB.ToString());

        }





            ///  <summary>fonction static : add</summary>
            ///  <param name="a">a</param>


            #region AddReg 
            static int add(int a , int b)
        {
            return a + b; 
        }
        #endregion

        #region a 
        static void  DireBonjour (string civi , string msg)
        {
            string res = civi switch
            {
                "M" => "Monsier",
                "MME" => "Madame",
                _ => "Mre y7chmak"

            };

            Console.WriteLine($"Bonjour {res} , {msg}");






        }
        #endregion



        #region b
        static void CorrEx01()
        {
            string choix = "";
            string[] choixAut = ["1", "2"];
            string nom = "";
            do
            {
                Console.Clear();

                if(!string.IsNullOrEmpty(choix) && !choixAut.Contains(choix) )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"votre choix :{choix} n'est pas autoriser");
                    Console.ResetColor();
                }
                // Affichage de regles : 
                Console.WriteLine( "=========== Rgles de jeux =========");
                Console.WriteLine("1 => Saisie de nom." );
                Console.WriteLine("2 => Affichae d'un message.");
                Console.WriteLine("Q => pour quitez le jeux.");
                Console.Write("choix :");
                choix = Console.ReadLine();
                Console.WriteLine($"votre choix était :{choix}");
                switch(choix)
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
                        if(string.IsNullOrEmpty(nom))
                        {
                            Console.Write("Salut , nom inconnu");
                        } else
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
        #endregion 


    }
}
