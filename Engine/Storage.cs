using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// K.V.

namespace Cards
{
    class Storage
    {
        private static string deckselected;
        public string DeckSelectedGetSet
        {
            get
            {
                return deckselected;
            }
            set
            {
                deckselected = value;
            }
        }

        private static string cardselected;
        public string CardSelectedGetSet
        {
            get
            {
                return cardselected;
            }
            set
            {
                cardselected = value;
            }
        }

        private static List<string> ListCards;
        public List<string> ListCardsGetSet
        {
            get { return ListCards; }
            set { ListCards = value; }
        }

        private static List<Deck> listdeck;
        public List<Deck> ListDeckGetSet
        {
            get { return listdeck; }
            set { listdeck = value; }
        }

        private static string cardImageMenu;
        public string CardImageMenuGetSet
        {
            get { return cardImageMenu; }
            set { cardImageMenu = value; }
        }

        private static List<Deck> ListDeckTypes;
        public List<Deck> ListDeckTypesGetSet
        {
            get { return ListDeckTypes; }
            set { ListDeckTypes = value; }
        }
    }
}
