using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IconicaPieces
{
    class Action
    {
        KeyValuePair<Player, Card> Source;
        KeyValuePair<Player, Card>[] Target;
        public ActionType ActionType { get; private set; }

        public Action(KeyValuePair<Player,Card> src, KeyValuePair<Player,Card>[] trgt, params object[] args)
        {
            Source = src;
            Target = trgt;

            //Execute Action Arguements in order
            for (int i = 0; i < args.Length; i++)
            {
                ExecuteAction(args[i]);
            }
        }

        private void ExecuteAction(object p)
        {
            throw new NotImplementedException();
        }
    }

    enum ActionType
    {
        FinalAct,
        Status,
        Melee,
        Ranged,
        Stance,
        Support,
        Healing,
        Reactive
    }
}
