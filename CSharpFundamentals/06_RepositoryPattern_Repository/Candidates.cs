using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    
    public enum Center
    {
        Brookhaven = 1,
        Columbus,
        Kennesaw,
        Marietta,
        Savannah
    }
    public enum Status
    {
        Emailed = 1,
        PhoneScreen,
        VideoInterview,
        Onsite,
        FeebackRecieved
    }

    public enum Offer
    {
        Extended = 1,
        Accepted,
        Declined
    }

    //POCO- Simple class that is an object that holda data. Not alot of methods.  Want properties and constructors.
    public class Candidate
    {
        public string Name { get; set; }
        public Center CenterOfInterest { get; set; }
        public double Experience { get; set; }
        public double PayExpectations { get; set; }
        public Status InterviewStatus { get; set; }
        public Offer OfferStatus { get; set; }

        //Constructors.  Empty and overloaded.
        public Candidate() { }

        public Candidate(string firstLastName, Center centerOfInterest, double experience, double payExpectations, Status interviewStatus, Offer offerStatus)
        {   
            
            //This constructor method can see all of the properties, because they were defined in the POCO.  
            Name = firstLastName;
            CenterOfInterest = centerOfInterest;
            Experience = experience;
            PayExpectations = payExpectations;
            InterviewStatus = interviewStatus;
            OfferStatus = offerStatus;

            //property Name = parameter name

        }
    }
}
