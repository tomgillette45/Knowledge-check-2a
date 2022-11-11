using System;
namespace KnowledgeCheck2
{
    public class High_School_Soccer_Player : SoccerPlayer
    {
        public string HighSchool { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\n HS: {this.HighSchool}";
        }

    }
}

