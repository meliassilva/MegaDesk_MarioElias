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
            Close();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            //read 
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();
                    if(quotes.Length > 0)
                    {
                        //deserialize
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            // add a new quote
            deskQuotes.Add(deskQuote);

            // save the file
            SaveQuotes(deskQuotes);
        }
        private void SaveQuotes(List<DeskQuote>quotes)
        {
            var quotesFile = @"quotes.json";

            //serialize
            var serializedQuotes = JsonConvert.SerializeObject(quotes);

            //write 
            File.WriteAllText(quotesFile, serializedQuotes);
        }

    }
}
