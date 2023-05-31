using System.ComponentModel.DataAnnotations;

namespace StudentsRanks.Models
{
    public class TopStudent
    {
        [Key]
        public int StudentId { get; set; }

        public int Rank { get; set; }
        public string StudentName { get; set; }
        public int MathsMarks { get; set; }
        public int EnglishMarks { get; set; }
        public int PhysicsMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int SocialMarks { get; set; }
        public int TotalMarks { get; set; }
    }
}
