using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    internal class Players
    {
        //Name, age, team, position
        public int age;
        public string playerName;
        public string team;
        public string position;

        public Players (int _age, string _name, string _team, string _position)
        {
            age = _age;
            playerName = _name;
            team = _team;
            position = _position;
        }
    }
}
