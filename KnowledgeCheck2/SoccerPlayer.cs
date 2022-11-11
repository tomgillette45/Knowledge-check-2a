using System;
namespace KnowledgeCheck2
{
    public class SoccerPlayer
    {

        public string name { get; set; }
        public string foot { get; set; }
        public string position { get; set; }

        public override string ToString()
        { return $"name: {this.name}\n foot: { this.foot}\n position: { this.position}";
        }

    }
}




