using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperConsole
{
    class DevProgramUI
    {
        private DeveloperRepo _devRepository = new DeveloperRepo();
        private DevTeamRepo _devTeamRepository = new DevTeamRepo();  //15 min of Create


        // Method that Starts the UI part of App
        public void RunDevApp()
        {
            FillDevList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunningApp = true;
            while (keepRunningApp)
            {
                // Show options
                Console.WriteLine("Please choose an option:\n" +
                    "1) See list of Developers \n" +
                    "2) Add Developers to Team\n" +                           
                    "3) Add Multiple Developers to Team\n" +
                    "4) Remove Developers from Team\n" +                
                    "5) Create a new Team\n" +
                    "6) Exit");

                // Get user input
                string input = Console.ReadLine();

                // Evaluate user input and act
                switch (input)
                {
                    case "1":
                        //See list
                        SeeListOfDevelopers();
                        break;
                    case "2":
                        // List then Add dev's to team by ID#
                        AddDevelopersToTeam();
                        break;
                    case "3":
                        // Add multiple
                        AddMultipleDevlopers();
                        break;
                    case "4":
                        // List then remove dev's by ID#
                        RemoveDevelopersFromTeam();
                        break;
                    case "5":
                        // Create new team
                        CreateNewTeam();
                        break;
                    case "6":
                        // Pluralsight access
                        PluralsightLicenseReport();
                        break;
                    case "7":
                        // Exit
                        Console.WriteLine("Thank you for using the KomodoApp!");
                        keepRunningApp = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a correct number!");
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SeeListOfDevelopers()
        {
            Console.Clear();
            List<Developer> fullListOfDevs = _devRepository.GetListOfDevelopers();

            foreach (Developer developer in fullListOfDevs)
            {
                Console.WriteLine($"Name: {developer.Name}\n" +
                    $"ID Number: {developer.IdNumber}\n" +
                    //$"PluralSight Access: {developer.PluralSightLicense}\n" +           //May not be needed.
                    $"Team: {developer.NameOfTeam}");
                Console.WriteLine();
            }
        }

        private void AddDevelopersToTeam()       
        {
            CreateNewDvp();
            Console.WriteLine();
            Console.WriteLine("Would you like to add another Developer? (Y or N).");
            string addAnotherDevPer = Console.ReadLine().ToLower();

            if (addAnotherDevPer == "y")
            {
                CreateNewDvp();
            }
            else
            {
                Console.WriteLine("Press any button to return to menu");
                Menu();
            }

        }

        private void AddMultipleDevlopers()
        {
            Developer newDvp2 = new Developer();
            //CreateNewDvp();

            //Name
            Console.WriteLine("Please enter their first and last names:");
            newDvp2.Name = Console.ReadLine();

            //ID#
            Console.WriteLine("What's their ID Number?");
            string idTwoAsString = Console.ReadLine();
            newDvp2.IdNumber = int.Parse(idTwoAsString);

            //PS access
            Console.WriteLine("Do they have Plural Sight Access? (Y or N)");
            string psTwoAccessAsString = Console.ReadLine().ToLower();

            if (psTwoAccessAsString == "y")
            {
                newDvp2.PluralSightLicense = true;
            }
            else
            {
                newDvp2.PluralSightLicense = false;
            }

            //Team
            Console.WriteLine("Which team are they on?\n" +
                "1) Wizards\n" +
                "2) Warlocks\n" +
                "3) Dragons\n" +
                "4) Witches\n" +
                "5) Warriors\n" +
                "6) Sorcerers\n" +
                "7) Legends");

            string teamTwoAsString = Console.ReadLine();
            int teamTwoasInt = int.Parse(teamTwoAsString);
            newDvp2.NameOfTeam = (TeamName)teamTwoasInt;

            _devRepository.AddDevToList(newDvp2);

        }
        private void RemoveDevelopersFromTeam()
        {

            SeeListOfDevelopers();

            Console.WriteLine("Please enter the ID Number of the Developer you'd like to remove");

            string userIDAsString = Console.ReadLine();
            int userIDAsAnInt = int.Parse(userIDAsString);

            bool deveDeleted = _devRepository.DeleteDevFromDirectory(userIDAsAnInt);

            if (deveDeleted)
            {
                Console.WriteLine("The Developer was removed!");
            }
            else
            {
                Console.WriteLine("Developer was NOT removed.");
            }

        }

        private void CreateNewDvp()
        {
            Console.Clear();
            Developer newDvp = new Developer();

            //Name
            Console.WriteLine("Please enter the Developers first and last names:");
            newDvp.Name = Console.ReadLine();

            //ID#
            Console.WriteLine("What's their ID Number?");
            string idAsString = Console.ReadLine();
            newDvp.IdNumber = int.Parse(idAsString);

            //PS access
            Console.WriteLine("Do they have Plural Sight Access? (Y or N)");
            string psAccessAsString = Console.ReadLine().ToLower();

            if (psAccessAsString == "y")
            {
                newDvp.PluralSightLicense = false;
            }
            else
            {
                newDvp.PluralSightLicense = true;
            }

            //Team
            Console.WriteLine("Which team are they on?\n" +
                "1) Wizards\n" +
                "2) Warlocks\n" +
                "3) Dragons\n" +
                "4) Witches\n" +
                "5) Warriors\n" +
                "6) Sorcerers\n" +
                "7) Legends");

            string teamAsString = Console.ReadLine();
            int teamasInt = int.Parse(teamAsString);
            newDvp.NameOfTeam = (TeamName)teamasInt;

            _devRepository.AddDevToList(newDvp);

            Console.WriteLine();
            Console.WriteLine("Would you like to add another Developer? (Y or N).");
            string addAnotherDevPer = Console.ReadLine().ToLower();

            if (addAnotherDevPer == "y")
            {
                //Console.Clear();
                CreateNewDvp();
                //AddMultipleDevlopers();
            }
            else
            {
                Console.WriteLine("Press any button to return to menu");
                Console.Clear();
                Menu();
            }
        }

        private void CreateNewTeam()                        // 10 min of create
        {
            //Who would you like on team?   Switch w/ names
            Console.Clear();
            DevTeam newDevTeam = new DevTeam();

            Console.WriteLine("Which team would you like to add the developer to?\n" +
                "1) Wizards\n" +
                "2) Warlocks\n" +
                "3) Dragons\n" +
                "4) Witches\n" +
                "5) Warriors\n" +
                "6) Sorcerers\n" +
                "7) Legends");

            string newTeamNameAsString = Console.ReadLine();
            int newTeamAsInt = int.Parse(newTeamNameAsString);
            newDevTeam.Team = (TeamName)newTeamAsInt;

            // Dev name
            SeeListOfDevelopers();
            Console.WriteLine();
            Console.WriteLine("Please choose new team member:");
            string newDevTeamMemAsString = Console.ReadLine();
            

            _devTeamRepository.AddDevToTeam(newDevTeam);

        }
        private void PluralsightLicenseReport()           
        {
            /*Console.Clear();

            Console.WriteLine("Press any key to see list of Developers who need Plural Sight Access.");
            string runIt = Console.ReadLine();

            Developer psNeeded = _devRepository.GetDevelopersPluralSight(false);

            while (psNeeded != null)
            {
                Console.WriteLine($"Name: {psNeeded.Name}\n" +
                $"ID Number: {psNeeded.IdNumber}\n" +
                $"Team: {psNeeded.NameOfTeam}");
                Console.WriteLine();
                if (psNeeded.Count == null)
                {
                    Console.WriteLine("Done!");
                }
            }

            foreach (Developer devElement in psNeeded) ;
            {
                Console.WriteLine($"Name: {devElement.Name}\n" +
                $"ID Number: {devElement.IdNumber}\n" +
                $"Team: {devElement.NameOfTeam}");
                Console.WriteLine();
            }
            Console.WriteLine("Everyone has PluralSight Access!"); */


            /*if (psNeeded != null)
            {
                Console.WriteLine($"Name: {psNeeded.Name}\n" +
                $"ID Number: {psNeeded.IdNumber}\n" +
                $"Team: {psNeeded.NameOfTeam}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Everyone has PluralSight Access!");
            }*/
        }
        private void FillDevList()  
        { 
            Developer richJones = new Developer("Richard Jones", 100, true, TeamName.Wizards);
            Developer susiLambe = new Developer("Susie Lamber", 200, false, TeamName.Dragons);
            Developer derDavis = new Developer("Dervon Davis", 300, true, TeamName.Warlocks);
            Developer briaIwun = new Developer("Briana Iwunze", 400, false, TeamName.Warlocks);
            Developer westJohn = new Developer("Weston Johnson", 500, true, TeamName.Wizards);
            Developer angeBelm = new Developer("Angela Belman", 600, false, TeamName.Dragons);
            Developer charBall = new Developer("Charles Ballard", 700, true, TeamName.Warlocks);
            Developer xaviWeat = new Developer("Xavier Wetherford", 800, false, TeamName.Warlocks);
            Developer doroDavi = new Developer("Dorothy Davie", 800, true, TeamName.Legends);


            _devRepository.AddDevToList(richJones);
            _devRepository.AddDevToList(susiLambe);
            _devRepository.AddDevToList(derDavis);
            _devRepository.AddDevToList(briaIwun);
            _devRepository.AddDevToList(westJohn);
            _devRepository.AddDevToList(angeBelm);
            _devRepository.AddDevToList(charBall);
            _devRepository.AddDevToList(xaviWeat);
            _devRepository.AddDevToList(doroDavi);
        }

    }
}
