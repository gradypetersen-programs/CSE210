using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video videoOne = new Video("Geometry for Not-So-Geniuses", "MathTutor24", 500);
        Video videoTwo = new Video("New Footloose Dance Tutorial", "Tiger Stripes Studios", 350);
        Video videoThree = new Video("Oranges Can Cure Your Picky Eater", "Oranges All The Way", 900);
        
        videoOne.StoreComment(new Comment("Billiam Henry", "I still don't like it. I understand it now, but I don't like it."));
        videoOne.StoreComment(new Comment("math_lover", "Wow! I am hypotenuse over legs for your explanation!"));
        videoOne.StoreComment(new Comment("Peter Kelly", "If I watch this another 50 times, I might just pass my exam in an hour. Wish me luck!"));
        videos.Add(videoOne);

        videoTwo.StoreComment(new Comment("GeneDances", "This is totally a throwback and a new vibe at the same time."));
        videoTwo.StoreComment(new Comment("Papaya Dance Studio", "Great Tutorial! Showed it to my youngest group at the studio to demonstrate one of the moves you do! You really brought it back to the basics!"));
        videoTwo.StoreComment(new Comment("John Paz", "I tied my right arm into a dancing pretzel doing this and now I am on the way to the doctor."));
        videos.Add(videoTwo);

        videoThree.StoreComment(new Comment("OrangeLover<3", "I had no idea! Adding this to my daily orange playlist right now!"));
        videoThree.StoreComment(new Comment("Awesome Dad", "My 3 year old won't stop begging for oranges now. I can't believe he's not asking for iced cream. Mission accomplished."));
        videoThree.StoreComment(new Comment("NewGrover23", "I have been missing out on oranges for soooo long!! I can't believe all the things you made with these!"));
        videos.Add(videoThree);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}