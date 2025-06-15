namespace FanGuideApp
{
    using System; // �������� using System; - ���� ������� ��� DateTime

    public class Athlete
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Origin { get; set; }
        public string SportType { get; set; }
        public string TeamOrClub { get; set; }
        public string PersonalRecord { get; set; } // <--- ��������� �� string
        public bool IsFavorite { get; set; }
    }
}