using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

// K.V.

namespace Cards
{
    class Card
    {
        private int ID_Card;
        private int ID_Deck;
        private string CardName;
        private string CardImage;

        public Card()
        { 
        }

        public Card(SQLiteDataReader reader)  // full reader
        {
            this.ID_Card = reader.GetInt32(0);
            this.ID_Deck = reader.GetInt32(1);
            this.CardName = reader.GetString(2);
            this.CardImage = reader.GetString(3);
        }
        public int ID_CardGetSet
        {
            get { return ID_Card; }
            set { ID_Card = value; }
        }
        public int ID_DeckGetSet
        {
            get { return ID_Deck; }
            set { ID_Deck = value; }
        }
        public string CardNameGetSet
        {
            get { return CardName; }
            set { CardName = value; }
        }
        public string CardImageGetSet
        {
            get { return CardImage; }
            set { CardImage = value; }
        }
    }
}
