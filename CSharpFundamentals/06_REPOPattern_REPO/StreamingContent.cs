using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_REPOPattern_REPO
{
    public enum GenreType                                           //Type
    { 
        Horror = 1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }

    //Plain Old C# Object -- POCO: Holds data
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }                  //Instance of the type

        public StreamingContent() { }
                                                                    //ctor to clone StreamingContent
        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {                                                           //assigning properties to parameters
            Title = title;                                          //Can only go into this method
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
        }
    } 
}
