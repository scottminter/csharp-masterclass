using System;
namespace S9InheritanceAndOOP.V131InheritanceDemo
{
    public class V131IneritanceDemo
    {
        public static void Lesson()
        {
            //var post1 = new Post("Thanks for visit!!!", true, "Scott Minter");
            //Console.WriteLine(post1.ToString());

            //var imagePost1 = new ImagePost(
            //    "Check out my new shoes!",
            //    "Scott Minter",
            //    "https://www.somehwere.com/my_new_shoes.jpg",
            //    true
            //    );
            //Console.WriteLine(imagePost1.ToString());

            var videoPost1 = new VideoPost(
                "This is a new awesome video",
                "Scott Minter",
                "https://www.allthevideos.com/my_new_video.mpeg",
                35,
                true
                );

            videoPost1.Play();

            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();

            Console.WriteLine(videoPost1.ToString());
        }
    }
}

