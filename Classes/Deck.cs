using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

// K.V.

namespace Cards
{
    class Deck
    {
        private int ID_Deck;
        private string DeckType;
        private string DeckName;

        public Deck()
        { 
        }
        public Deck(SQLiteDataReader reader)
        {
            this.ID_Deck = reader.GetInt32(0);
            this.DeckType = reader.GetString(1);
            this.DeckName = reader.GetString(2);
        }

        public int ID_DeckGetSet
        {
            get { return ID_Deck; }
            set { ID_Deck = value; }
        }
        public string DeckTypeGetSet
        {
            get { return DeckType; }
            set { DeckType = value; }
        }
        public string DeckNameGetSet
        {
            get { return DeckName; }
            set { DeckName = value; }
        }
    }
}
