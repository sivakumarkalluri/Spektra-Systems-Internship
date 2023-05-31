namespace Assignment2.Models
{
    public class Marks
    {
     
        public int Studentid { get; set; }
        public int MathsMarks { get; set; }
        public int EnglishMarks { get; set;}
        public int PhysicsMarks { get; set;}

        public int ScienceMarks { get; set; }
        public int SocialMarks { get; set;}

        public StudentDetails StudentDetails { get; set; }

    }
}
