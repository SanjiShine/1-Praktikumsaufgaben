namespace Klassen09;

class Hochschule
{
    static void Main()
    {
        
        Student s1 = new Student("San");
        Student s2 = new Student("Sanji", 1990);
        Student s3 = new Student("San Shine", 1999, 10101);
        Student s4 = new Student("John Doe", "Informatik", 1981, 2534);

        Student[] students = { s1, s2, s3, s4 };

        foreach (Student student in students)
        {
            student.Studieren();
            student.Schlafen();
            student.Studieren();
            student.Essen();
        }

        Console.WriteLine(Student.GetAnzahl());

        Console.WriteLine(s4.IsValid());

        Console.WriteLine(s4);
    }
}

