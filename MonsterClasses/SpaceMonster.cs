using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, IBattle
    {
        private bool _hasSpaceship;

        public bool HasSpaceShip
        {
            get { return _hasSpaceship; }
            set { _hasSpaceship = value; }
        }

        public override string Greeting()
        {
            return $"Hello I am a Space Monster and my name is {base.Name}";
        }

        public override bool IsHappy()
        {
            return _hasSpaceship ? true : false;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 66)
            {
                return MonsterAction.Attack;
            }
            else if (actionProbability >= 20)
            {
                return MonsterAction.Retreat;
            }
            else
            {
                return MonsterAction.Defend;
            }

        }
    }
}
