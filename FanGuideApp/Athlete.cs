namespace FanGuideApp
{
    using System;

    public class Athlete
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Origin { get; set; }
        public string SportType { get; set; }
        public string TeamOrClub { get; set; }
        public double PersonalRecord { get; set; } // «м≥нено на double
        public bool IsFavorite { get; set; }
    }
}