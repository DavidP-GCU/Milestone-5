using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Inventory_Management_System
{
    public partial class InventoryManagementSystem : Form
    {
        DataTable inventory = new DataTable();
        public InventoryManagementSystem()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e) //Create method to clear data from textboxes.
        {
            produceTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save all the values from the users entry into variables. 
            String produce = produceTextBox.Text;
            String quantity = quantityTextBox.Text;
            String price = priceTextBox.Text;

            // Add these values to the datatable
            inventory.Rows.Add(produce, quantity, price);


            //Call Method "newButton" to clear data from textboxes
            //This should automatically clear the textboxes. 
            newButton_Click(sender, e);

        }

        private void deleteButton_Click(object sender, EventArgs e) //Delete Btn event handler.
        {
            try //Beginning of exception handler
            {
                //Clears the data from textbox's. 
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception) //End of exception handler. 
            {
                MessageBox.Show("Error. No data to delete.");
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Method that inputs data into txtboxes when double clicking column. 
        {
            try //Beginning of exception handler
            {
                produceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
            }
            catch(Exception) //End of exception handler.
            {
                MessageBox.Show("Error. No Data Available");
            }
        }

        private void InventoryManagementSystem_Load(object sender, EventArgs e) //Method to create DataTable Array.
        {
            inventory.Columns.Add("Produce");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Price");

            inventoryGridView.DataSource = inventory;
        }

        private void exitButton_Click(object sender, EventArgs e) //Method to close GUI. 
        {
            //Create and open 2nd Form "CloseApp Form". 
            //This form opens and then closes. 
            CloseApp myCloseApp = new CloseApp();
            myCloseApp.ShowDialog();
            this.Close();

        }
        
        //I forgot to change the name property before opening the event handler "Request Items". 
        private void button1_Click(object sender, EventArgs e)//This is the "Request Items" event handler. 
        {
            //Opens another form for data entry. Form = (RequestItemsForm)
            RequestItemsForm myRequestItemsForm = new RequestItemsForm();
            myRequestItemsForm.ShowDialog();
        }
    }
}
