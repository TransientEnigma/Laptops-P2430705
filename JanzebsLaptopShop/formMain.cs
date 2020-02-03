using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanzebsLaptopShop
{
    public partial class formMain : Form
    {
        //The shop contains the laptopInventory and an index to choose them
        //create a shop object
        Shop myShop;



        public formMain()
        {
            InitializeComponent();
        }

        //when the form loads this will execute
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialise the shop object, give it a name
            myShop = new Shop("JANZEBS LAPTOP SHOP");


            /******************** NOT REQUIRED ANYMORE AS WE CAN OPEN A FILE laptops.txt *********************************/
            ////Create and initialise some laptop objects and add laptops them to the shop
            ////List of Apple laptops. Notes: 
            ////poor = 50% of original value, fair = 70% of original value,
            ////good = 80% of original value, mint = 90% of original value,
            ////losses 10% for each year
            //Laptop laptop1 = new Apple("MacBook Retina", "Apple", Laptop.Condition.mint, 1000, new DateTime(2019, 03, 01));
            //Laptop laptop2 = new Apple("MacBook 9", "Apple", Laptop.Condition.good, 900, new DateTime(2018, 07, 06));
            //Laptop laptop3 = new Apple("MacBook8", "Apple", Laptop.Condition.fair, 1000, new DateTime(2017, 05, 01));
            //Laptop laptop4 = new Apple("MacBook7", "Apple", Laptop.Condition.poor, 1000, new DateTime(2010, 08, 06));
            //Laptop laptop5 = new Apple("MacBook6", "Apple", Laptop.Condition.mint, 1000, new DateTime(2015, 02, 09));
            //Laptop laptop6 = new Apple("MacBook5", "Apple", Laptop.Condition.good, 1000, new DateTime(2014, 03, 09));
            //Laptop laptop7 = new Apple("MacBook5", "Apple", Laptop.Condition.fair, 1000, new DateTime(2019, 05, 06));
            //Laptop laptop8 = new Apple("MacBook Mini", "Apple", Laptop.Condition.poor, 1000, new DateTime(2017, 05, 03));

            ////List of HP Laptops. Note: 
            ////poor = 40% of original value, fair = 50% of original value,
            ////good = 70% of original value, mint = 80% of original value,
            ////losses 20% for each year
            //Laptop laptop9 = new HP("Spectre x360", "HP", Laptop.Condition.fair, 1000, new DateTime(2018, 03, 01));
            //Laptop laptop10 = new HP("Spectre x360", "HP", Laptop.Condition.mint, 900, new DateTime(2019, 07, 06));
            //Laptop laptop11 = new HP("HP Spectre Folio", "HP", Laptop.Condition.good, 1000, new DateTime(2005, 05, 01));
            //Laptop laptop12 = new HP("Chromebook", "HP", Laptop.Condition.poor, 1000, new DateTime(2010, 08, 06));
            //Laptop laptop13 = new HP("EliteBook x360", "HP", Laptop.Condition.fair, 1000, new DateTime(2015, 02, 09));
            //Laptop laptop14 = new HP("Omen7 Gaming", "HP", Laptop.Condition.good, 1000, new DateTime(2014, 03, 09));
            //Laptop laptop15 = new HP("Envy x360", "HP", Laptop.Condition.mint, 1000, new DateTime(2019, 05, 06));
            //Laptop laptop16 = new HP("OmenX Gaming", "HP", Laptop.Condition.poor, 1000, new DateTime(2017, 05, 03));

            ////Add the laptops to the Shop
            //myShop.AddLaptop(laptop1);
            //myShop.AddLaptop(laptop2);
            //myShop.AddLaptop(laptop3);
            //myShop.AddLaptop(laptop4);
            //myShop.AddLaptop(laptop5);
            //myShop.AddLaptop(laptop6);
            //myShop.AddLaptop(laptop7);
            //myShop.AddLaptop(laptop8);
            //myShop.AddLaptop(laptop9);
            //myShop.AddLaptop(laptop10);
            //myShop.AddLaptop(laptop11);
            //myShop.AddLaptop(laptop12);
            //myShop.AddLaptop(laptop13);
            //myShop.AddLaptop(laptop14);
            //myShop.AddLaptop(laptop15);
            //myShop.AddLaptop(laptop16);
            /*********************************************************************************************************************/


            //lets display some laptops when the form loads
            //set the upper price range to 1000 (lower price range is already 0)
            numericUpDownHigherPrice.Value = 1000;
            //Lets display the list and sort
            FindInRange();

        }

        //funcrtion to display laptop in list in the shop
        //this is not going to be used externally outside this form, so private access modifier
        private void DisplayLaptop()
        {
            //use a formated string to display the laptop index position in the list and number of laptops
            labelCurrentLaptop.Text = string.Format("Viewing {0} of {1}", myShop.CurrentlyViewedLaptop + 1, myShop.NumberOfLaptops);
            //get the description of the currently viewed laptop
            textLaptop.Text = myShop.DescribeCurrentLaptop();
        }

        private void textLaptop_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonPreviousLaptop_Click(object sender, EventArgs e)
        {
            myShop.ViewPreviousLaptop();
            DisplayLaptop();
        }

        private void buttonNextLaptop_Click(object sender, EventArgs e)
        {
            myShop.ViewNextLaptop();
            DisplayLaptop();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //sort the laptop order into ascending price
            myShop.SortLaptops();
            //display update the listbox
            buttonFindRange_Click(sender, e);
        }

        //lets you find within a range and also sorts in ascending price order for neater display
        private void buttonFindRange_Click(object sender, EventArgs e)
        {
            FindInRange();
        }

        public void FindInRange()
        {
            //get the lower price entered using numeric up down control
            int lowerPriceEntered = (int)numericUpDownLowerPrice.Value;
            //get the higher price entered using numeric up down control
            int higherPriceEntered = (int)numericUpDownHigherPrice.Value;

            if (lowerPriceEntered > higherPriceEntered)
            {
                //inform the user that you can not have lower price greater than higher price
                MessageBox.Show("'From Price' must be less than 'To Price'", "Price Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textLaptop.Text = myShop.FindLaptopsInRange(lowerPriceEntered, higherPriceEntered);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveLaptopStockList();
        }
        /******************************************** SERIALIZATION *********************************************************************/
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
        //because both the Laptop class and classification class are serialized (
        private void SaveLaptopStockList()
        {
            //create the save dialog and give it sensible default values
            SaveFileDialog saveFileScreen = new SaveFileDialog();
            //set the default filename extension
            saveFileScreen.DefaultExt = "*.txt";
            //set where to save. GetCurrentDirectory() gets current working directory (where the executable is running)
            //https://stackoverflow.com/questions/875249/how-to-get-current-directory
            saveFileScreen.InitialDirectory = Directory.GetCurrentDirectory();
            //Filter sets what will appear in the list of file types to save 
            //https://docs.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/dd459587(v%3Dvs.95)
            saveFileScreen.Filter = "Laptop Text Files (*.txt)|*.txt";
            //set the filename of the file to be saved
            saveFileScreen.FileName = "LaptopList.txt";

            //show the save dialogue, result of which goes in dr
            DialogResult ResultofSaveScreen = saveFileScreen.ShowDialog();

            //empty string to store filename taken from save dialogue filename field
            string saveFilename = null;

            //if when we click OK to save the file
            if (ResultofSaveScreen == System.Windows.Forms.DialogResult.OK)
            {
                // this could fail so we need a try catch block around it
                try
                {
                    //get the file name in the filename box of the saveDialog
                    saveFilename = saveFileScreen.FileName;

                    //Serializable means able to be sent to a filestream
                    //FileStream provides IO operations for read and write data
                    System.IO.FileStream dataStream = new System.IO.FileStream(saveFilename, System.IO.FileMode.Create);

                    //BinaryFormatter is what is used to serializes or deserializes the data (converts to and from binary)
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter convertToBinary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    //ConvertToBinary the serialized dataStream of theShopStockList
                    convertToBinary.Serialize(dataStream, myShop.LaptopInventory);

                    //must remember to close the data stream
                    dataStream.Close();


                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadLaptopStockList();
        }

        private void LoadLaptopStockList()
        {
            //create the open dialog and give it sensible default values
            OpenFileDialog openFileScreen = new OpenFileDialog();
            //set the default filename extension
            openFileScreen.DefaultExt = "*.txt";
            //set where to go to open the file. GetCurrentDirectory() gets current working directory (where the executable is running)
            //https://stackoverflow.com/questions/875249/how-to-get-current-directory
            //the first directory thats opened will be current directory
            openFileScreen.InitialDirectory = Directory.GetCurrentDirectory();
            //Filter sets what will appear in the list of file types to open 
            //https://docs.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/dd459587(v%3Dvs.95)
            openFileScreen.Filter = "Laptop Text Files (*.txt)|*.txt";
            //set the filename of the file to be opened
            openFileScreen.FileName = "LaptopList.txt";

            DialogResult ResultofOpenScreen = openFileScreen.ShowDialog();

            //empty string to store filename taken from save dialogue filename field
            string openFilename = null;

            // this could fail so we need a try catch block around it
            if (ResultofOpenScreen == System.Windows.Forms.DialogResult.OK)
            {
                //could fail - so we have a try catch block
                //We can check this by first loading to a second copy of the laptop list
                //then if the load is ok we can copy data to ShopLaptopStockList
                //this means that if the load fails we won't lose the ShopLaptopStockList already loaded with data

                try
                {
                    //gets the file name from  the field in the dialog
                    openFilename = openFileScreen.FileName;

                    //Serializable means able to be sent to a filestream
                    //FileStream provides IO operations for read and write data
                    System.IO.FileStream dataStream = new System.IO.FileStream(openFilename, System.IO.FileMode.Open);

                    //BinaryFormatter is what is used to serializes or deserializes the data (converts to and from binary)                   
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter convertFromBinary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    //create an empty list for to recieve the data from the file opened
                    Shop recievingShop = new Shop("RecievingShop");

                    //Deserialize the data stream and convert from binary and store in the recievingShopLaptopList
                    recievingShop.LaptopInventory = (List<Laptop>) convertFromBinary.Deserialize(dataStream);
                    //close the dataStream
                    dataStream.Close();

                    //if all goes without any error we should be able to copy it over to the myShop.LaptopInventory list

                    myShop.LaptopInventory = recievingShop.LaptopInventory;

                    //looking at 1st Laptop in the list (if it exists)
                    myShop.CurrentlyViewedLaptop = 0;
                    //lets display some laptops when we have the list
                    //set the upper price range to 1000 (lower price range is already 0)
                    numericUpDownHigherPrice.Value = 1000;
                    //Lets display the list and sort
                    FindInRange();

                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //create objects with default values
            //we have to create 2 objects one for Apple and one for HP, because of polymorphism
            //we can't use a Laptop class object
            Laptop AppleLaptop = new Apple("", "", Laptop.Condition.fair, 0, new DateTime(1000, 01, 01));
            Laptop HPLaptop = new Apple("", "", Laptop.Condition.fair, 0, new DateTime(1000, 01, 01));


            //open the Add laptop form -pass in the laptop objects as a reference
            formAddLaptop formAddLaptop = new formAddLaptop(HPLaptop,AppleLaptop);
            //formAddLaptop.ShowDialog(); launches the form
            //behaviour of OK button on the form set to DialogResult = OK
           if(DialogResult.OK == formAddLaptop.ShowDialog())
            {

                if(AppleLaptop.GetBrand() == "Apple")
                {
                    myShop.AddLaptop(AppleLaptop);
                    //reload the list including new laptop
                    FindInRange();
                }
                if(HPLaptop.GetBrand() == "HP")
                {
                    myShop.AddLaptop(HPLaptop);
                    //reload the list including new laptop
                    FindInRange();
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //check the laptop we are viewing is not out of bounds of laptop list array.
            //if the currently viewed laptop (or list index) is less than the number of laptops in list
            //then we have a laptop
            if(myShop.CurrentlyViewedLaptop < myShop.NumberOfLaptops)
            {
                //get the name of the current laptop
                //get the description of the currently viewed laptop
                string currentLaptopDescription = myShop.CurrentLaptopBrandName();

                //Confirm that the laptop is to be deleted
                if (MessageBox.Show("Are you sure you want to delete" + Environment.NewLine + currentLaptopDescription , "Confirm Delete Laptop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DeleteCurrentLaptop();
                }
            }
        }

        private void DeleteCurrentLaptop()
        {
            //checks that there are laptops in the shop. We cant delete if there are no laptops

            if (myShop.NumberOfLaptops > 0)
            {
                //get the description of the current laptop we are to delete
                //get the description of the currently viewed laptop
                string currentLaptopDescription = myShop.CurrentLaptopBrandName();

                //delete the laptop from the laptop list
                myShop.RemoveLaptop(myShop.CurrentlyViewedLaptop);

                //After deleting the laptop the index will not be pointing to a location in the list
                //that doesnt exist, so we need to step the index back one

                if (myShop.CurrentlyViewedLaptop >= myShop.NumberOfLaptops)
                {
                    //except if we deleted the only laptop then we can't step back or we will be at -1

                    if (myShop.NumberOfLaptops > 0)
                    {
                        //step back if there are laptops
                        myShop.CurrentlyViewedLaptop = myShop.CurrentlyViewedLaptop - 1;
                    }
                    else
                    {
                        //don't step back if there are laptops
                        myShop.CurrentlyViewedLaptop = 0;
                    }
                }

                //Lets display the list and sort
                FindInRange();
                MessageBox.Show(currentLaptopDescription + " has been deleted", "Delete Laptop Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*********************** Usefulness of stringbuilder - meaning of immutable (requires overhead) **************************/
        //https://docs.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder
        //The String object is immutable. Every time you use one of the methods in the System.String class, you create a new string 
        //object in memory, which requires a new allocation of space for that new object. In situations where you need to perform 
        //repeated modifications to a string, the overhead associated with creating a new String object can be costly. 
        //The System.Text.StringBuilder class can be used when you want to modify a string without creating a new object. 
        //For example, using the StringBuilder class can boost performance when concatenating many strings together in a loop.

        //declare stringBuilder for laptopName
        StringBuilder laptopName = new StringBuilder();

        private void buttonFindLaptop_Click(object sender, EventArgs e)
        {
            //we use the laptop lookup form to simply return a name we can use to find a laptop
            formLaptopLookup lookupForm = new formLaptopLookup(laptopName);

            //here we launch the laptop lookup form and then get the result of the button pressed
            //after the formLaptopLookup OK button is fressed we check the if it was Find (behaviour - dialogue OK)
            if(DialogResult.OK == lookupForm.ShowDialog())
            {
                //get the string and assign to laptop
                string theLaptop = laptopName.ToString().Trim();

                //need a pointer to point to the laptops in the laptop inventory list array
                int laptopPointedTo = 0;

                //when we find the laptop we can use the found bool to exit
                bool laptopFound = false;

                //loop through the list array using the pointer
                while((laptopPointedTo < myShop.NumberOfLaptops) & (!laptopFound))
                {
                    //I want to see what gets passed into the laptopNameToLower, found I needed to trim the spaces off
                    string laptopNameToLower = myShop.FindLaptopName(laptopPointedTo).ToLower().Trim();
                    //if the name of the laptop in shop is the same as thelaptop name
                    if (laptopNameToLower == theLaptop.ToLower())
                    {
                        //we have found it (found = true)
                        laptopFound = true;
                    }
                    else
                    {
                        //goto next laptop if not found
                        laptopPointedTo += 1;
                    }
                }
                if (laptopFound)
                {
                    //make the laptop pointed to the currrent laptop
                    myShop.CurrentlyViewedLaptop = laptopPointedTo;
                    //display the laptop found
                    DisplayLaptop();
                }
                else
                {
                    MessageBox.Show(theLaptop + " was not found", "Failed to Find Laptop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
