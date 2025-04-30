using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    internal class MenuItems
    {
        private StreamReader inputFile;
        private StreamWriter errorLog;

        public List<MenuItem> AppItem { get; private set; } = new List<MenuItem>();
        public List<MenuItem> BevItem { get; private set; } = new List<MenuItem>();
        public List<MenuItem> MainItem { get; private set; } = new List<MenuItem>();
        public List<MenuItem> DessertItem { get; private set; } = new List<MenuItem>();
        public List<MenuItem> SelectedItem { get; private set; } = new List<MenuItem>();

        // Original version used a persistent form
        private SelectionForm SelectForm = new SelectionForm();

        private bool OpenInputFile()
        {
            errorLog = File.CreateText("ErrorLog.txt");
            try
            {
                inputFile = File.OpenText("Menu.txt");
                return true;
            }
            catch (Exception ex)
            {
                errorLog.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //same logic as case study
        public void FillItemLists()
        {
            MenuItem menuItem;
            decimal cost;
            string line = "";
            char[] delim = { ',' };

            if (OpenInputFile())
            {
                AppItem.Clear();
                BevItem.Clear();
                MainItem.Clear();
                DessertItem.Clear();

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                     

                    if (tokens.Length == 3)
                    {
                        if (decimal.TryParse(tokens[2], out cost))
                        {
                            menuItem = new MenuItem();
                            menuItem.ItemName = tokens[1];
                            menuItem.Cost = cost;
                            //goes to Beverage
                            if (tokens[0] == "B")
                            {
                                BevItem.Add(menuItem);
                                SelectForm.addBevItem(menuItem.ItemName);
                            }
                            else if (tokens[0] == "A")
                            {
                                //goes to apps
                                AppItem.Add(menuItem);
                                SelectForm.addAppsItem(menuItem.ItemName);
                            }
                            else if (tokens[0] == "M")
                            {
                                //goes to main courses
                                MainItem.Add(menuItem);
                                SelectForm.addMainItem(menuItem.ItemName);
                            }
                            else if (tokens[0] == "D")
                            {
                                //goes to desserts
                                DessertItem.Add(menuItem);
                                SelectForm.addDesertItem(menuItem.ItemName);
                            }
                        }
                        //error checkers
                        else
                        {
                            errorLog.Write("Error - Invalid Price for ");
                            errorLog.Write(tokens[1]);
                            errorLog.WriteLine(" " + tokens[1] + " " + tokens[2]);
                        }
                    }
                    else
                    {
                        errorLog.WriteLine("Error - Invalid Line - Wrong Number of Entries");
                        errorLog.WriteLine(line);
                    }
                }
                inputFile.Close();
            }
            errorLog.Close();
        }
        //selected items from user
        public bool SelectAps()
        {
            SelectedItem.Clear();
            BuildSelectedItems(SelectForm.SelectedItems("A"), AppItem, "Appetizer");
            return SelectedItem.Count > 0;
        }

        public bool SelectBevs()
        {
            SelectedItem.Clear();
            BuildSelectedItems(SelectForm.SelectedItems("B"), BevItem, "Beverage");
            return SelectedItem.Count > 0;
        }

        public bool SelectMain()
        {
            SelectedItem.Clear();
            BuildSelectedItems(SelectForm.SelectedItems("M"), MainItem, "Main Course");
            return SelectedItem.Count > 0;
        }

        public bool SelectDessert()
        {
            SelectedItem.Clear();
            BuildSelectedItems(SelectForm.SelectedItems("D"), DessertItem, "Dessert");
            return SelectedItem.Count > 0;
        }
        //builds the selected items from the user
        private void BuildSelectedItems(List<string> selections, List<MenuItem> menuItems, string category)
        {
            SelectedItem.Clear();

            foreach (string item in selections)
            {
                SelectedItem.Add(new MenuItem
                {
                    ItemName = item + " (" + category + ")",
                    Cost = menuItems.Find(x => x.ItemName == item).Cost
                });
            }
        }
    }
}