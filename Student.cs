namespace USFLibraryManagementSystem
{
    public class Student : Person
    {
        public string Major;
        public int GraduationYear;

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }



        public override string ToString()
        {
            return $"Student: {Name}, ID: {ID}, Major: {Major}, Grad Year: {GraduationYear}";
        }


        public override string ToPatronString()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}