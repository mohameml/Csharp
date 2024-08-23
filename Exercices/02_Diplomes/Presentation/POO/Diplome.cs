using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.POO
{
    public class Diplome
    {

        public string code { get; init; }
        public string libelle { get; init; }

        public int Niveau { get; init; }


        public List<Promotion> Promotions { get;  } = new List<Promotion>();

        public Diplome() {
        
        }

        public Diplome(string code , string libelle , int niveau)
        {
            this.code = code;
            this.libelle = libelle;
            this.Niveau = niveau;

        }



        public void  AddPromotion(Promotion pro)
        {
            if(pro == null) throw new ArgumentNullException("pro est nill");
            if (this.Promotions.Contains(pro)) return;
            this.Promotions.Add(pro);
            

        }

        public void RemovePromotion (Promotion pro)
        {
            if (pro == null) throw new ArgumentNullException("pro est null");
            if (!this.Promotions.Contains(pro)) return;
            this.Promotions.Remove(pro);
        }
        public override string ToString()
        {

            return $"{code} : (${libelle})";
        }


        public override bool Equals(object? obj)
        {
            if (obj is Diplome d)
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
