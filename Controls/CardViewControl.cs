using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class CardViewControl : UserControl
    {
        public CardViewControl()
        {
            InitializeComponent();
            tbCardName.ReadOnly = true;
            tbCardName.TextAlign = HorizontalAlignment.Center;
        }

        private static CardViewControl CardViewControlInstance;
        public static CardViewControl Instance
        {
            get
            {
                if (CardViewControlInstance == null)
                {
                    CardViewControlInstance = new CardViewControl();
                }
                return CardViewControlInstance;
            }
        }

        public void StartVisual()
        {
            tbCardName.Text = new Storage().CardSelectedGetSet;
            try
            {
                pictureBox1.Load(new PathContainer().ImagesPathGet() + @"\" + new Storage().CardImageMenuGetSet);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Карта [" + new Storage().CardImageMenuGetSet + "] не найдена!");
                new Storage().CardImageMenuGetSet = null;
            }

            new Operations().LoadParamValues(listBox1);
        }

        private void CardViewControl_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Clear();
            MainControl.Instance.RefreshDecks();
            MainControl.Instance.BringToFront();
        }

        private void Clear()
        {
            listBox1.Items.Clear();
        }
    }
}
