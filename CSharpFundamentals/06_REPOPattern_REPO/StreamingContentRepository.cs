using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_REPOPattern_REPO
{
    public class StreamingContentRepository
    {                                   //Database
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();  //Field=Var in class for anywhere

        //Create
        public void AddContentToList(StreamingContent content)  
        {
            _listOfContent.Add(content);                        //Anything w/ _ is a field
        }                                                       //_listOfContent=field & ListOfContent=property

        //Read
        public List<StreamingContent> GetContentList()          //When returning, we don't need to pass variables.
        {
            return _listOfContent;
        }

        //Update - bool to return true or false
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if (oldContent != null)
            {                                                        //Assigning new properties in place of the old ones.
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if (content == null)                                //Checking if content, or title, is there.
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method or Read method
        public StreamingContent GetContentByTitle(string title) 
        { 
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;                    //this is our "else" statement
        }    

    }
}
