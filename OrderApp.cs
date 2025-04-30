using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class OrderApp : Form
    {
        //Global Class Variables
        private MenuItems menuItems = new MenuItems();
        private List<MenuItem> SelectedItem = new List<MenuItem>();

        public OrderApp()
        {
            InitializeComponent();
            SetTabOrder();
        }

        decimal TipPerct = 0.15m;

        private void GetCost()
        {
            //checks to see if the tip text box has anything in it
            if (!string.IsNullOrWhiteSpace(Tip_textBox.Text))
            {
                //if it does and can be a valid tip % it becomes the tip percentage
                if (!decimal.TryParse(Tip_textBox.Text, out TipPerct))
                {
                    //otherwise it tells the user to put a valid amount
                    MessageBox.Show("Please enter a valid tip amount.");
                    Tip_textBox.Text = "0.15";
                    Tip_textBox.Focus();
                    return;
                }
            }

            //Constants used in Cost Calculations
            const decimal TAX_RATE = 0.06m; // 6% tax rate

            //variables to hold amounts
            decimal subtotal = 0.0m;
            decimal tax = 0.0m;
            decimal tip = 0.0m;
            decimal total = 0.0m;

            foreach (MenuItem i in SelectedItem)
            {
                subtotal += i.Cost;
            }

            // Display subtotal
            Subtotal_label.Text = subtotal.ToString("c2");

            // Calculate and display tax
            tax = subtotal * TAX_RATE;
            Tax_label.Text = tax.ToString("c2");

            // Calculate and display tip
            tip = subtotal * TipPerct;
            Tip_label.Text = tip.ToString("c2");

            // Calculate and display total
            total = subtotal + tax + tip;
            Total_label.Text = total.ToString("c2");


        }

        private void ResetOrder()
        {
            // Clear the selected items listbox and the parallel list
            MenuItemslistBox.Items.Clear();
            SelectedItem.Clear();

            // Reset the tip textbox to default value
            Tip_textBox.Text = "0.15";
            TipPerct = 0.15m;

            // Clear the calculated values
            GetCost();
        }

        private void UpdateOrder(List<MenuItem> itemsToAdd)
        {
            // Loop through the items selected and add to the lists
            foreach (MenuItem item in itemsToAdd)
            {
                // If the item is already in the order, confirm customer wants to add it again
                if (SelectedItem.Exists(x => x.ItemName == item.ItemName) &&
                    MessageBox.Show(item.ItemName + " exists.\n" + "Add it again?",
                                  "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Do Nothing
                }
                else
                {
                    // Update the listbox and the parallel list
                    MenuItemslistBox.Items.Add(item.ItemName);
                    SelectedItem.Add(new MenuItem
                    {
                        ItemName = item.ItemName,
                        Cost = item.Cost
                    });

                    // Update the order totals
                    GetCost();
                }
            }
        }

        private void OrderApp_Load(object sender, EventArgs e)
        {
            // fill up the list boxes
            menuItems.FillItemLists();

            // Initialize the order
            ResetOrder();

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create the About form
            AboutForm frmAbout = new AboutForm();
            //Show the form as Modal
            frmAbout.ShowDialog();
            //Destroy form and give memory back
            frmAbout.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Tip_textBox_TextChanged(object sender, EventArgs e)
        {
            //whenever the tip amount is changed it gets the new amount
            GetCost();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        //adding items to order
        private void AppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItems.SelectAps())
            {
                UpdateOrder(menuItems.SelectedItem);
            }
        }

        private void beveragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItems.SelectBevs())
            {
                UpdateOrder(menuItems.SelectedItem);
            }
        }

        private void mainCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItems.SelectMain())
            {
                UpdateOrder(menuItems.SelectedItem);
            }
        }

        private void dessertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItems.SelectDessert())
            {
                UpdateOrder(menuItems.SelectedItem);
            }
        }

        private void RemoveItembutton_Click_1(object sender, EventArgs e)
        {
            if (MenuItemslistBox.Items.Count == 0)
            {
                // Display an Error
                MessageBox.Show("Please add items to your order first!");
            }
            else
            {
                // Use selected index to remove item from both lists
                if (MenuItemslistBox.SelectedIndex >= 0)
                {
                    SelectedItem.RemoveAt(MenuItemslistBox.SelectedIndex);
                    MenuItemslistBox.Items.RemoveAt(MenuItemslistBox.SelectedIndex);
                    // Update the totals for the Order
                    GetCost();
                }
                else
                {
                    // Display an Error
                    MessageBox.Show("Please select an item to remove");
                    MenuItemslistBox.Focus();
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resets Order
            ResetOrder();
        }

        private void Tip_textBox_TextChanged_1(object sender, EventArgs e)
        {
            //if the tip chnages it gets the new order
            GetCost();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            //try excpect blocks for error checking
            try
            {
                //brings up file dialogs to save the order
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Order";
                //if the dialog is ok, it uses streamwriter 
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        //loops through each of the selectedItems and adds them to the text file with the cost
                        foreach (MenuItem item in SelectedItem)
                        {
                            writer.WriteLine($"{item.ItemName},{item.Cost}");
                        }
                    }
                    //tells the user the order was saved
                    MessageBox.Show("Order saved successfully.");
                }
            }
            //error catcher
            catch (Exception ex)
            {
                //gives the user a message block with what the error message was
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }

        private void LoadStripMenuItem_Click(object sender, EventArgs e)
        {
            //try excpect blocsk for error catching
            try
            {
                //brings up file dialogs to load order
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Load Order";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //clears the selected items and list box so nothing else is there
                    SelectedItem.Clear();
                    MenuItemslistBox.Items.Clear();

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        //goes line by line simalr to when loading the menus
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //here I don't care about the type of item so I only need two tokens
                            string[] tokens = line.Split(',');
                            if (tokens.Length == 2 && decimal.TryParse(tokens[1], out decimal cost))
                            {
                                //otherwise this is the same logic as loading the items
                                MenuItem item = new MenuItem
                                {
                                    ItemName = tokens[0],
                                    Cost = cost
                                };
                                //adds the items to the correcr enties 
                                SelectedItem.Add(item);
                                MenuItemslistBox.Items.Add(item.ItemName);
                            }
                            else
                            //if it gets an error at a line, a message box will tell the user
                            {
                                MessageBox.Show("Invalid line in file: " + line);
                            }
                        }
                    }
                    //after it loads it gets the price of the order and tells the user the order was loaded
                    GetCost();
                    MessageBox.Show("Order loaded successfully.");
                }
            }
            //error catcher for errors loading the order
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order: " + ex.Message);
            }
        }
        //tab order
        private void SetTabOrder()
        {
            MenuItemslistBox.TabIndex = 0;
            RemoveItembutton.TabIndex = 1;
            Tip_textBox.TabIndex = 2;
           

        }
    }
}
