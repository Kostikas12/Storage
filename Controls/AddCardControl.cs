using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cards
{
    public partial class AddCardControl : UserControl
    {
        List<string> listnameparams;
        List<string> listvalueparams;
        private static int indeximage;
        public AddCardControl()
        {
            InitializeComponent();
            tbOne.Enabled = false;
            tbOne.BackColor = Color.White;
            tbCardName.MaxLength = 8;
            tbOne.MaxLength = 8;
            tbTwo.MaxLength = 8;
        }
        private static AddCardControl AddCardControlInstance;
        public static AddCardControl Instance
        {
            get
            {
                if (AddCardControlInstance == null)
                {
                    AddCardControlInstance = new AddCardControl();
                }
                return AddCardControlInstance;
            }
        }

        private void AddCardControl_Load(object sender, EventArgs e)
        {

        }

        public void StartVisual(string deckname)
        {
            lbMess.Visible = true;
            tbTwo.Enabled = true;
            tbTwo.BackColor = Color.Orange;
            tbCardName.Enabled = false;
            tbCardName.BackColor = Color.White;
            listvalueparams = new List<string>();
            indeximage = 0;
            btAddCard.Enabled = false;
            btAddCard.BackColor = Color.White;
            FindImages();
            lbDeckName.Text = "["+deckname+"]";
            listnameparams = new Operations().FindNameParams();
            lbNumParams.Text = string.Format("Всего параметров: {0}", listnameparams.Count);
            lbOne.Text = "Имя параметра 1:";
            tbOne.Text = listnameparams.ElementAt(0);
        }
        public void FindImages()
        {
            Clear();
            indeximage = 0;
            btAddCard.Enabled = false;
            btAddCard.BackColor = Color.White;
            try
            {
                pictureBox1.Load(new PathContainer().IconsPathGet() + @"\CoverIcon.bmp");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Изображение CoverIcon.bmp отсутствует в папке Icons!");
                pictureBox1.Image = null;
            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(new PathContainer().ImagesPathGet());
            foreach(var imagename in dir.GetFiles())
            {
                listBox1.Items.Add(imagename.Name);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Clear();
            MainControl.Instance.RefreshDecks();
            MainControl.Instance.BringToFront();
        }

        private void Clear()
        {
            tbTwo.Enabled = true;
            listBox1.Items.Clear();
            lstbValueParams.Items.Clear();
            tbOne.Clear();
            tbTwo.Clear();
            tbCardName.Clear();
            indeximage = 0;
            listvalueparams.Clear();
            lbOne.Text = "Имя параметра 1:";
            if (listnameparams!=null)
            {
                tbOne.Text = listnameparams.ElementAt(0);
            }
            lbListValues.Text = "Значения параметров";
            tbCardName.Enabled = false;
            tbCardName.BackColor = Color.White;
            lbMess.Visible = true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                string imagename = listBox1.SelectedItem.ToString();
                try
                {
                    pictureBox1.Load(new PathContainer().ImagesPathGet() + @"\" + imagename);
                    indeximage = 1;
                    lbMess.Visible = false;
                    CheckInfo();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Выбранное изображение ["+imagename+"] отсутствует в папке Images!");
                    FindImages();
                }
            }
        }

        private void btUpdateList_Click(object sender, EventArgs e)
        {
            FindImages();
        }

        private void tbCardName_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
            if (tbCardName.Text.Length==0)
            {
                tbCardName.BackColor = Color.Orange;
            }
            else
            {
                tbCardName.BackColor = Color.White;
            }
        }
        private void tbOne_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
        }
        private void tbTwo_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
            if (tbTwo.Text.Length == 0)
            {
                tbTwo.BackColor = Color.Orange;
            }
            else
            {
                tbTwo.BackColor = Color.White;
            }
        }

        private void CheckInfo()
        {
            if (tbOne.Text.Length==0 || tbTwo.Text.Length==0)
            {
                btSaveValue.Enabled = false;
            }
            else
            {
                btSaveValue.Enabled = true;
                if (listnameparams.Count > listvalueparams.Count)
                {
                    btSaveValue.Enabled = true;
                }
                else
                {
                    btSaveValue.Enabled = false;
                }
            }

            if (tbCardName.Text.Length!=0 && indeximage == 1 && listnameparams.Count == listvalueparams.Count)
            {
                btAddCard.Enabled = true;
                btAddCard.BackColor = Color.LightGreen;
            }
            else
            {
                btAddCard.Enabled = false;
                btAddCard.BackColor = Color.White;
            }
        }

        private void btSaveValue_Click(object sender, EventArgs e)
        {
            listvalueparams.Add(tbTwo.Text);
            lstbValueParams.Items.Add(string.Format("{0}: {1}", tbOne.Text, tbTwo.Text));
            if ( listnameparams.Count > lstbValueParams.Items.Count )
            {
                lbOne.Text = string.Format("Имя параметра {0}:", listvalueparams.Count+1);
                tbOne.Text = listnameparams.ElementAt(lstbValueParams.Items.Count);
            }
            else
            {
                tbTwo.Enabled = false;
                btSaveValue.Enabled = false;
                lbListValues.Text = "Значения параметров ЗАПОЛНЕНЫ!";
                tbCardName.Enabled = true;
                tbCardName.BackColor = Color.Orange;
            }
        }

        private void btAddCard_Click(object sender, EventArgs e)
        {
            new Operations().AddNewCard(tbCardName.Text, listBox1.SelectedItem.ToString(), listnameparams, listvalueparams);
        }

        private void lstbValueParams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


// pictureBox1.Load(new PathContainer().ImagesPathGet()+@"\1.Murloc.bmp");