namespace StudentRestApi
{
    public class AddStudentDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string email { get; set; }
        /* public Gender Gender { get; set; }*/

        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
