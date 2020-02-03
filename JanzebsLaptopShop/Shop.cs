using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanzebsLaptopShop
{
    [Serializable()]
    public class Shop
    {
        //declare a list to store the laptops
        private List<Laptop> laptopInventory;

        /***************************** Required for saving and opening files ***************************/
        public List<Laptop> LaptopInventory
        {
            get
            {
                //needed to create this to beable to save a list as a file (see Form1 Save)
                return laptopInventory;
            }
            set
            {
                //needed to create this function to beable to open a saved list from file and copy it (see Form1 Open)
                laptopInventory = value;
            }
        }
        /*****************************************************************************************************/
        //declare a string to store the shop name
        private string shopName;

        //constructor for the shop
        public Shop(string shopName)
        {
            //initialise the shop name
            this.shopName = shopName;

            //initialise the list object
            laptopInventory = new List<Laptop>();
        }

        //declare a private member variable to be the index for the  array list
        private int currentViewedLaptop = 0;
        //get function for the currentLaptop index value
        public int CurrentlyViewedLaptop
        {
            get
            {
                return currentViewedLaptop;
            }

            /*********** had to add this after opening and loading list (Form 1), so I could set the currently viewed laptop in the list *****/
            set
            {
                currentViewedLaptop = value;
            }
        }


        //get function that returns the number of Laptops in the laptop inventory
        public int NumberOfLaptops
        {
            get { return laptopInventory.Count; }
        }

        //function to retrieve the description for current laptop
        public string DescribeCurrentLaptop()
        {
            //string variable to hold description
            string description;
            //Check if there is a Laptop 
            if(laptopInventory.Count > 0)
            {
                //get the description of the laptop pointed to by CurrentlyViewedLaptop index
                description = laptopInventory[currentViewedLaptop].Description();
            }
            //if there are no laptops in the inventory
            else
            {
                //display message
                description = "No laptops in Inventory";
            }
            return description;
        }

        //made this function to return the brand and name
        public string CurrentLaptopBrandName()
        {
            //get theBrand and get theName
            string theBrand = laptopInventory[currentViewedLaptop].GetBrand();
            string theName = laptopInventory[currentViewedLaptop].GetName();

            return theBrand + " " + theName;
        }
//created this - to go with the Find form - so it returns the name for name matching function 
        //made this function to return the brand and name
        public string FindLaptopName(int index)
        {
            //get theName
            string theName = laptopInventory[index].GetName();

            return theName;
        }
        //this lets us check if there is a previous laptop before the currently indexed laptop
        public bool IsPreviousLaptop()
        {
            //check that the index is not at 0, 
            //return the result of the boolean condition
            return (currentViewedLaptop > 0);
        }

        //this lets us check if there is a another laptop ahead of the currently indexed laptop
        public bool IsNextLaptop()
        {
            //check that the index is not at the last item 
            //(laptopInventory.Count - 1 because count starts at 1, index at 0), 
            //return the result of the boolean condition
            return (currentViewedLaptop < laptopInventory.Count - 1);
        }

        //Function that steps to previous laptop
        public void ViewPreviousLaptop()
        {
            //Check if there is a previous laptop, then its OK to step to previous laptop
            if (IsPreviousLaptop())
            {
                //decrement the index
                currentViewedLaptop--;
            }
        }

        //Function that steps to next laptop
        public void ViewNextLaptop()
        {
            //Check if there is another laptop, then its OK to step to next laptop
            if (IsNextLaptop())
            {
                //increment the index
                currentViewedLaptop++;
            }
        }

        //Function that enables us to add a laptop to the list
        public void AddLaptop(Laptop laptop)
        {
            laptopInventory.Add(laptop);
        }

        public void RemoveLaptop(int index)
        {
            if(index < laptopInventory.Count)
            {
                //Before we can remove a laptop, we need to ensure the index is within the bounds of the array list.
                //in other words the index is pointing to a laptop within the arraylist
                CorrectOutofBounds();
                //Remove the laptop at the selected index
                laptopInventory.RemoveAt(index);

            }
        }


        //function to correct for any out of bounds errors
        //private as it is not going to be used outside of this class
        private void CorrectOutofBounds()
        {
            //Check if index is greater the highest index for laptopInventory list array
            if (currentViewedLaptop > (laptopInventory.Count - 1))
            {
                //then correct the index so its within the bounds of the array
                currentViewedLaptop = laptopInventory.Count - 1;
            }
            //Check if index is less the 0
            if (currentViewedLaptop < 0)
            {
                //then correct the index so its within the bounds of the array
                currentViewedLaptop = 0;
            }
        }
        //sort the laptops
        public void SortLaptops()
        {
            laptopInventory.Sort();
        }

        //funtion that will return a string of laptops found within the lowerPrice to upperPrice range
        public string FindLaptopsInRange(int lowerPrice, int upperPrice)
        {
            //declare a string to store the some details of laptops in range
            string laptopsInRange = "";

            foreach(Laptop laptop in laptopInventory)
            {
                //for each laptop we check its within the range
                if( (lowerPrice <= laptop.CalculateApproximateValue()) && ((laptop.CalculateApproximateValue() <= upperPrice)) )
                {
                    // we want the details to appear on seperate lines so, 
                    //add the details each time add new line after
                    laptopsInRange += laptop.Description() + Environment.NewLine;
                }
            }
            return laptopsInRange;
        }
    }
}
