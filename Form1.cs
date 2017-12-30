using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Customer currentCustomer;
        Item selectedItem;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = IdBox.Text;
            if (id != "") {
                currentCustomer = DataBaseAccess.getCustomer(id);
                if (currentCustomer != null) {

                    firstNameBox.Text = currentCustomer.getFirstName();
                    LastNameBox.Text = currentCustomer.getLastName();
                    TotalItemBox.Text = Convert.ToString(currentCustomer.startingNumberOfItems());
                    NamePanel.Visible = true;
                    StartShoppingPanel.Visible = true;
                    CheckoutPanel.Visible = true;
                    LogInButton.Enabled = false;
                    StartShoppingButton.Enabled = true;
                    LogOutButton.Enabled = true;
                }
               
            }
           




        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchItemPanel.Visible = true;
            StartShoppingButton.Enabled = false;
            cartList.Items.Clear();
            currentCustomer.addBasket();
           
            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardPanel.Visible = true;
            totalBox.Text = currentCustomer.currentBasketTotal().ToString();
            ItemNumberBox.Text = currentCustomer.currentItemNumber().ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            String stringItem = SearchItemBox.Text;
            if (stringItem != "") {
                selectedItem = DataBaseAccess.getItem(stringItem);
                if (selectedItem != null) {
                    ItemValueBox.Text = selectedItem.getValue().ToString();
                    ItemNameBox.Text = selectedItem.getName();
                    AddButton.Enabled = true;
                    FinishButton.Enabled = true;
                }

            }
              
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentCustomer.addItem(selectedItem);
     
            

            if (!cartList.Items.Contains(selectedItem.getName()))
            {

                cartList.Items.Add(selectedItem.getName());
            }
            
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchItemPanel.Visible = false;
            CheckOutButton.Enabled = true;


        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            
            DataBaseAccess.updateCustomer(currentCustomer);
            TotalItemBox.Text = currentCustomer.getCustomerTotalItems().ToString();
            currentCustomer.updateNumberOfItems();
            currentCustomer.clearBasket();
            CardPanel.Visible = false;
            CheckOutButton.Enabled = false;
            StartShoppingButton.Enabled = true;



        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CardPanel.Visible = false;
            CheckOutButton.Enabled = false;
            SearchItemPanel.Visible = true;


        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            currentCustomer.deleteBasket();
            currentCustomer = null;
            selectedItem = null;
            SearchItemBox.Text = "";
            ItemNameBox.Text = "";
            ItemValueBox.Text = "";
            IdBox.Text = "";
            NamePanel.Visible = false;
            StartShoppingPanel.Visible = false;
            SearchItemPanel.Visible = false;
            CheckoutPanel.Visible = false;
            cartList.Visible = false;
            LogInButton.Enabled = true;
            CheckOutButton.Enabled = false;
            CardPanel.Visible = false;







        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            cartList.Visible = true;
           
            returnShop.Visible = true;
            StartShoppingButton.Visible = false;
            DeleteButton.Visible = true;

        }

       

        private void returnShop_Click(object sender, EventArgs e)
        {
           cartList.Visible = false;
           
            returnShop.Visible = false;
            StartShoppingButton.Visible = true;
            DeleteButton.Visible = false;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            
            String stringItem = (String) cartList.SelectedItem;
            Dictionary<Item, int> list = currentCustomer.getTable();
            Item temp = null;
            foreach (Item key in list.Keys) {

                if (key.getName().Equals(stringItem)) { // n search, logn if sorted first

                     temp = key;

                }
            }
            if (temp != null) {
                String message = "There is " + list[temp] + " " + temp.getName().Trim() + "(s) in your cart. Delete them?";
                String caption = "Delete items";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    currentCustomer.removeAllItem(temp);
                    cartList.Items.Remove(cartList.SelectedItem);

                }
            }
            

            


        }
    }
}
