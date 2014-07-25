using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IconicaPieces
{
    public class Game
    {
        // TODO - Rules Engine Research http://blogs.microsoft.co.il/bursteg/2007/08/09/using-wf-rules-engine-without-any-workflow/
        // TODO - Implement a two player game

        public int Turn { get; private set; }
        public int NumberOfPlayers { get; private set; }
        public SortedDictionary<int,Player> Players { get; private set; }
        public int PartySize { get; private set; }

        public Game()
        {
            // Setup game
            Turn = 0;
            NumberOfPlayers = 2;
            PartySize = 3;
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                AddPlayer(new Player());
            }
        }

        public void StartGame()
        {
            List<Card> AvailableCharacters = LoadAvailableCharacters();
            //Players take turns choosing cards and stop when each player has reached the party size
            while (Players.Values.Where(p => p.party.Count != PartySize).Count() > 0)
            {
                foreach (var p in Players.Values)
                {
                    p.ChooseCharacter(new Card());
                }
            }
        }

        private List<Card> LoadAvailableCharacters()
        {
            //TODO - Implements retrieving cards from a data store
            throw new NotImplementedException();
        }

        public void TakeTurn()
        {
            foreach (var p in Players.Values)
            {
                p.TakeTurn();
            }
            Turn++;
        }

        private void AddPlayer(Player p)
        {
            if (p != null)
            {
                int i = Players.Keys.Count == 0 ? 0 : Players.Keys.Max();

                Players.Add(i + 1, p);
            }
        }

        /// <summary>
        /// Determines if the game is over
        /// </summary>
        /// <returns>true if a player's party is all dead, otherwise false</returns>
        public bool isGameOver()
        {
            bool result = false;
            foreach (var p in Players.Values)
            {
                if (p.isPartyDead())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
