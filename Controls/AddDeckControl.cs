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
    public partial class AddDeckControl : UserControl
    {
        List<string> listparams;
        public AddDeckControl()
        {
            InitializeComponent();
            tbType.MaxLength = 13;
            tbName.MaxLength = 13;
            tbOne.MaxLength = 8;
            tbNumParams.MaxLength = 2;
            tbNumParams.KeyPress += new KeyPressEventHandler(this.tbNumParams_KeyPress);
        }
        private static AddDeckControl AddDeckControlInstance;
        public static AddDeckControl Instance
        {
            get
            {
                if (AddDeckControlInstance == null)
                {
                    AddDeckControlInstance = new AddDeckControl();
                }
                return AddDeckControlInstance;
            }
        }

        public void StartVisual()
        {
            lbNoTypes.Visible = false;
            GroupNewDeckEnable();
            lstbExistsTypes.Enabled = false;
            rbNewType.Checked = true;
            tbNumParams.Enabled = true;
            tbNumParams.Text = "1";
            lbOne.Text = "Название параметра 1:";
            btCreate.Enabled = false;
            lbMess.Visible = true;
            btSaveParam.Enabled = false;
            btBack.Focus();
            new Operations().FindExistsTypes(lstbExistsTypes, lbNoTypes);
        }

        public void Clear()
        {
            lstbExistsTypes.Enabled = false;
            rbNewType.Checked = true;
            lbOne.Text = "Название параметра 1";
            tbType.Clear();
            tbName.Clear();
            tbNumParams.Clear();
            tbOne.Clear();
            listBox1.Items.Clear();
            btSaveParam.Enabled = false;
            btCreate.Enabled = false;
            btCreate.BackColor = Color.White;
            lbMess.Visible = true;
            tbNumParams.Enabled = true;
            new Operations().FindExistsTypes(lstbExistsTypes, lbNoTypes);
        }

        private void AddDeckControl_Load(object sender, EventArgs e)
        {

        }

        private void GroupNewDeckEnable()
        {
            tbType.Enabled = true;
            tbOne.Enabled = true;
            tbNumParams.Enabled = true;
            btSaveParam.Enabled = true;
        }

        private void GroupNewDeckDisable()
        {
            tbType.Enabled = false;
            tbOne.Enabled = false;
            tbNumParams.Enabled = false;
            btSaveParam.Enabled = false;
        }

        private void bt_Click(object sender, EventArgs e)
        {
            listparams = new List<string>();
            string type = null;
            foreach (string s in listBox1.Items)
            {
                listparams.Add(s);
            }
            if (rbNewType.Checked==true)
            {
                type = tbType.Text;
            }
            else
            {    // if (rbExistType.Checked == true)
                type = lstbExistsTypes.Text;
            }
            new Operations().CreateDeck(type, tbName.Text, listparams);
            listparams = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            MainControl.Instance.RefreshDecks();
            MainControl.Instance.BringToFront();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbNumParams_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
        }

        private void tbOne_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
        }
        private void tbNumParams_TextChanged(object sender, EventArgs e)
        {
            CheckInfo();
            if (tbNumParams.Text.Length == 0 || tbNumParams.Text == "0")
            {
                tbNumParams.BackColor = Color.Orange;
            }
            else
            {
                tbNumParams.BackColor = Color.White;
            }
        }

        private void CheckInfo()
        {
            if (rbExistType.Checked == false)
            {
                if (tbNumParams.Text.Length == 0 || tbNumParams.Text == "0" || tbOne.Text.Length == 0)
                {
                    btSaveParam.Enabled = false;
                }
                else
                {
                    btSaveParam.Enabled = true;
                    if (Convert.ToInt32(tbNumParams.Text) > listBox1.Items.Count)
                    {
                        btSaveParam.Enabled = true;
                    }
                    else
                    {
                        btSaveParam.Enabled = false;
                    }
                }

                if (tbNumParams.Text.Length != 0)
                {
                    if (Convert.ToInt32(tbNumParams.Text) == listBox1.Items.Count && tbName.Text.Length != 0 && tbType.Text.Length != 0)
                    {
                        btCreate.Enabled = true;
                        btCreate.BackColor = Color.LightGreen;
                        lbMess.Visible = false;
                    }
                    else
                    {
                        btCreate.Enabled = false;
                        btCreate.BackColor = Color.White;
                        lbMess.Visible = true;
                    }
                }
            }
            else   // if radio-button Exists .Enabled == true
            {  
                if (tbName.Text.Length!=0 && lstbExistsTypes.SelectedIndex!=-1)
                {
                    btCreate.Enabled = true;
                    btCreate.BackColor = Color.LightGreen;
                    lbMess.Visible = false;
                }
                else
                {
                    btCreate.Enabled = false;
                    btCreate.BackColor = Color.White;
                    lbMess.Visible = true;
                }
            }
        }
        private void btSaveParam_Click(object sender, EventArgs e)
        {
            tbNumParams.Enabled = false;
            listBox1.Items.Add(tbOne.Text);
            tbOne.Clear();
            if (Convert.ToInt32(tbNumParams.Text) > listBox1.Items.Count)
            {
                lbOne.Text = string.Format("Название параметра {0}:", listBox1.Items.Count + 1);
            }
        }

        private void rbExistType_CheckedChanged(object sender, EventArgs e)
        {
            GroupNewDeckDisable();
            lbOne.Text = "Название параметра 1";
            tbType.Clear();
            tbNumParams.Clear();
            tbOne.Clear();
            listBox1.Items.Clear();
            lstbExistsTypes.Enabled = true;
            new Operations().FindExistsTypes(lstbExistsTypes, lbNoTypes);
        }

        private void rbNewType_CheckedChanged(object sender, EventArgs e)
        {
            GroupNewDeckEnable();
            btCreate.Enabled = false;
            btCreate.BackColor = Color.White;
            lbMess.Visible = true;
            lstbExistsTypes.Enabled = false;
            listBox1.Items.Clear();
            CheckInfo();
        }

        private void lstbExistsTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbExistsTypes.SelectedIndex != -1)
            {
                new Operations().FindParamNamesOfExistType(lstbExistsTypes, listBox1);
                if (tbName.Text.Length != 0)
                {
                    btCreate.Enabled = true;
                    btCreate.BackColor = Color.LightGreen;
                    lbMess.Visible = false;
                }
                else
                {
                    btCreate.Enabled = false;
                    btCreate.BackColor = Color.White;
                    lbMess.Visible = true;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
