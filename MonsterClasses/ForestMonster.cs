using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class ForestMonster : Monster
    {
        private bool _hasHorns;

        public bool HasHorns
        {
            get { return _hasHorns; }
            set { _hasHorns = value; }
        }

        public override bool IsHappy()
        {
            return true;
        }

        public MonsterReaction MonsterHugResponse()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 66)
            {
                return MonsterReaction.Smile;
            }
            else if (actionProbability >= 20)
            {
                return MonsterReaction.Frown;
            }
            else
            {
                return MonsterReaction.Cry;
            }

        }
    }
}
