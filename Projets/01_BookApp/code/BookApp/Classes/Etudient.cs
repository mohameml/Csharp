using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Classes
{
    public  class Etudient
    {

        public string nom {  get; set; }

        public string prenom { get; set; }

        public string matricule { get; set; }


        public Etudient() { }

        public Etudient(string nom, string prenom, string matricule)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.matricule = matricule;
        }


        public override bool Equals(object? obj)
        {
            if (obj is Etudient e) 
            { 
                return this.matricule.Equals(e.matricule);
                
            }

            return false;
        
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = 23*hash + (nom?.GetHashCode() ?? 0);
            hash = 23*hash + (prenom?.GetHashCode() ?? 0);
            hash = 23*hash + (matricule?.GetHashCode() ?? 0);
            
            return hash;
        }


        public override string ToString()
        {

            return $"Etudient : {nom} {prenom} ({matricule})";
        }


    }
}
