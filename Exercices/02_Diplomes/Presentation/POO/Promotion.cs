using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.POO
{
    public class Promotion
    {

        public string code {  get; init; }
        public string name { get; init; }


        public List<Eleve> Eleves { get;  } = new List<Eleve>();
        public Diplome diplome { get; init; }


        public Promotion(string code  , string name , Diplome d)
        {
            this.code = code;
            this.name = name;
            this.diplome = d;
            diplome.Promotions.Add(this);
        }


        public void AddEleve(Eleve e)
        {
            if(e== null) throw new ArgumentNullException("e");
            if (this.Eleves.Contains(e)) return;
            this.Eleves.Add(e);
        }

        public void RemoveEleve(Eleve e)
        {
            if(e== null) throw new ArgumentNullException("e");
            if (!this.Eleves.Contains(e)) return;
            this.Eleves.Remove(e);
        }
 
        public override string ToString()
        {

            return $"{code} : (${name})";
        }


        public override bool Equals(object? obj)
        {
            if (obj is Promotion d)
            {
                return d.code.Equals(this.code);
            }


            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (code?.GetHashCode() ?? 0);

            return hash;

        }
    }
}
