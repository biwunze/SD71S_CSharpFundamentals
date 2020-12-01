using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{

    public enum TeamName
    {
        Wizards = 1,
        Warlocks,
        Dragons,
        Witches,
        Warriors,
        Sorcerers,
        Legends
    }

    //POCO
    public class Developer
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public bool PluralSightLicense { get; set; }
        public TeamName NameOfTeam { get; set; }

        public Developer() { }

        public Developer(string name, int idNumber, bool pluralSightAccess, TeamName team)
        {
            Name = name;
            IdNumber = idNumber;
            PluralSightLicense = pluralSightAccess;
            NameOfTeam = team;
        }

    }
}
