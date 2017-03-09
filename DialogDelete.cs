using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class DialogDelete : Form
    {
        private static int indextreeselected;
        public DialogDelete()
        {
            InitializeComponent();
            tbDeckName.ReadOnly = true;
            tbDeckName.TextAlign = HorizontalAlignment.Center;
            btNo.Focus();
        }

        public void VisualStartForCard(int x)
        {
            indextreeselected = x;
            lbtext.Text = "Удаление карты";
            tbDeckName.Text = new Storage().CardSelectedGetSet;
        }

        public void VisualStartForDeck(int x)
        {
            indextreeselected = x;
            lbtext.Text = "Удаление колоды";
            tbDeckName.Text = new Storage().DeckSelectedGetSet;
        }

        private void DialogDeleteDeck_Load(object sender, EventArgs e)
        {
            try
            {
                Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(new PathContainer().ProjectPathGet() + @"\Cards.ico");
                this.Icon = icon;
            }
            catch (Exception exc)
            {

            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            MainControl.Instance.RefreshDecks();
            Clear();
            this.Close();
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            new Operations().DeleteElement(indextreeselected);
            Clear();
            this.Close();
        }
        private void Clear()
        {
            tbDeckName.Clear();
            lbtext.Text = "";
        }
    }
}
