using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Classes
{
    public class Emprunte
    {
        public int id { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set;}

        public Etudient e {  get; set; }

        public List<Livre> livres { get; set; } = new List<Livre>();


        public Emprunte() { }

        public Emprunte(int id, DateTime dateDebut, DateTime dateFin, Etudient e , List<Livre> livres)
        {
            this.id = id;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.e = e;

            foreach (var livre in livres)
            {
                if(!livre.isDispo)
                {
                    this.livres.Add(livre);
                    livre.isDispo = false;
                    // throw new Exception("ce livre n'est pas disponible pour le moment");
                }
                
            }
        }

        public void AddLivre(Livre livre)
        {
            this.livres.Add(livre);
        }


        public override bool Equals(object? obj)
        {
            if(obj is Emprunte e)
            {
                return id == e.id;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Emprunte de id {id} à la date  {dateDebut.ToString()} pour l'etudient {e.ToString()}";

        }










    }
}
