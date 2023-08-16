var comment1 = new Comment("Have a nice trip!");
var comment2 = new Comment("How that's awesome!");
var post1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
);

post1.AddComments(comment1);
post1.AddComments(comment2);

var comment3 = new Comment("Good night");
var comment4 = new Comment("May the force be with you");
var post2 = new Post(
    DateTime.Parse("28/07/2018 23:14:19"),
    "Good night guys",
    "See you tomorrow",
    5
);

post2.AddComments(comment3);
post2.AddComments(comment4);

Console.WriteLine(post1);
Console.WriteLine("\n" + post2);

Console.ReadKey();
