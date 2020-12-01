using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        //POCO
        public TeamName Team { get; set; }
        public Developer Name { get; set; }
        public Developer IdNumber { get; set; }

        //Constructor
        public DevTeam() { }

        public DevTeam(TeamName team, Developer name, Developer idNumber)
        {
            Team = team;
            Name = name;
            IdNumber = idNumber;
        }
    }
}
