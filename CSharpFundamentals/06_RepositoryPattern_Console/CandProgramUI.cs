using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class CandProgramUI
    {
        // _candidateRepo Allows us to keep all changes to the repo as long as app is open.
        private CandidateRepository _candidateRepo = new CandidateRepository();

        // Saying, I have a program UI, and I'd like to run it.
        // Method that starts/runs the UI of application.
        public void Running()
        {
            SeedCandidateList();
            AppMenu();
        }

        // Menu- private because we don't want people to skip the Running method.
        private void AppMenu()
        {

            // Keeps the app running without closing, until we change case 6 to exit.
            bool keepRunningApp = true;
            while (keepRunningApp)
            {



                // Display our options to the user
                Console.WriteLine("Please choose an option:\n" +
                    "1. Create new Candidate\n" +
                    "2. View All Candidates\n" +
                    "3. View Candidates by Name\n" +
                    "4. Update Existing Candidate\n" +
                    "5. Delete Existing Candidate\n" +
                    "6. Exit");

                // Get the user's input
                string userInput = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (userInput)
                {
                    case "1":
                        // Create new candidate
                        CreateNewCandidate();
                        break;
                    case "2":
                        // View all candidates
                        DisplayAllCandidates();
                        break;
                    case "3":
                        // View candidates by name
                        DisplayCandidatesByName();
                        break;
                    case "4":
                        // Update existing candidate
                        UpdateExistingCandidate();
                        break;
                    case "5":
                        // Delete existing candidate
                        DeleteExistingCandidate();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Bye. Have a great day!");
                        keepRunningApp = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number!");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create new candidate
        private void CreateNewCandidate()
        {
            Console.Clear();
            Candidate newPerson = new Candidate();

            //Name
            Console.WriteLine("Enter the Candidates name:");
            newPerson.Name = Console.ReadLine();

            //Center of interest
            Console.WriteLine("Which center are they interested in? (Enter Center Number 1-5):\n" +
                "1. Brookhaven\n" +
                "2. Columbus\n" +
                "3. Kennesaw\n" +
                "4. Marietta\n" +
                "5. Savannah");

            string centerAsString = Console.ReadLine();
            int centerAsInt = int.Parse(centerAsString);
            newPerson.CenterOfInterest = (Center)centerAsInt;

            //Experience

            //Pay Expectations
            Console.WriteLine("What's their requested hourly pay rate? (15, 16.50, etc):");
            string payAsString = Console.ReadLine();
            newPerson.PayExpectations = double.Parse(payAsString);                          //Casting- Taking an object and casting into another type

            // Interview status
            Console.WriteLine("What's their status? (1-5):\n" +
                "1. Emailed\n" +
                "2. Phone Screened\n" +
                "3. Video Interviewed\n" +
                "4. Onsite Interview\n" +
                "5. Feedback Recieved");

            string interviewAsString = Console.ReadLine();
            int interviewAsInt = int.Parse(interviewAsString);
            newPerson.InterviewStatus = (Status)interviewAsInt;

            // Offer status
            Console.WriteLine("What is their offer status? (1-3):\n" +
                "1. Offer Extended\n" +
                "2. Offer Accepted\n" +
                "3. Offer Declined");

            string offerAsString = Console.ReadLine();
            int offerAsInt = int.Parse(offerAsString);
            newPerson.OfferStatus = (Offer)offerAsInt;

            _candidateRepo.AddCandidateToList(newPerson);
        }

        // View current candidate list that is saved
        private void DisplayAllCandidates()
        {
            List<Candidate> listOfCandidates = _candidateRepo.GetCandidateList();

            foreach (Candidate person in listOfCandidates)
            {
                Console.WriteLine($"Name: {person.Name}\n" +
                    $"Status: {person.InterviewStatus}");
            }
        }

        // View existing candidates by name
        private void DisplayCandidatesByName()
        {
            Console.Clear();
            //Prompt the user to give a name
            Console.WriteLine("Enter the candidate's name you'd like to find:");

            // Get the users input
            string name = Console.ReadLine();

            //Find the candidate by name
            Candidate person = _candidateRepo.GetCandidateByName(name);

            //Display the candidate if it isn't null
            if (person != null)
            {
                Console.WriteLine($"Name: {person.Name}\n" +
                    $"Center of Interest: {person.CenterOfInterest}\n" +
                    $"Experience: {person.Experience}\n" +
                    $"Pay Expectations: {person.PayExpectations}\n" +
                    $"Status: {person.InterviewStatus}\n" +
                    $"Offer Status: {person.OfferStatus}");
            }
            else
            {
                Console.WriteLine("No Candidate by that name.");
            }
        }

        // Update existing candidate
        private void UpdateExistingCandidate()
        {
            // Display all candidates
            DisplayAllCandidates();

            // Ask for the name of candidate to update
            Console.WriteLine("Enter the name of the candidate you'd like to change:");

            // Get the candidate
            string oldPerson = Console.ReadLine();

            // Build the new candidate
            Candidate newPerson = new Candidate();

            //Name
            Console.WriteLine("Enter the Candidates name:");
            newPerson.Name = Console.ReadLine();

            //Center of interest
            Console.WriteLine("Which center are they interested in? (Enter Center Number 1-5):\n" +
                "1. Brookhaven\n" +
                "2. Columbus\n" +
                "3. Kennesaw\n" +
                "4. Marietta\n" +
                "5. Savannah");

            string centerAsString = Console.ReadLine();
            int centerAsInt = int.Parse(centerAsString);
            newPerson.CenterOfInterest = (Center)centerAsInt;

            //Experience

            //Pay Expectations
            Console.WriteLine("What's their requested hourly pay rate? (15, 16.50, etc):");
            string payAsString = Console.ReadLine();
            newPerson.PayExpectations = double.Parse(payAsString);                          //Casting- Taking an object and casting into another type

            // Interview status
            Console.WriteLine("What's their status? (1-5):\n" +
                "1. Emailed\n" +
                "2. Phone Screened\n" +
                "3. Video Interviewed\n" +
                "4. Onsite Interview\n" +
                "5. Feedback Recieved");

            string interviewAsString = Console.ReadLine();
            int interviewAsInt = int.Parse(interviewAsString);
            newPerson.InterviewStatus = (Status)interviewAsInt;

            // Offer status
            Console.WriteLine("What is their offer status? (1-3):\n" +
                "1. Offer Extended\n" +
                "2. Offer Accepted\n" +
                "3. Offer Declined");

            string offerAsString = Console.ReadLine();
            int offerAsInt = int.Parse(offerAsString);
            newPerson.OfferStatus = (Offer)offerAsInt;

            // Verify the update worked
            bool wasUpdated = _candidateRepo.UpdateExistingCandidates(oldPerson, newPerson);

            if (wasUpdated)
            {
                Console.WriteLine("Candidate was successfully changed!");
            }
            else
            {
                Console.WriteLine("Candidate couldn't be changed...");
            }
        }

        // Delete existing candidate
        private void DeleteExistingCandidate()
        {
            DisplayAllCandidates();

            // Get the candidate they'd like to remove
            Console.WriteLine("\nEnter the name of the candidate you'd like to remove:");

            // catch the input
            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _candidateRepo.RemoveCandidateFromList(input);

            // if the candidate is deleted, say so

            // Or else state it couldn't be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The candidate has been deleted.");
            }
            else
            {
                Console.WriteLine("The candidate couldn't be deleted.");
            }
        }

        //Seed Method
        private void SeedCandidateList()
        {
            Candidate seanDavis = new Candidate("Sean Davis", Center.Savannah, 2.5, 18, Status.FeebackRecieved, Offer.Declined);
            Candidate julieJones = new Candidate("Julie Jones", Center.Columbus, 1, 16.50, Status.VideoInterview, Offer.Extended);
            Candidate royWilliams = new Candidate("Roy Williams", Center.Kennesaw, 4, 20, Status.FeebackRecieved, Offer.Accepted);

            _candidateRepo.AddCandidateToList(seanDavis);
            _candidateRepo.AddCandidateToList(julieJones);
            _candidateRepo.AddCandidateToList(royWilliams);
        }
    }
}
