using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_ShoppingCart
{
    public partial class ShoppingCartForm : Form
    {
        //Class Global Variables
        public ShoppingCartForm()
        {
            InitializeComponent();
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
    }
}