using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
   public class MyContext :DbContext
    {
        //ctor+double tab
        //public MyContext() : base("mabase_4sim4")//le nom de la base de donnees
        //{

        //}
        public MyContext() : base("name=MaChaine")//le nom de la chaine : app.config de projet de démarrage
        {

        }
        public DbSet<Product> Products { get; set; }//1 seule table pour 3 classes(product+chemical+biological)
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
