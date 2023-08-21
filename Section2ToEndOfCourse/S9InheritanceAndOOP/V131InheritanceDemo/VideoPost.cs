using System;
namespace S9InheritanceAndOOP.V131InheritanceDemo
{
    public class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // properties
        public string VideoUrl { get; set; }
        public int Length { get; set; }


        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoUrl, int length, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;

            VideoUrl = videoUrl;
            Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {VideoUrl} - {Length} - by {SendByUsername}");
        }
    }
}

