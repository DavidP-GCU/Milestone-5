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
    public partial class RequestItemsForm : Form
    {
        public RequestItemsForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Gather date from textbox and display in listbox. 
            listBox1.Items.Add(textBoxItems.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear all items in listbox container. 
            listBox1.Items.Clear();
            textBoxItems.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close RequestItems Form
            this.Close();
        }
    }
}
