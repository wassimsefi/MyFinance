using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entites
{
    public class Chemical : Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAdress { get; set; }
        public Chemical() : base()
        {

        }

        public Chemical(int productId, int quantity, double price, DateTime dateProd, string description, string name, // props of the base "Product"
            string city, string labName, string streetAdress //props of Chemical
            ) : base(productId, quantity, price, dateProd, description, name/*Construct Product*/)
        {
            City = city;
            LabName = labName;
            StreetAdress = streetAdress;
        }
        public override string ToString()
        {
            return base.ToString()
                + " City: " + City
                + " LabName: " + LabName
                + " StreetAdress: " + StreetAdress;
        }
    
}
}
