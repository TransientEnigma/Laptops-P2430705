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
    public partial class formLaptopLookup : Form
    {
       

        //this form is used to return the name of the laptop you want to find

        //laptopname is like global variable retains its value, until program is closed
        private StringBuilder laptopName;

        public formLaptopLookup(StringBuilder laptopName)
        {
            //initialises things, without this form controls give errors
            InitializeComponent();
            //use the constructor to initialise the variable with that passed in
            this.laptopName = laptopName;
            //when form loads the find button will be inactive
            buttonFind.Enabled = false;
            //convert the laptopName from stringBuilder to string to display in textbox
            textBoxLaptopName.Text = this.laptopName.ToString();
        }



        private void formLaptopLookup_Load(object sender, EventArgs e)
        {
            //when form loads the find button will be inactive
            buttonFind.Enabled = false;
        }

        private void textBoxLaptopName_TextChanged(object sender, EventArgs e)
        {
            //when someone types text in the box the find button will become active
             buttonFind.Enabled = true; 
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //this is how we pass back the laptop text we want to find

            //clear the contents so when we append (add) the text it doesnt add to existing contents
            laptopName.Clear();
            //use the trim because sometimes the textbox will add extra zeros we dont want
            //- remove leading and trailing zeros using trim
            laptopName.Append(textBoxLaptopName.Text.Trim());

            //when the find button is pressed it closes the form
            this.Close();
        }
    }
}
