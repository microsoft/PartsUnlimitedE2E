using System;

namespace PartsUnlimited.Models
{

    public class CommunityPost
    {
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public CommunitySource Source { get; set; }
    }
//Changes 3rd on 17/12/2020
    public enum CommunitySource
    {
        Facebook,
        Twitter
    }
}