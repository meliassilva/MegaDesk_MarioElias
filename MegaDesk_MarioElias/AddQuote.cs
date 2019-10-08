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
using Newtonsoft.Json;

namespace MegaDesk_MarioElias
{
    public partial class AddQuote : Form
    {
        //private Form _mainMenu;
        public AddQuote()
        {
            InitializeComponent();
            //_mainMenu = mainMenu;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //show main menu form
            var mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
