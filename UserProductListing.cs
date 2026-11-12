using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuson_Week06_Week05
{
    public partial class UserProductListing : UserControl
    {
        public UserProductListing()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "Box", "Kilogram" };
        List<string> shoppingList = new List<string>();

        private void UserProductListing_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.Clear();
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;
        }

        private void updateGUI()
        {
            lbxItems.DataSource = null;
            lbxItems.DataSource = shoppingList;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string item = txtbDescription.Text;
            double amount = double.Parse(txtbAmount1.Text);
            string unit = cmbUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) && !string.IsNullOrEmpty(amount.ToString()))
            {
                string row = $"{item}\t\t {amount} {unit}";
                shoppingList.Add(row);
                updateGUI();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbxItems.SelectedIndex;

            if (index != -1)
            {
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                MessageBox.Show(shoppingList[index] + " deleted.");

                shoppingList.RemoveAt(index);
                updateGUI();
            }
            else
            {
                lblPrompt.Text = "Please select an item to delete.";
                lblPrompt.Visible = true;
            }
        }

        private void grpbItemDetails_Enter(object sender, EventArgs e) 
        {

        }
        private void lblDescription_Click(object sender, EventArgs e) 
        {

        }
        
        private void txtbDescription_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
       
        private void txtbAmount1_TextChanged(object sender, EventArgs e)
        { 

        }
        
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }
        
        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = "";
            lblPrompt.Visible = false;
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}