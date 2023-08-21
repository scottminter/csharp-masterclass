using System;
namespace S9InheritanceAndOOP.V131InheritanceDemo
{
    public class ImagePost : Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            // inherited
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;

            // belongs to ImagePost
            ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {ImageUrl} - by {SendByUsername}");
        }
    }
}

