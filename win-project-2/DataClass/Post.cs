using System.Net.Http.Headers;

namespace win_project_2
{
    public class Post
    {
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Request { get; set; }
        public double Price { get; set; }
        public string SenderId { get; set; }

        public Post() { }
        public Post(string tag, string description, string location, string date, string request, double price, string senderid)
        {
            Tag = tag;
            Description = description;
            Location = location;
            Date = date;
            Request = request;
            Price = price;
            SenderId = senderid;
        }
    }
}