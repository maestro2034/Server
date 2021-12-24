namespace Server
{
    public static class StudentDB
    {
        private static List<Student> students;

        public static void Fill()
        {
            students = new List<Student>();
            students.Add(new Student
            {
                Name = "Maga",
                Id = 1,
                Age = 22
            });
            students.Add(new Student
            {
                Name = "Tariel",
                Id = 2,
                Age = 22
            });
            students.Add(new Student
            {
                Name = "Anar",
                Id = 3,
                Age = 18
            });
            students.Add(new Student
            {
                Name = "Jaweed",
                Id = 4,
                Age = 20
            });
        }

        public static List<Student> GetStudents()
        {
            return students;
        } 

        public static Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }
        public static void CreateStudent(Student student)
        {
            students.Add(student);
        }
        public static void Remove(Student student)
        {
            students.Remove(student);
        }
    }
}
