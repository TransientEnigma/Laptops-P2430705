using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanzebsLaptopShop
{
    [Serializable()]
    class Apple : Laptop
    {
        //the constructor is chained to base class
        public Apple(string name, string brand, Condition condition, decimal originalPrice, DateTime releaseDate)
                          :base(name,        brand,           condition,         originalPrice,          releaseDate)
        {
            //No new attributes added to constructor, so its blank here.
        }

        //overriding the abstract function of the base class
        public override decimal CalculateApproximateValue()
        {
            //initialise a decimal called value with 0
            decimal price = 0;

            //if the laptop condition is poor then its value drops to 50% of original price
            if(condition == Condition.poor)
            {
                price = originalPrice * 0.5m;
            }
            //if the laptop condition is fair then its value drops to 70% of original price
            if (condition == Condition.fair)
            {
                price = originalPrice * 0.7m;
            }
            //if the laptop condition is good then its value drops to 80% of original price
            if (condition == Condition.good)
            {
                price = originalPrice * 0.7m;
            }
            //if the laptop condition is mint then its value drops to 70% of original price
            if (condition == Condition.mint)
            {
                price = originalPrice * 0.9m;
            }

            //for each year of the laptops age (i.e. years since release date), 
            //the laptop loses a further 10% or put it another way we keep 90% (or 0.9)
            for (int i = 0; i < CalculateAgeInYears(); i++)
            {
                price = price * 0.9m;
            }

            //round to the nearest pound
            price = Decimal.Round(price, 0);

            //return the new calculated price of the laptop
            return price;
        }

    }
}
