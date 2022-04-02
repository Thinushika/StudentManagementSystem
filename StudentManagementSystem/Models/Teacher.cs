namespace StudentManagementSystem.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string ContactNumber { get; set; }
        public string TeacherEmail { get; set; }
        public string EnrolmentDate { get; set; }
        public Subjects SubjectsId { get; set; }
    }
}
