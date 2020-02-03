using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanzebsLaptopShop
{
    public partial class formAddLaptop : Form
    {
        public formAddLaptop()
        {
            InitializeComponent();
        }

        private Laptop HPLaptop;
        private Laptop AppleLaptop;

        ////create and initialise some variables for data storage
        private string name = "";
        private string brand = "";
        private Laptop.Condition condition = Laptop.Condition.fair;
        private decimal price = 0;
        private DateTime date = DateTime.Today;

        string dateString = "";



        //creating this constructor means we can pass in laptop objects
        //here we are passing a laptop objects to the form by reference from the main 
        //form, so it sill referes to the same object in the main form
        //because we are looking at the same object. and changed we make here
        //will be visible to the mainForm. this avoids having to use a public
        //variable
        public  formAddLaptop(Laptop HPLaptop, Laptop AppleLaptop)
        {
            InitializeComponent();


            this.HPLaptop = HPLaptop;
            this.AppleLaptop = AppleLaptop;

            //deactivate the OK button-dont want to add blank data by accident
            buttonAddOK.Enabled = false;
        }

        //when the form loads the combo boxes are initialised
        private void formAddLaptop_Load(object sender, EventArgs e)
        {
            // load the lists of the combo box for Brand
            comboBoxAddBrand.Items.Add("Apple");
            comboBoxAddBrand.Items.Add("HP");
            //load the combo box for condition (making sure selected index matches ENUM values poor = 1, fair = 2, good = 3, mint = 4, 
            comboBoxAddCondition.Items.Add("poor");
            comboBoxAddCondition.Items.Add("fair");
            comboBoxAddCondition.Items.Add("good");
            comboBoxAddCondition.Items.Add("mint");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void panelAddLaptop_MouseMove(object sender, MouseEventArgs e)
        { //only if we have all data fields filled make the OK button active - dont want to save empty/blank data
            if(    (textAddBoxName.Text != "") 
                && (comboBoxAddBrand.SelectedIndex > -1) 
                && (textBoxAddOriginalPrice.Text != "") 
                && (textBoxAddDateDD.Text != "") 
                && (comboBoxAddCondition.SelectedIndex > -1)
               )
            {
                //activate the OK button-when all fields are filled
                buttonAddOK.Enabled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            //get the selected condition
            if (comboBoxAddCondition.SelectedIndex == 1) { condition = Laptop.Condition.poor; }
            if (comboBoxAddCondition.SelectedIndex == 2) { condition = Laptop.Condition.fair; }
            if (comboBoxAddCondition.SelectedIndex == 3) { condition = Laptop.Condition.good; }
            if (comboBoxAddCondition.SelectedIndex == 4) { condition = Laptop.Condition.mint; }

            
            //get the make
            name = textAddBoxName.Text;

            //check the date and get the date
            try
            {
                //need to reverse the date to add it
                dateString = textBoxAddDateYYYY.Text + "/" + textBoxAddDateMM.Text + "/" + textBoxAddDateDD.Text;
                //converts text box value to price
                date = Convert.ToDateTime(dateString);
            }
            catch
            {
                //if the value is not a date
                MessageBox.Show("date must be a date", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //get the decimal -check its a decimal
            try
            {
                //converts text box value to price
                price = Convert.ToDecimal(textBoxAddOriginalPrice.Text);
            }
            catch
            {
                //if the value is not a decimal
                MessageBox.Show("price must be a decimal number", "Price Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if the selected brand is Apple do use the AppleLaptop object
            if (comboBoxAddBrand.SelectedIndex == 0)
            {
                brand = "Apple";

                AppleLaptop.SetName(name.PadRight(10,' '));
                AppleLaptop.SetBrand(brand);
                AppleLaptop.SetCondition(condition);
                AppleLaptop.SetOriginalPrice(price);
                AppleLaptop.SetReleaseDate(date);
            }
            //if the selected brand is HP use the HPLaptop object
            if (comboBoxAddBrand.SelectedIndex == 1)
            {
                brand = "HP";
                HPLaptop.SetName(name.PadRight(10, ' '));
                HPLaptop.SetBrand(brand);
                HPLaptop.SetCondition(condition);
                HPLaptop.SetOriginalPrice(price);
                HPLaptop.SetReleaseDate(date);
            }




        }

        private void textBoxOriginalPrice_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBoxReleaseDate_MouseLeave(object sender, EventArgs e)
        {

        }



    }
}
