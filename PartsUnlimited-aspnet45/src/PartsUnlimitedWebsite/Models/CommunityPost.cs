using System;

namespace PartsUnlimited.Models
{

    public class CommunityPost
    {
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public CommunitySource Source { get; set; }
        // Este cambko va por mi parte hasta github
        // y un ultimo cambio a communityPost
    }

    public enum CommunitySource
    {
        Facebook,
        Twitter
    }
}