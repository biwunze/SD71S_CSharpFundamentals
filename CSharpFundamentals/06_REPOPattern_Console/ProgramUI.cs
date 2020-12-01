using _06_REPOPattern_REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_REPOPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();


        // Method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +                       // \n= new line
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get the user's input
                string input = Console.ReadLine();


                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View All Content
                        DisplayAllConent();
                        break;
                    case "3":
                        //View Content by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please ENTER a vaild number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }                                                                               //ctrl, k, d= Align
        }

        //Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc)");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star count for the content (5.8, 10, 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            // allowing the user to input data about which genre they want, stores it in a string call genreAsAString
            string genreAsString = Console.ReadLine();                                  
            // Console.Readline() returns a string, but we need an int, so we are Parsing our string to an integer
            int genreAsInt = int.Parse(genreAsString);
            // that integer is caseted into selecting the index of our enum GenreType
            newContent.TypeOfGenre = (GenreType)genreAsInt;
            // call our Add method in our REPO to add our new content to our directory
            _contentRepo.AddContentToList(newContent);
        }

        //View current StreamingContent that is saved
        private void DisplayAllConent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}");
            }
        }

        //View existing Content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            // Prompt the user to give me a title
            Console.WriteLine("Enter the title of the content you'd like to see:");

            //Get the user's input
            string title = Console.ReadLine();

            // Find the contetn by that title
           StreamingContent content = _contentRepo.GetContentByTitle(title);

            // Display said content if it isn't null
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }
        }

        //Update Existing Content
        private void UpdateExistingContent()
        {
            // Display all content
            DisplayAllConent();

            // Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you'd like to update:");

            // Get the title
            string oldTitle = Console.ReadLine();

            // We will build a new object
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc)");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star count for the content (5.8, 10, 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            // Verify the update worked
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updates!");
            }
            else
            {
                Console.WriteLine("Could not update content.");
            }
        }

        //Delete Existing Content
        private void DeleteExistingContent()
        {
            DisplayAllConent();

            // Get the title they want to remove
            Console.WriteLine("\nEnter the title of the content you'd like to remove:");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            // If the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }

            // Otherwise state it could not be deleted

        }

        //See Method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down.", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree.", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);
        }
    }
}
