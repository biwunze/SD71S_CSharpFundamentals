using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class CandidateRepository
    {   // Field = A variable in the class that can be used anywhere or within all Methods.
        private List<Candidate> _listOfCandidates = new List<Candidate>();
        //public List<Candidates> ListOfCandidates { get; set; }                Should know it's a property w/ no _

        //Create- void because we don't need to return anything from the list
        public void AddCandidateToList(Candidate person)
        {
            _listOfCandidates.Add(person);
        }

        //Read
        public List<Candidate> GetCandidateList()                      //Method
        {
            return _listOfCandidates;
        }
         
        //Update
        public bool UpdateExistingCandidates(string originalName, Candidate newPerson)
        {
            // Find the person
            Candidate oldPerson = GetCandidateByName(originalName);

            // Update the person
            if (oldPerson != null)
            {                                       //Assigning new properties in place of the old ones.
                oldPerson.Name = newPerson.Name;
                oldPerson.CenterOfInterest = newPerson.CenterOfInterest;
                oldPerson.Experience = newPerson.Experience;
                oldPerson.PayExpectations = newPerson.PayExpectations;
                oldPerson.InterviewStatus = newPerson.InterviewStatus;
                oldPerson.OfferStatus = newPerson.OfferStatus;
                
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveCandidateFromList(string firstLastName)
        {
            Candidate person = GetCandidateByName(firstLastName);

            if (person == null)
            {
                return false;
            }

            int initialCount = _listOfCandidates.Count;
            _listOfCandidates.Remove(person);

            if(initialCount > _listOfCandidates.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Helper method - Used to find the correct candidate we're looking for. Helps the other methods.
        public Candidate GetCandidateByName(string firstLastName)
        {
            foreach(Candidate person in _listOfCandidates)
            {
                if(person.Name.ToLower() == firstLastName.ToLower())
                {
                    return person;
                }
            }

            return null;
        }
    }
}
