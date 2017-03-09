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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(MainControl.Instance);
            this.Controls.Add(AddDeckControl.Instance);
            this.Controls.Add(AddCardControl.Instance);
            this.Controls.Add(CardViewControl.Instance);
            MainControl.Instance.RefreshDecks();
            MainControl.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
