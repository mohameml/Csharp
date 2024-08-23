using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Classes
{
    public class Livre
    {
        public int id {  get; set; }
        public string title { get; set; }
        public string auteur { get; set; }
        public bool isDispo {  get; set; }



        public Livre() { }

        public Livre(int id, string title, bool isDispo)
        {
            this.id = id;
            this.title = title;
            this.isDispo = isDispo;
        }



        public override bool Equals(object? obj)
        {
            
            if(obj is  Livre l)
            {
                return id == l.id; 
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;


            hash = hash * 23 + id;
        
            return hash;
        }


        public override string ToString()
        {


            string str = $"Livre : {id} {title}";

            str += isDispo ? "Disponible" : "non disponible";
            return str; 
        }

    }
}
