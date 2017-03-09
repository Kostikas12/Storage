using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cards
{
    public partial class MainControl : UserControl
    {
        private static int indexcard;
        private static int indextreeselected;  // 0 - not, 1 - deck , 2 - card
        private static int indexanimation;
        private static int indexanimationdriver;  // 0 - up, 1 - down

        public MainControl()
        {
            InitializeComponent();
            timer1.Interval = 90;
            tbType.BackColor = Color.White;
            tbCardName.BackColor = Color.White;
            btDelete.Enabled = false;
            indexcard = 0;
            tbCardName.ReadOnly = true;
            tbType.ReadOnly = true;
            tbType.TextAlign = HorizontalAlignment.Left;
            tbCardName.TextAlign = HorizontalAlignment.Left;
            listView1.ColumnWidthChanging+=listView1_ColumnWidthChanging;
            listView1.FullRowSelect = false;
            listView1.MultiSelect = false;
            indextreeselected = 0;
        }
        private static MainControl MainControlInstance;
        public static MainControl Instance
        {
            get 
            {
                if (MainControlInstance == null)
                {
                    MainControlInstance = new MainControl();
                }
                return MainControlInstance;
            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void btNewDeck_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            indexanimation = 0;
            AddDeckControl.Instance.StartVisual();
            AddDeckControl.Instance.BringToFront();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {

        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void RefreshDecks()
        {
            indextreeselected = 0;  // not selected
            btDelete.Enabled = false;
            listView1.Clear();
            SetDefaultCard();
            tbCardName.Clear();
            tbType.Clear();
            btAddCard.Enabled = false;
            new Operations().RefreshDecks(treeView1);
        }

        private void SetDefaultCard()
        {
            try
            {
                pictureBox1.Load(new PathContainer().IconsPathGet() + @"\CoverIcon.bmp");
                indexanimation = 0;
                indexanimationdriver = 0;
                timer1.Start();
                indexcard = 0;
                new Storage().CardImageMenuGetSet = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Рубашка карты [CoverIcon.bmp] не найдена!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Parent == null)
            {
                indextreeselected = 1;  // deck
                SetDefaultCard();
                tbCardName.Clear();
                btAddCard.Enabled = true;
                new Storage().DeckSelectedGetSet = treeView1.SelectedNode.Text;
                tbType.Text = string.Format("Вид колоды: {0}", new Storage().ListDeckGetSet.ElementAt(treeView1.SelectedNode.Index).DeckTypeGetSet);
                new Operations().FillListView(listView1, ref indexcard);
            }
            else
            {
                timer1.Stop();
                indexanimation = 0;
                indextreeselected = 2;  // card
                btAddCard.Enabled = false;
                new Storage().CardSelectedGetSet = treeView1.SelectedNode.Text;
                new Storage().DeckSelectedGetSet = treeView1.SelectedNode.Parent.Text;
                tbCardName.Text = string.Format("Карта: {0}", new Storage().CardSelectedGetSet);
                new Operations().LoadMenuCard(pictureBox1, ref indexcard);
                new Operations().FillListView(listView1, ref indexcard);
            }
            if (!treeView1.SelectedNode.IsSelected)
            {
                listView1.Clear();
                btDelete.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.IsSelected && listView1.SelectedItems.Count>0)
            {
                new Storage().CardSelectedGetSet = new Storage().ListCardsGetSet.ElementAt(listView1.SelectedIndices[0]);
                tbCardName.Text = string.Format("Name card: {0}", new Storage().CardSelectedGetSet);
                new Operations().LoadMenuCard(pictureBox1, ref indexcard);
                if (indexcard == 1)
                {
                    timer1.Stop();
                    indexanimation = 0;
                    CardViewControl.Instance.StartVisual();
                    CardViewControl.Instance.BringToFront();
                }
            }
        }

        private void btAddCard_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            indexanimation = 0;
            AddCardControl.Instance.StartVisual(new Storage().DeckSelectedGetSet);
            AddCardControl.Instance.BringToFront();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (indexcard == 1)
            {
                timer1.Stop();
                indexanimation = 0;
                CardViewControl.Instance.StartVisual();
                CardViewControl.Instance.BringToFront();
            }
            else
            {
                timer1.Interval = 10;
            }
        }

        private void tbCardName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (indextreeselected == 1)  // delete deck
            {
                DialogDelete formdel = new DialogDelete();
                formdel.StartPosition = FormStartPosition.CenterParent;
                formdel.VisualStartForDeck(indextreeselected);
                formdel.ShowDialog();

            }
            else
            {
                if (indextreeselected == 2)
                {
                    DialogDelete formdel = new DialogDelete();
                    formdel.StartPosition = FormStartPosition.CenterParent;
                    formdel.VisualStartForCard(indextreeselected);
                    formdel.ShowDialog();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnimationStart();
        }

        private void AnimationStart()
        {
            Random random = new Random();
            if (indexanimationdriver == 0 && indexanimation < 10)
            {
                indexanimation++;
                if (indexanimation == 10)
                {
                    indexanimationdriver = 1;
                    timer1.Interval = random.Next(90, 120);
                }
            }
            else
            {
                if (indexanimationdriver == 1 && indexanimation > 0)
                {
                    indexanimation--;
                    if (indexanimation == 0)
                    {
                        indexanimationdriver = 0;
                    }
                }
            }
            try
            {
                pictureBox1.Load(new PathContainer().AnimationPathGet() + @"\" + string.Format("CoverIcon{0}.bmp", indexanimation));
            }
            catch (Exception exc)
            {
                timer1.Stop();
                SetDefaultCard();
            }
        }
    }
}