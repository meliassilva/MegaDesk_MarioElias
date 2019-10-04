using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_MarioElias
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnAddNewQuote_Click(object sender, EventArgs e)
        {
            // create and show Add Quote form
            var addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();

            //hide the main menu form
            this.Hide();
           
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchQuote_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
