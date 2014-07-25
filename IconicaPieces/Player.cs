using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IconicaPieces
{
    public class Player
    {
        public List<Card> party = new List<Card>();

        public Player()
        {

        }

        public bool isPartyDead()
        {
            return party.Where(x => x.Health > 0).Count() > 0 ? false : true;
        }

        public void ChooseCharacter(Card card)
        {
            party.Add(card);
        }

        public void TakeTurn()
        {
            OpeningPhase();
            ActionPhase();
            ClosingPhase();
        }

        private void OpeningPhase()
        {
            throw new NotImplementedException();
        }

        private void ActionPhase()
        {
            throw new NotImplementedException();
        }

        private void ClosingPhase()
        {
            throw new NotImplementedException();
        }
    }
}
