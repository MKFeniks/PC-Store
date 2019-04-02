using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStore.Classes
{
    class Module:Part
    {
       List<Part>PartList { get; set; }



        public Module(string name)
        {
            Name = name;
        }

        
        public int FullPrice { get; set; }

        public int Quantity { get; set; }
        public void AddPartToModule(Part p, int quantity)
        {
            PartList.Add(p);
            Quantity = quantity;

        }



        public double GetPrice()
        {
            double sum = 0;

            foreach (var part in PartList)
            {
                sum += part.Price;

            }
            return sum;
        }


        public double DiscountPrice { get; set; }
        public double Discount { get; set; }

        public double SetDiscount(double discount)
        {
            return Discount = discount;

        }

        public double GetPriceWithDiscount()
        {
           return DiscountPrice =FullPrice-(FullPrice * (Discount / 100));

        }
    }
}
