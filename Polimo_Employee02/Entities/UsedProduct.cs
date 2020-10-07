using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Polimo_Employee02.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufaturedDate { get; set; }


        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufaturedDate) : base(name, price)
        {
            ManufaturedDate = manufaturedDate;
        }

        public override string PriceTag()
        {
            return Name
                +" (used) $"
                +Price.ToString("F2", CultureInfo.InvariantCulture)
                +" (Manufatured date: "
                +ManufaturedDate;
        }

    }
}
