namespace FanGuideApp
{
    using System; // Залишаємо using System; - воно потрібне для DateTime

    public class Athlete
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Origin { get; set; }
        public string SportType { get; set; }
        public string TeamOrClub { get; set; }
        public string PersonalRecord { get; set; } // <--- Повернуто на string
        public bool IsFavorite { get; set; }
    }
}