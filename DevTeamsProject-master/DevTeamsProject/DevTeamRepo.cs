using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        //private readonly DeveloperRepo _developerRepo = new DeveloperRepo();  this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void CreateTeam(DevTeam newDevTeam)
        {
            _devTeams.Add(newDevTeam);
        }

        //DevTeam Read
        public List<DevTeam> GetListOfTeams()
        {
            return _devTeams;
        }

        //DevTeam Update
        //Add to team
        public void AddDevToTeam(DevTeam newTeamMember)
        {
            _devTeams.Add(newTeamMember);
        }

        //Add multiple to team                                  @ 25 min of build REPO
        
        // Delete from team
        public bool DeleteDevFromTeamByID(Developer idNumber)
        {
            DevTeam oldTeamMember = GetTeamMemberByID(idNumber);

            if (oldTeamMember == null)
            {
                return false;
            }

            int firstMemberCount = _devTeams.Count;
            _devTeams.Remove(oldTeamMember);

            if (firstMemberCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID#)
        public DevTeam GetTeamMemberByID(Developer idNumber)
        {
            foreach(DevTeam devTeamMember in _devTeams)
            {
                if(devTeamMember.IdNumber == idNumber)
                {
                    return devTeamMember;
                }
            }

            return null;
        }
    }
}
