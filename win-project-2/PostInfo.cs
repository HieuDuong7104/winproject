namespace win_project_2
{
    internal class PostInfo
    {
        public string Content { get; set; }
        public string SenderId { get; set; }
        public string ImageUrl { get; set; }
        public string Tag { get; set; }

        public PostInfo() { }
        public PostInfo(string content, string senderId, string imageUrl, string tag)
        {
            Content = content;
            SenderId = senderId;
            ImageUrl = imageUrl;
            Tag = tag;
        }
    }
}