using MyFinance.Data;
using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service.Repositories
{
   public class ProviderRepository
    {
        private MyContext myContext;

        public ProviderRepository()
        {
             myContext = new MyContext();

        }

        public bool IsApproved { get; set; }

        public void AddProvider(Provider prov)
        {
            myContext.Providers.Add(prov);
            myContext.SaveChanges();
        }
        public IEnumerable<Provider> GetProviders()
        {
            return myContext.Providers;
        }
       public bool SetIsApproved(Provider P)
        {
           return P.IsApproved=string.Compare(P.Password,P.ConfirmPassword)==0;
        }
        public string SetIsApproved(string password, string confirmPassword, bool isApproved) 
        {
            this.IsApproved = string.Compare(password,confirmPassword) == 0;
            return "password : " + password + " confirmPassword : " + confirmPassword + " IsApproved : " + IsApproved;
        }
   
        public bool login(string login, string password)
        {
            //recupre a partire de la base de données
            foreach(Provider p in GetProviders())
            {
                if (p.UserName == login && p.Password == password)
                    return true;
            }
            return false;
        }

        public Provider GetProviderById(int ID)
        {
            return myContext.Providers.Find(ID);

        }
        public bool login(string login, string password, int id)
        {
            Provider test = GetProviderById(id);
            if (test.UserName == login && test.Password == password)
                return true;
            else
            return false;

        }
    }
   
}
