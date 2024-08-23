using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Presentation.POO
{
    public class Context
    {

        public List<Diplome> diplomes { get; } = new List<Diplome>();
        public List<Promotion> promotions { get; } = new List<Promotion>();
        public List<Eleve> eleves { get; } = new List<Eleve>();


        public Context()
        {
            Diplome DDWEB = new Diplome { code ="DDWEB" , libelle = "dev web" , Niveau = 5};
            Diplome DDMOBILE = new Diplome {code="DMOBILE" , libelle ="dev mobile" , Niveau=5};
            Diplome DML = new Diplome { code = "DML", libelle = "dev ML", Niveau = 6 };

            this.diplomes.Add(DDWEB);
            this.diplomes.Add (DDMOBILE);
            this.diplomes.Add(DML);


            // PROMO de DDWEB 
            Promotion DDWEB01 = new Promotion("WEB01", "Promo 01 du DEV WEB", DDWEB);
            Promotion DDWEB02 = new Promotion("WEB02", "Promo 02 du DEV WEB", DDWEB);
            Promotion DDWEB03 = new Promotion("WEB03", "Promo 03 du DEV WEB", DDWEB);
            Promotion DDWEB04 = new Promotion("WEB04", "Promo 04 du DEV WEB", DDWEB);
            Promotion DDWEB05 = new Promotion("WEB05", "Promo 05 du DEV WEB", DDWEB);
            promotions.Add(DDWEB01);
            promotions.Add(DDWEB02);
            promotions.Add(DDWEB03);
            promotions.Add(DDWEB04);
            promotions.Add (DDWEB05);

            // PROMO de DDMOBILE : 
            Promotion DMOBILE01 = new Promotion("MOBILE01", "Promo 01 du DEV Mobile", DDMOBILE);
            Promotion DMOBILE02 = new Promotion("MOBILE02", "Promo 02 du DEV Mobile", DDMOBILE);
            Promotion DMOBILE03 = new Promotion("MOBILE03", "Promo 03 du DEV Mobile", DDMOBILE);
            Promotion DMOBILE04 = new Promotion("Mobile04", "Promo 04 du DEV Mobile", DDMOBILE);
            Promotion DMOBILE05 = new Promotion("Mobile05", "Promo 05 du DEV Mobile", DDMOBILE);
            promotions.Add(DMOBILE01);
            promotions.Add(DMOBILE02);
            promotions.Add(DMOBILE03);
            promotions.Add(DMOBILE04);
            promotions.Add (DMOBILE05);

            // PROMO DU ML 
            Promotion ML01 = new Promotion("ML01", "ML 01", DML);
            Promotion ML02 = new Promotion("ML02", "ML 02", DML);
            Promotion ML03 = new Promotion("ML03", "ML 03", DML);
            Promotion ML04 = new Promotion("ML04", "ML 04", DML);
            Promotion ML05 = new Promotion("ML05", "ML 05", DML);
            promotions.Add(ML01);
            promotions.Add(ML02);
            promotions.Add(ML03);
            promotions.Add(ML04);
            promotions.Add(ML05);


            var faker = new Faker("fr");
            Random rdm = new Random();

            foreach (var promotion in promotions)
            {
                int nb = rdm.Next(8, 22);

                for (int i = 0; i < nb; i++)
                {
                    var eleve = new Eleve(faker.Name.LastName() , faker.Name.FirstName(), promotion);
                    eleves.Add(eleve);
                }
                    
            }






        }
    }
}
