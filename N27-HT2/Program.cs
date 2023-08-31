
using N27_HT2.Enums;
using N27_HT2.Models;

var videoPosts = new List<VideoPost>
{
    new VideoPost("Funny Cat Compilation", "Watch these hilarious cats in action!", 25_000, 500, Topics.Fun),
    new VideoPost("Advanced Web Development Techniques", "Learn the latest web development tricks.", 10_000, 300, Topics.IT),
    new VideoPost("Epic Gaming Moments", "Witness incredible gaming highlights.", 50_000, 1_000, Topics.Gaming),
    new VideoPost("Entrepreneurial Success Stories", "Discover the secrets behind successful businesses.", 8_000, 200, Topics.Business),
    new VideoPost("How to Tell Jokes Like a Pro", "Master the art of delivering jokes.", 15_000, 1_500, Topics.Fun),
    new VideoPost("Cybersecurity Essentials", "Protect your online presence with these tips.", 12_000, 400, Topics.IT),
    new VideoPost("Speedrun: The Legend of Zara", "Watch the fastest playthrough of this classic game.", 30_000, 800, Topics.Gaming),
    new VideoPost("Investing in Stocks 101", "Learn the basics of stock market investment.", 7_000, 300, Topics.Business),
    new VideoPost("Stand-up Comedy Showcase", "Laugh out loud with these hilarious comedians.", 18_000, 2_000, Topics.Fun),
    new VideoPost("Creating User-Friendly UI/UX", "Design interfaces that users will love.", 14_000, 500, Topics.IT)
};

Console.WriteLine("Max Likes:");
var maxLike = videoPosts.MaxBy(item => item.Likes);
Console.WriteLine($"{maxLike.Id} - {maxLike.Title} - " +
    $"{maxLike.Description} - {maxLike.Likes} - {maxLike.Dislikes} - {maxLike.Topic}");

Console.WriteLine("Min dislike:");
var minDislike = videoPosts.MinBy(item => item.Dislikes);
Console.WriteLine($"{minDislike.Id} - {minDislike.Title} - " +
    $"{minDislike.Description} - {minDislike.Likes} - {minDislike.Dislikes} - {minDislike.Topic}");

Console.WriteLine("Avarage likes:");
var avarageLike  = videoPosts.Average(item => item.Likes);
Console.WriteLine(avarageLike);

Console.WriteLine("All viedo's dislike:");
var allDislike = videoPosts.Sum(item => item.Dislikes);
Console.WriteLine(allDislike);

Console.WriteLine("Selet title:");
var selevtTitle = videoPosts.Select(item => item.Title);
Console.WriteLine(selevtTitle.ToString());

Console.WriteLine("Selet description:");
var selectDescription = videoPosts.Select(item => item.Description);
Console.WriteLine(selectDescription.ToString());

Console.WriteLine("Distint Topic:");
var topicDistint = videoPosts.Select(item => item.Topic).Distinct().ToList();
Console.WriteLine(topicDistint.ToString());

Console.WriteLine("Group Topic:");
var groupTopics = videoPosts.GroupBy(item => item.Topic).ToList();

