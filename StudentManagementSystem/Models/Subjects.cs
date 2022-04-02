namespace StudentManagementSystem.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }
        public string SubjectName { get; set; }
        public Classes ClassId { get; set; }
        public Teacher TeacherId { get; set; }
    }
}
