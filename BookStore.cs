using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_ShoppingCart
{
    internal class BookStore
    {
        // Declare a Stream Reader object
        private StreamReader inputFile;

        // Declare a StreamWriter object
        private StreamWriter errorLog;

        //Class Global Lists
        public List<Book> printBooks { get; private set; } = new List<Book>();
        public List<Book> audioBooks { get; private set; } = new List<Book>();

        //Helper Methods
        //******************************************************************
        // Function to capture errors in opening files

        private bool OpenInputFile()
        {
            // Open the error log
            errorLog = File.CreateText("ErrorLog.txt");
            try
            {
                // Open the input file
                inputFile = File.OpenText("Books.txt");
                return true;
            }
            catch (Exception ex)
            {
                // Log the error message and display to user.
                errorLog.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void InitializeBookLists()
        {
            // To hold the deciphered Book Information
            Book newBook;
            // To hold the cost of the Book
            Decimal cost;
            // To hold a line from the file
            string line = "";
            // Create a delimiter array.
            char[] delim = { ',' };

            if (OpenInputFile())
            {
                //Clear the Book Lists
                audioBooks.Clear();
                printBooks.Clear();

                // Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();
                    // Tokenize the line
                    string[] tokens = line.Split(delim);

                    // Validate the Correct Number of Tokens were found
                    if (tokens.Length == 3)
                    { 
                        // Validate the Book Price
                        if (Decimal.TryParse(tokens[1], out cost))
                        {
                            // Create a new book and add it to the correct list
                            newBook = new Book();
                            newBook.title = tokens[0];
                            newBook.cost = cost;
                            if (tokens[2] == "A")
                            {
                                //Add to Audio Book List
                                audioBooks.Add(newBook);
                            }
                            else if (tokens[2] == "P")
                            {
                                //Add to Print Books
                                printBooks.Add(newBook);
                            }
                            else
                            {
                                errorLog.Write("Error - Invalid Book Type ");
                                errorLog.Write(tokens[2]);
                                errorLog.WriteLine("Title " + tokens[0] + "Cost " + tokens[1]);
                            }
                        }
                        else
                        {
                            //Log the error message
                            errorLog.Write("Error - Invalid Price for ");
                            errorLog.Write(tokens[0]);
                            errorLog.WriteLine(" " + tokens[1] + " " + tokens[2]);
                        }
                    }
                    else
                    {
                        //Log the error message
                        errorLog.WriteLine("Error - Invalid Line - Wrong Number of Entries");
                        errorLog.WriteLine(line);
                    }
                }
                //Close the Input File
                inputFile.Close();
            }
            // Close the Error Log
            errorLog.Close();
        }

    }
}
