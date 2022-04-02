namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public string StudentDOB { get; set; }
        public int Age { get; set; }
        public string EnrolmentDate { get; set; }
        public Classes ClassID { get; set; }

    }
}
