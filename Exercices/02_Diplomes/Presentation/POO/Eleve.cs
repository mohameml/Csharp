using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.POO
{
    public class Eleve
    {

        public string Nom {  get; init; }
        public string Prenom { get; init; }
        public Promotion Promotion { get; init; }



        public Eleve()
        {

        }

        public Eleve(string nom , string prenom , Promotion pro)
        {
            Nom = nom;
            Prenom = prenom;
            Promotion = pro;
            pro.Eleves.Add(this);
        }


        public override string ToString()
        {
            return $"{Prenom} {Nom} ({Promotion.diplome.libelle} , promotion {Promotion.code})";
        }

        public override bool Equals(object? obj)
        {
        
            if(obj is Eleve e)
            {
                return e.Nom.Equals(this.Nom) && e.Prenom.Equals(this.Prenom) ;
            }

            return false ;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash = 23* hash + (Nom?.GetHashCode() ?? 0);
            hash = 23 * hash + (Prenom?.GetHashCode() ?? 0);

            return hash;
        }

    }
}


