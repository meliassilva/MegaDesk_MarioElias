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
    public partial class SearchQuote : Form
    {
        private Form _mainMenu;
        public SearchQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void SearchQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
