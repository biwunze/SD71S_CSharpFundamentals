using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddDevToList(Developer devPerson)
        {
            _developerDirectory.Add(devPerson);
        }

        //Developer Read "List of Developers" #3
        public List<Developer> GetListOfDevelopers()
        {
            return _developerDirectory;
        }
        //Developer Read "List of Developers who need PS" #4
        //public List<Developer> GetDevelopersPluralSight() {return}
        
        // Add multiple
        public void AddCoupleDevs(Developer newDvp)
        {
            Developer newDvpS = new Developer();
            int initialCountTwo = _developerDirectory.Count;

            Console.WriteLine("Would you like to add another Developer? (Y or N).");
            string addAnotherDevPer = Console.ReadLine().ToLower();

        }


        //PS helper
        public Developer GetDevelopersPluralSight(bool pluralSightAccess) 
        {
            foreach (Developer devPerson in _developerDirectory)
            {
                if (devPerson.PluralSightLicense == false)
                {
                    return devPerson;
                }
            }

            return null;
        }

        //Developer Update "Team"
        public bool UpdateDeveloperTeam(int originalDeveloperTeam, Developer newDeveloperTeam)
        {
            // find dev by ID
            Developer originalDeveloper = GetDeveloperByID(originalDeveloperTeam);

            // update dev team
            if (originalDeveloper != null)
            {
                originalDeveloper.NameOfTeam = newDeveloperTeam.NameOfTeam;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Developer Delete
        public bool DeleteDevFromDirectory(int idNumber)
        {
            Developer devPerson = GetDeveloperByID(idNumber);

            if (devPerson == null)
            {
                return false;
            }

            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(devPerson);

            if (initialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        public Developer GetDeveloperByID(int idNumber)
        {
            foreach(Developer devPerson in _developerDirectory)
            {
                if(devPerson.IdNumber == idNumber)
                {
                    return devPerson;
                }
            }

            return null;
        }

    }
}
