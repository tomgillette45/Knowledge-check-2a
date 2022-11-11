using KnowledgeCheck2;
{
    Console.WriteLine("How many records do you want to add? ");
    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new List<High_School_Soccer_Player>();
    for (int i = 0; i < numberOfRecords; i++)
    {
        // In this loop, populate the object's properties using Console.ReadLine()

        Console.WriteLine("Enter a HS Soccer Player Name");
        var hssoccerplayer = new High_School_Soccer_Player();

        hssoccerplayer.name = Console.ReadLine();

        Console.WriteLine("Left footed or Right footed?");
        hssoccerplayer.foot = Console.ReadLine();

        Console.WriteLine("What position do they play?");
        hssoccerplayer.position = Console.ReadLine();

        Console.WriteLine("What school do they attend?");
        hssoccerplayer.HighSchool = Console.ReadLine();

        recordList.Add(hssoccerplayer);
    }

    // Print out the list of records using Console.WriteLine()

foreach(var hssoccerplayer in recordList)
{

Console.WriteLine($"{hssoccerplayer}");

}
}