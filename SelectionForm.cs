using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SelectionForm : Form
    {
        // things to use to add to
        private ListBox selectedListBox;
        private List<string> selections = new List<string>();

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public List<string> SelectedItems(string type)
        {
            if (type.ToUpper() == "B")
            {
                this.Text = "Select Beverages";
                selectedListBox = BevsListBox;
            }
            else if (type.ToUpper() == "A")
            {
                this.Text = "Select Appetizers";
                selectedListBox = AppsListBox;
            }
            else if (type.ToUpper() == "M")
            {
                this.Text = "Select Main Courses";
                selectedListBox = MainsListBox;
            }
            else if (type.ToUpper() == "D")
            {
                this.Text = "Select Desserts";
                selectedListBox = DessertListBox;
            }
            else
            {
                MessageBox.Show("Menu type " + type + " is unsupported");
                return selections;
            }
            //hides all list boxes but the one the user selected reappears
            AppsListBox.Visible = false;
            BevsListBox.Visible = false;
            MainsListBox.Visible = false;
            DessertListBox.Visible = false;
            // clear selections
            selectedListBox.Visible = true;
            selectedListBox.ClearSelected();
            selections.Clear();

            // modal form
            this.ShowDialog();

            return selections;
        }

        // functions to use to add items to correct list boxes
        public void addBevItem(string item)
        {
            BevsListBox.Items.Add(item);
        }

        public void addAppsItem(string item)
        {
            AppsListBox.Items.Add(item);
        }

        public void addMainItem(string item)
        {
            MainsListBox.Items.Add(item);
        }

        public void addDesertItem(string item)
        {
            DessertListBox.Items.Add(item);
        }

        private void AddItemsbutton_Click(object sender, EventArgs e)
        {
            // error checker to make sure items are selected
            if (selectedListBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please Select an Item or Click to Cancel");
            }
            else
            {
                // if items were selected it builds the selected items list and returns OK
                foreach (string item in selectedListBox.SelectedItems)
                {
                    selections.Add(item);
                }
                this.DialogResult = DialogResult.OK;
            }
        }
        private void SelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hide all List Boxes after the user leaves
            AppsListBox.Visible = false;
            BevsListBox.Visible=false;
            MainsListBox.Visible=false;
            DessertListBox.Visible=false;
                }

        private void DessertListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
