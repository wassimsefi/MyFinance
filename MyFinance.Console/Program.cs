using MyFinance.Data;
using MyFinance.Domain.Entites;
using MyFinance.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //avec un constructeur
            Product prod = new Product(12, 999, 5014, DateTime.Now, "myProd", "new prod");
            System.Console.WriteLine("my product name is : " + prod.Name);
            System.Console.WriteLine(prod.ToString());
            //avec initialiseur d'objet
            Product prod2 = new Product
            {
                Name = "mySecondProd",
                Quantity = 100
            };
            System.Console.WriteLine("my second prod name is " + prod2.Name);
            Chemical chem = new Chemical
            {
                Price = 100,
                Name = "Chemical product",
                DateProd = new DateTime(2020, 10, 01),
                City = "Ghazela"
            };

            Biological biological = new Biological
            {
                Herbs = "herbs",
                DateProd = new DateTime(2020, 10, 01),
                Name="bio pruduct"

            };
            //ToString()
            System.Console.WriteLine(" chemical prod " + chem.ToString());

            /*//sans la chouche service
            //Création de la base de données
            MyContext myContext = new MyContext();
            myContext.Products.Add(prod);//ajout du product au DbSet<Products>
            myContext.Products.Add(chem);
            myContext.Products.Add(biological);

            myContext.SaveChanges();//synchronisation avec la base 
            System.Console.WriteLine(" product added successfully");*/
            //avec la couche service
            Provider prov = new Provider
            {
                UserName = "wassim",
                Email = "wassim@esprit.tn",
                Password = "12345",
                ConfirmPassword = "12345",
                IsApproved = false
                           
            };
            ProviderRepository provRepo = new ProviderRepository();
            provRepo.AddProvider(prov);
            foreach(Provider p in provRepo.GetProviders())
            {
                System.Console.WriteLine("My Provider ="+p.UserName);
            }

            //passage par  reference
            System.Console.WriteLine(prov.Password+"  "+prov.ConfirmPassword);
            System.Console.WriteLine(provRepo.SetIsApproved(prov)); 
            //passage par valeur
            System.Console.WriteLine(provRepo.SetIsApproved("123", "123", false));

            System.Console.WriteLine("Fin");
            System.Console.ReadKey();

            //Polymorphisem
           // System.Console.WriteLine(prod.GetType);
        }
    }
}
