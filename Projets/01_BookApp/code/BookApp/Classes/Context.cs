using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Classes
{
    public class Context
    {

        public Biblo biblo;

        public List<Etudient> etudients =new List<Etudient>();
        public List<Emprunte> empruntees =new List<Emprunte>();



        public Context()
        {
            biblo = new Biblo("biblo1", "20 Rue zatar");

            int nb = 20;

            for (int i = 0; i < nb; i++)
            {

                Livre livre = new Livre(i, $"livre {i}", true);
                biblo.AddLivre(livre);
                    
                
                Etudient e = new Etudient($"Nom {i}", $"Prenom {i}", $"Mat{i}");
                etudients.Add(e);
                List<Livre> livres = new List<Livre>();
                livres.Add(livre);

                empruntees.Add(new Emprunte(1, new DateTime(2023, 5, 5), new DateTime(2023, 5, 25), e , livres));

  
            }





        }

        public void ShowAllComondes()
        {
            Console.WriteLine("========== BienVenue dans votre gestionnaire des livres =================");
            Console.WriteLine("Press 1 : to select a biblo ");
            Console.WriteLine("Press 2 : to see all books  ");
            Console.WriteLine("Press 3 : to select a book ");
            Console.WriteLine("Press M : to show menu  ");
            Console.WriteLine("Press Q : quit ");


        }

        public void showAllBiblo()
        {
            Console.WriteLine($"-  {biblo.ToString()}");

        }

        public void showAllBooks()
        {
            biblo.livres.ForEach(l => Console.WriteLine($"- {l.ToString()}"));
        }


        public bool ProcedureEmprunt()
        {
            bool isValide = false;
            string  input;
            Console.WriteLine("Ecrivez svp l'id de livre que vous souhaitez emprunter :");
            input = Console.ReadLine();
            int id; 
            try
            {
                id = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ecrivez un id valide svp :");
            }



            return isValide; 

        }



        public int nbLivres()
        {
            bool isNotValide = true;
            string input;
            int nbLivres = 0 ;
            int nb = 0;
            do
            {
                if(nb==0)
                    Console.ReadLine();
                nb++;
                //Console.Clear();
                Console.WriteLine("Ecrivez le nombre de livres que vous voulez emprunter :");
                input = Console.ReadLine();
                try
                {
                    nbLivres = int.Parse(input);
                    isNotValide=false;
                }
                catch (Exception e)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ecrivez un nombre Valide svp  :");
                    Console.ResetColor();
                }


            } while (isNotValide);


            return nbLivres; 
        }


        

    }
}
