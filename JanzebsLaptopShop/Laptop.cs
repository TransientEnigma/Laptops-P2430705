using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanzebsLaptopShop
{        /******************************************** SERIALIZATION *********************************************************************/
         //https://stackoverflow.com/questions/5877808/what-is-serializable-and-when-should-i-use-it/5877839
         /*************************************** What is it? ***********************************************************************/
         //When you create an object in a.Net framework application, you don't need to think about how the data is stored in memory. Because the .Net Framework takes care of that for you. 
         //However, if you want to store the contents of an object to a file, send an object to another process or transmit it across the network, you do have to think about how the object 
         //is represented because you will need to convert to a different format. This conversion is called SERIALIZATION. 
         /********************************* Uses for Serialization ******************************************************************/
         //Serialization allows the developer to save the state of an object and recreate it as needed, providing storage of objects as well as data exchange.Through serialization, 
         //a developer can perform actions like sending the object to a remote application by means of a Web Service, passing an object from one domain to another, passing an object through a 
         //firewall as an XML string, or maintaining security or user-specific information across applications. 
         //Apply SerializableAttribute to a type to indicate that instances of this type can be serialized. 
         //Apply the SerializableAttribute even if the class also implements the ISerializable interface to control the serialization process. 
         //All the public and private fields in a type that are marked by the SerializableAttribute are serialized by default, unless the type 
         //implements the ISerializable interface to override the serialization process.The default serialization process excludes fields that are marked with NonSerializedAttribute.
         //If a field of a serializable type contains a pointer, a handle, or some other data structure that is specific to a particular environment, and cannot be meaningfully 
         //reconstituted in a different environment, then you might want to apply NonSerializedAttribute to that field.
         //See MSDN for more details.
         /************************************************************************************************************************************/

    //Summarizaton of what it is: basically use serialisation in a class when you want to serialize objects(convert to serial  binary data)  of the class so you can save the information save information

    [Serializable()]
    //Laptop is an abstract base class; we derive Apple and HP from
    public abstract class Laptop : IComparable
    {
        //Each laptop will be in a certain condition (or rating)
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        };

        //the laptop will have the following attributes
        //protected access modifier so access by the same/derived class
        protected string name;
        protected string brand;
        protected decimal originalPrice;
        protected DateTime releaseDate;
        protected Condition condition;

        //Constructor for the laptop class
        public Laptop(string name, string brand, Condition condition,  decimal originalPrice, DateTime releaseDate)
        {
            //relates to the current class variables
            this.name = name;
            this.brand = brand;
            this.originalPrice = originalPrice;
            this.releaseDate = releaseDate;
            this.condition = condition;
        }

        /**************** Not required ********************/
        //Gets the name of the laptop
        public string GetName()
        {
            //we can get the name of the Laptop
            return name;
        }
        public void SetName(string name)
        {
            //we can set the name of the name
            this.name=name;
        }


        //function that returns the brand of the Laptop
        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string brand)
        {
            //we can get the name of the enumeration for the given rating number
            this.brand = brand;
        }


        //Gets the condition of the laptop
        public Condition GetCondition()
        {
            //we can get the name of the enumeration for the given rating number
            return condition;
        }
        public void SetCondition(Laptop.Condition condition)
        {
            //we can get the name of the enumeration for the given rating number
            this.condition = condition;
        }


        //function that returns the OriginalPrice of the Laptop
        public Decimal OriginalPrice()
        {
            return originalPrice;
        }
        public void SetOriginalPrice(decimal originalPrice)
        {
            //we can get the name of the enumeration for the given rating number
            this.originalPrice = originalPrice;
        }


        //function that returns the release date of the Laptop
        public DateTime GetReleaseDate()
        {
            return releaseDate;
        }
        public void SetReleaseDate(DateTime releaseDate)
        {
            //we can get the name of the enumeration for the given rating number
            this.releaseDate = releaseDate;
        }
        /******************************************************/


        //function to calculate the exact age in years based on the release date
        //this function works by thinking of release date as the birthday of the laptop, 
        //first checks if a complete number of years has passed since the release date, 
        //if so will check month has passed, if month is the same then checks days
        //this has been adapted from my calculate Age function in my SuperHero project from last year
        public int CalculateAgeInYears()
        {
            //Declare a DateTime variable to store the current date
            DateTime currentDate = DateTime.Today;

            //Interger of the complete number of years passed since the release date
            int yearsPassedSinceRelease = Convert.ToInt32(currentDate.Year - releaseDate.Year);

            //declare integer to store the laptops age and initialise =0
            Int32 laptopAge = 0;

            //check if the release dates year is current year
            if (releaseDate.Year == currentDate.Year)
            {
                //If the year is the same as the current year then no years have passed so age is zero
                laptopAge = 0;
                //return age
                return laptopAge;
            }
            else
            {
                //Check if the current month is after the release date month then another year has passed
                if (currentDate.Month > releaseDate.Month)
                {
                    //the 'complete' number of years since release date
                    laptopAge = yearsPassedSinceRelease;
                }
                //Check if the current month is before the manufactured month, if so then another year has not passed since release date, so a year less in age
                if (currentDate.Month < releaseDate.Month)
                {
                    //the number of years since release date minus the uncompleted year
                    laptopAge = yearsPassedSinceRelease - 1;
                }
                //if the current month is equal to the release date month then check current day is over the day laptop was released:
                if (currentDate.Month == releaseDate.Month)
                {
                    // This section of code checks that another complete year since release date has passed or not (thus complete laptopAge years since release date are calculated)
                    //if release date's day in the month is less than current day in current month, then another complete year has passed
                    if (currentDate.Day >= releaseDate.Day)
                    {
                        //the 'complete' number of years since release date
                        laptopAge = yearsPassedSinceRelease;
                    }
                    //if the birthday has not passed
                    if (currentDate.Day < releaseDate.Day)
                    {
                        //the number of years since release date minus the uncompleted year
                        laptopAge = yearsPassedSinceRelease - 1;
                    }
                }
                return laptopAge;
            }
        }

        //This abstract method requires implementation in the derived class
        public abstract decimal CalculateApproximateValue();

        //method that returns the complete description of the laptop
        public string Description()
        {
            //gets the enumeration name associated with Enum value
            string conditionByName = Enum.GetName(typeof(Condition), condition);

            //As the release date is displayed in a string we can format the date in a more sensible format
            string formatReleaseDate = releaseDate.Day + "/" + releaseDate.Month + "/" + releaseDate.Year; 

            //builds the description of the laptop as a string
            string description = string.Format(
                "{0} \t\t" +
                "{1} \t\t" +
                "{2} \t\t" +
                "{3} \t\t" +
                "{4:c}",
                name,
                brand,
                formatReleaseDate,
                conditionByName,
                CalculateApproximateValue()
                );
            return description;
        }

        //Implement IComparable CompareTo method to implement default sort order based on Price
        //This will be used if we need to sort the laptop
        int IComparable.CompareTo(object obj)
        {
            //Example for reference: https://docs.microsoft.com/en-us/dotnet/api/system.icomparable?view=netframework-4.8
            //gets another object in the list
            Laptop otherLaptop = obj as Laptop;

            //current Laptop object calculated approximate value - otherLaptop object calculated approximate value 
            decimal priceDifference = this.CalculateApproximateValue() - otherLaptop.CalculateApproximateValue();

            //returns +1, 0, -1 depending on difference (determines relative position in sort order)
            return Math.Sign(priceDifference);

        }
    }

}
