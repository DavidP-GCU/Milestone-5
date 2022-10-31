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
    public partial class CloseApp : Form
    {
        public CloseApp()
        {
            InitializeComponent();
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            //Display goodbye message.
            //Close this form. 
            MessageBox.Show("Windows Form is pretty cool. Thank you professor. Have a great day.");
            this.Close();

        }
    }
}
