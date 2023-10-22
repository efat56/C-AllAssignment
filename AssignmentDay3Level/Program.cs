
class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }


    public Student(int StudentId, string name, int age, string course)
    {
       StudentID = StudentId;
       Name  = name;
       Age = age;
       Course = course;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1, "name1", 20, "course1");
        Student s2 = new Student(2, "name2", 21, "course2");
        Student s3 = new Student(3, "name3", 22, "course3");
        Student s4 = new Student(4, "name4", 23, "course4");
        Student s5 = new Student(5, "name5", 24, "course5");
        Student s6 = new Student(6, "name6", 25, "course1");

        List<Student> list = new List<Student>();
        list.Add(s1);
        list.Add(s2);
        list.Add(s3);
        list.Add(s4);
        list.Add(s5);
        list.Add(s6);


        // Filter the student who's age is grether than 23....
         var oldStudent =  list.Where(s => s.Age > 23);

        foreach(Student student in oldStudent)
        {
            Console.WriteLine($"name is {student.Name} And Age is {student.Age}");
        }

        // Order the Student by name...
          var orderName =  list.OrderBy(s => s.Name);

        foreach (Student student in orderName)
        {
            Console.WriteLine($"name is {student.Name}");
        }

        // Group Student by course....
          var groupStudent = list.GroupBy(s => s.Course);

        foreach (var group in groupStudent)
        {
            Console.WriteLine($"Course: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"- {student.Name} (Age: {student.Age})");
            }
        }


    }
}
