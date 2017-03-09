using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

// K.V.

namespace Cards
{
    class Operations
    {
        public void CreateDeck(string decktype, string deckname, List<string> listparams)
        {
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select Count(DeckName) "
                                         + " From Decks"
                                         + " Where DeckName=@DeckName");
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@DeckName", deckname);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                if (n>0)  // chek if this deck is already exists
                {
                    MessageBox.Show("Колода "+deckname+" уже существует!");
                }
                else
                {
                    // 1 Insert new deck into database
                    string sql1 = string.Format(" Insert Into Decks(DeckType,DeckName)"
                                              + " Values(@DeckType,@DeckName)");
                    SQLiteCommand cmd1 = new SQLiteCommand(sql1, connection);
                    cmd1.Parameters.AddWithValue("@DeckName", deckname);
                    cmd1.Parameters.AddWithValue("@DeckType", decktype);
                    int n1 = cmd1.ExecuteNonQuery();
                    if (n1!=1)
                    {
                        MessageBox.Show("Ошибка добавления колоды в базу!");
                    }

                    // 2 Check generated ID_Deck
                    string sql2 = string.Format(" Select ID_Deck"
                                              + " From Decks"
                                              + " Where DeckName=@DeckName");
                    SQLiteCommand cmd2 = new SQLiteCommand(sql2, connection);
                    cmd2.Parameters.AddWithValue("@DeckName", deckname);
                    int id_deck = Convert.ToInt32(cmd2.ExecuteScalar());

                    // 3 Insert new types of params in database
                    foreach(string paramname in listparams)
                    {
                        string sql3 = string.Format(" Insert Into Params(ID_Deck,ParamName)"
                                                  + " Values(@ID_Deck,@ParamName)");
                        SQLiteCommand cmd3 = new SQLiteCommand(sql3, connection);
                        cmd3.Parameters.AddWithValue("@ID_Deck", id_deck);
                        cmd3.Parameters.AddWithValue("@ParamName", paramname);
                        int n3 = cmd3.ExecuteNonQuery();
                        if (n3!=1)
                        {
                            MessageBox.Show("Ошибка добавления типа параметра для колоды.");
                        }
                    }

                    AddDeckControl.Instance.Clear();
                    MainControl.Instance.RefreshDecks(); // refresh!
                    MainControl.Instance.BringToFront();
                }
            }
        }

        public void RefreshDecks(TreeView treeView1)
        {
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            using (SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql1 = string.Format(" Select ID_Deck,DeckType,DeckName"
                                          + " From Decks");
                SQLiteCommand cmd1 = new SQLiteCommand(sql1, connection);
                SQLiteDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    List<Deck> listdecks = new List<Deck>();
                    while(reader1.Read())
                    {
                        listdecks.Add(new Deck(reader1));
                    }
                    reader1.Close();
                    new Storage().ListDeckGetSet = listdecks;

                    // === Find Icons
                    ImageList listimage = new ImageList();
                    List<string> listimagename = new List<string>();
                    listimage.ImageSize = new System.Drawing.Size(16, 16);
                    listimage.Images.Add(Image.FromFile(string.Format(new PathContainer().IconsPathGet()+@"\DeckIcon.bmp")));
                    treeView1.ImageList = listimage;
                    
                    // === Get cards of deck
                    int i = 0;
                    List<Card> listcards = new List<Card>();
                    foreach (Deck deck in listdecks)
                    {
                        treeView1.Nodes.Add(deck.DeckNameGetSet);

                        string sql2 = string.Format(" Select ID_Card,ID_Deck,CardName,CardImage"
                                                  + " From Cards"
                                                  + " Where ID_Deck=@ID_Deck");
                        SQLiteCommand cmd2 = new SQLiteCommand(sql2, connection);
                        cmd2.Parameters.AddWithValue("@ID_Deck", deck.ID_DeckGetSet);
                        SQLiteDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                Card card = new Card(reader2);
                                treeView1.Nodes[i].Nodes.Add(card.CardNameGetSet);
                            }
                        }
                        reader2.Close();
                        i++;
                    }  // === End Get cards of deck
                }
            }
            treeView1.EndUpdate();
        }

        public List<string> FindNameParams()
        {
            List<string> list = new List<string>();
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select ParamName"
                                          + " From Params"
                                          + " Where ID_Deck=( Select ID_Deck"
                                                          + " From Decks"
                                                          + " Where DeckName=@DeckName)");
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            return list;
        }

        public void AddNewCard(string cardname, string cardimage, List<string> listnameparams, List<string> listvalueparams) ///////
        {
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql1 = string.Format(" Select ID_Deck"
                          + " From Decks"
                          + " Where DeckName=@DeckName");
                SQLiteCommand cmd1 = new SQLiteCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                int id_deck = Convert.ToInt32(cmd1.ExecuteScalar());

                string sql2 = string.Format(" Select Count(CardName)"
                                          + " From Cards" 
                                          + " Where ID_Deck=@ID_Deck AND CardName=@CardName");
                SQLiteCommand cmd2 = new SQLiteCommand(sql2, connection);
                cmd2.Parameters.AddWithValue("@ID_Deck", id_deck);
                cmd2.Parameters.AddWithValue("@CardName", cardname);
                int n2 = Convert.ToInt32(cmd2.ExecuteScalar());
                if (n2 == 1)
                {
                    MessageBox.Show("Карта ["+cardname+"] уже существует в данной колоде!");
                }
                else
                {
                    string sql3 = string.Format(" Insert Into Cards(ID_Deck,CardName,CardImage)"
                                              + " Values(@ID_Deck,@CardName,@CardImage)");
                    SQLiteCommand cmd3 = new SQLiteCommand(sql3, connection);
                    cmd3.Parameters.AddWithValue("@ID_Deck", id_deck);
                    cmd3.Parameters.AddWithValue("@CardName", cardname);
                    cmd3.Parameters.AddWithValue("@CardImage", cardimage);
                    int n3 = cmd3.ExecuteNonQuery();
                    if (n3 != 1)
                    {
                        MessageBox.Show("Ошибка записи карты ["+cardname+"]!");
                    }
                    else
                    {   // find generated id_card
                        string sql4 = string.Format(" Select ID_Card"
                                                  + " From Cards"
                                                  + " Where ID_Deck=@ID_Deck AND CardName=@CardName");
                        SQLiteCommand cmd4 = new SQLiteCommand(sql4, connection);
                        cmd4.Parameters.AddWithValue("@ID_Deck", id_deck);
                        cmd4.Parameters.AddWithValue("@CardName", cardname);
                        int id_card = Convert.ToInt32(cmd4.ExecuteScalar());

                        string sql5 = string.Format(" Insert Into ParamValues(ID_Card,ParamName,ParamValue)"
                                                  + " Values(@ID_Card,@ParamName,@ParamValue)");
                        int i = 0;
                        int indexsubmit = 0;
                        foreach(string nameparam in listnameparams)
                        {
                            SQLiteCommand cmd5 = new SQLiteCommand(sql5, connection);
                            cmd5.Parameters.AddWithValue("@ID_Card", id_card);
                            cmd5.Parameters.AddWithValue("@ParamName", nameparam);
                            cmd5.Parameters.AddWithValue("@ParamValue", listvalueparams.ElementAt(i));
                            int n5 = cmd5.ExecuteNonQuery();
                            if (n5!=1)
                            {
                                MessageBox.Show("Ошибка записи параметра ["+nameparam+"]!");
                                indexsubmit++;
                            }
                            i++;
                        }
                        if (indexsubmit == 0)
                        {
                            MessageBox.Show("Карта ["+cardname+"] добавлена в колоду!");
                            AddCardControl.Instance.FindImages();
                        }
                    }
                }
            }
        }

        public void LoadMenuCard(PictureBox pictureBox1, ref int indexcard)
        {
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select CardImage"
                                         + " From Cards"
                                         + " Where CardName=@CardName AND ID_Deck=(Select ID_Deck "
                                                                               + " From Decks "
                                                                               + " Where DeckName=@DeckName)");
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@CardName", new Storage().CardSelectedGetSet);
                cmd.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                string imagecardname = cmd.ExecuteScalar().ToString();
                if (true)
                {
                    try   
                    {
                        pictureBox1.Load(new PathContainer().ImagesPathGet() + @"\" + imagecardname);
                        indexcard = 1;
                    }           
                    catch (Exception exc)          
                    {
                        MessageBox.Show("Картинка карты [" + imagecardname + "] не найдена!");
                        indexcard = 0;
                        new Storage().CardImageMenuGetSet = null;
                    }
                    if (indexcard == 1)
                    {
                        new Storage().CardImageMenuGetSet = imagecardname;
                    }
                }
            }
        }

        public void LoadParamValues(ListBox listBox1)
        {
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select ParamName,ParamValue"
                                         + " From ParamValues"
                                         + " Where ID_Card=(Select ID_Card"
                                                        + " From Cards"
                                                        + " Where CardName=@CardName AND ID_Deck=(Select ID_Deck"
                                                                                              + " From Decks"
                                                                                              + " Where DeckName=@DeckName))");
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@CardName", new Storage().CardSelectedGetSet);
                cmd.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        listBox1.Items.Add(string.Format("{0} - {1}", reader.GetString(0), reader.GetString(1)));
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка загрузки параметров и значений карты ["+new Storage().CardSelectedGetSet+"]!");
                }
            }
        }

        public void FindExistsTypes(ListBox lstbExistsTypes, Label lbNoTypes)
        {
            lstbExistsTypes.Items.Clear();
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql1 = string.Format(" Select ID_Deck,DeckType,DeckName"
                                          + " From Decks"
                                          + " GROUP BY DeckType");
                SQLiteCommand cmd1 = new SQLiteCommand(sql1, connection);
                SQLiteDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    lbNoTypes.Visible = false;
                    List<Deck> listDeckTypes = new List<Deck>();
                    while(reader.Read())
                    {
                        listDeckTypes.Add(new Deck(reader));
                        lstbExistsTypes.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                    new Storage().ListDeckTypesGetSet = listDeckTypes;
                }
                else
                {
                    lbNoTypes.Visible = true;
                }
            }
        }

        public void FindParamNamesOfExistType(ListBox lstbExistsTypes, ListBox listBox1)
        {
            listBox1.Items.Clear();
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select ParamName"
                                         + " From Params"
                                         + " Where ID_Deck=@ID_Deck");
                SQLiteCommand cmd = new SQLiteCommand(sql,connection);
                cmd.Parameters.AddWithValue("@ID_Deck", new Storage().ListDeckTypesGetSet.ElementAt(lstbExistsTypes.SelectedIndex).ID_DeckGetSet);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка поиска названия параметров указанного типа колод!");
                }
            }
        }

        public void FillListView(ListView listView1, ref int indexcard) 
        {
            listView1.Clear();
            using(SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
            {
                connection.Open();
                string sql = string.Format(" Select CardName,CardImage"
                                         + " From Cards,Decks"
                                         + " Where Cards.ID_Deck=Decks.ID_Deck AND"
                                         + " DeckName=@DeckName");
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    ImageList imageList = new ImageList();
                    List<string> listcardname = new List<string>();
                    while(reader.Read())
                    {
                        imageList.Images.Add(Image.FromFile(new PathContainer().ImagesPathGet()+@"\"+reader.GetString(1)));
                        listcardname.Add(reader.GetString(0));
                    }
                    reader.Close();
                    new Storage().ListCardsGetSet = listcardname;

                    listView1.View = View.Details;  // to use IndentCount.
                    listView1.GridLines = true;
                    listView1.Columns.Add("Карта", 67, HorizontalAlignment.Center);
                    listView1.Columns.Add("Название карты", 100, HorizontalAlignment.Center);
                    
                    imageList.ImageSize = new Size(160/4,210/4);
                    listView1.SmallImageList = imageList;

                    for (int i = 0; i < imageList.Images.Count; i++)
                    {
                        ListViewItem item1 = new ListViewItem();
                        item1.ImageIndex = i;
                        listView1.Items.Add(item1).SubItems.Add(listcardname.ElementAt(i));
                    }
                }
            }
        }

        public void DeleteElement(int indextreeselected)   // 1 - deck, 2 - card
        {
            if (indextreeselected == 1)  // deck delete
            {
                using (SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
                {
                    connection.Open();
                    List<string> cardnamelist = new Storage().ListCardsGetSet; // get cards from selected deck

                    if (cardnamelist!=null)
                    {
                        foreach (string cardname in cardnamelist)
                        {
                            // === ParamValues of card
                            string sql2 = string.Format(" Delete From ParamValues"
                                                      + " Where ID_Card=( Select ID_Card"
                                                                      + " From Cards"
                                                                      + " Where CardName=@CardName AND ID_Deck=( Select ID_Deck"
                                                                                                             + " From Decks"
                                                                                                             + " Where DeckName=@DeckName))");
                            SQLiteCommand cmd2 = new SQLiteCommand(sql2, connection);
                            cmd2.Parameters.AddWithValue("@CardName", cardname);  // cardname from list
                            cmd2.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                            int n2 = cmd2.ExecuteNonQuery();

                            // === delete this card
                            string sql3 = string.Format(" Delete From Cards"
                                                      + " Where CardName=@CardName AND ID_Deck=( Select ID_Deck"
                                                                                             + " From Decks"
                                                                                             + " Where DeckName=@DeckName)");
                            SQLiteCommand cmd3 = new SQLiteCommand(sql3, connection);
                            string sn = new Storage().CardSelectedGetSet;
                            cmd3.Parameters.AddWithValue("@CardName", cardname);  // cardname from list
                            cmd3.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                            cmd3.ExecuteNonQuery();
                        }
                    }

                    string sql4 = string.Format(" Delete From Decks"
                                              + " Where DeckName=@DeckName");
                    SQLiteCommand cmd4 = new SQLiteCommand(sql4, connection);
                    cmd4.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                    int n4 = cmd4.ExecuteNonQuery();
                    if (n4!=1)
                    {
                        MessageBox.Show("Колода не была удалена!");
                    }
                }
            }
            else
            {
                if (indextreeselected == 2)  // card delete
                {
                    using (SQLiteConnection connection = new SQLiteConnection(new PathContainer().ConnStrGet()))
                    {
                        connection.Open();
                        // === ParamValues of card
                        string sql2 = string.Format(" Delete From ParamValues"
                                                  + " Where ID_Card=( Select ID_Card"
                                                                  + " From Cards"
                                                                  + " Where CardName=@CardName AND ID_Deck=( Select ID_Deck"
                                                                                                         + " From Decks"
                                                                                                         + " Where DeckName=@DeckName))");
                        SQLiteCommand cmd2 = new SQLiteCommand(sql2, connection);
                        cmd2.Parameters.AddWithValue("@CardName", new Storage().CardSelectedGetSet);
                        cmd2.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                        int n2 = cmd2.ExecuteNonQuery();

                        // === card
                        string sql3 = string.Format(" Delete From Cards"
                                                  + " Where CardName=@CardName AND ID_Deck=( Select ID_Deck"
                                                                                         + " From Decks"
                                                                                         + " Where DeckName=@DeckName)");
                        SQLiteCommand cmd3 = new SQLiteCommand(sql3, connection);
                        string sn = new Storage().CardSelectedGetSet;
                        cmd3.Parameters.AddWithValue("@CardName", new Storage().CardSelectedGetSet);
                        cmd3.Parameters.AddWithValue("@DeckName", new Storage().DeckSelectedGetSet);
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
            MainControl.Instance.RefreshDecks();
        }
    }
}