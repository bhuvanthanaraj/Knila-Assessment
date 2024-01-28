using System.ComponentModel.DataAnnotations;

namespace Knila_Assessment.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public  string Publisher { get; set; }
        public  string Title { get; set; }
        public  string AuthorFirstName { get; set; }
        public  string AuthorLastName { get; set; }
        public  decimal Price  { get; set; }



        public string MlaCitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. \"{Title}\". {Publisher}, {Price}, {Id.ToString().Substring(0, 9)}.";
            }
        }



        public string ChicagoCitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. \"{Title}\". {Publisher}, {Price}, {Id.ToString().Substring(0, 9)}.";
            }
        }





    }
}
