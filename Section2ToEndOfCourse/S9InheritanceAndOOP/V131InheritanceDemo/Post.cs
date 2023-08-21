using System;
namespace S9InheritanceAndOOP.V131InheritanceDemo
{
    public class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        // Default constructor
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Scott Minter";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        // override of system.object.tostring method
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - by {SendByUsername}");
        }
    }
}

