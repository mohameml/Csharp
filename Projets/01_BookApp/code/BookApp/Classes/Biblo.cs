using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Classes
{
    public class Biblo
    {
        public string nom { get; set; }

        public string adress { get; set; }

        public List<Livre> livres { get; set; } = new List<Livre>();

        
        public Biblo() { }

        public Biblo(string nom)
        {
            this.nom = nom; 
        }

        public Biblo(string nom , string adress) 
        {
            this.nom = nom;
            this.adress = adress;
        }


        public void AddLivre(Livre livre)
        {
            if (livre == null) throw new Exception("Impossible d'ajouter null comme livre");

            if(!livres.Contains(livre))  this.livres.Add(livre);
        
        }

        public override bool Equals(object? obj)
        {
            if(obj is Biblo b )
            {
                return this.nom.Equals(b.nom);
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = 23 * hash + (nom?.GetHashCode() ?? 0);
            hash = 23*hash + (adress?.GetHashCode() ?? 0);
            return hash;
        }


        public override string ToString()
        {
            return $"Biblo {nom} ({adress})";
        
        }
    }
}
