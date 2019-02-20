using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster : Monster
    {
        private bool _hasGills;
        private string _seaName;

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }
        
        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }


        public override bool IsHappy()
        {
            return true;
        }
    }
}
