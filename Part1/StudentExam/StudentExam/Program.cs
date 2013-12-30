using System;

public class Subject
{
    public string Name { get; set; }
    public int TotalMarks { get; set; }

    public override bool Equals(object obj)
    {
        Subject other = obj as Subject;
        return Name.Equals(other.Name) && TotalMarks == other.TotalMarks;
    }
}
public class Standard
{
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        Standard other = obj as Standard;
        return other.Name.Equals(Name);
    }
}

public class Exam
{
    public Subject Subject { get; set; }
    public Standard Standard { get; set; }
    public DateTime ExamDate { get; set; }

    public override bool Equals(object obj)
    {
        Exam other = obj as Exam;
        return other.Subject.Equals(Subject)
            && other.Standard.Equals(Standard)
            && ExamDate == ExamDate;
    }

    public Exam()
    {
        Subject = new Subject();
        Standard = new Standard();
    }
}

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        Student other = obj as Student;

        return other.Roll == Roll && other.Name.Equals(Name);
    }
}

public class StudentExam
{
    public Student Student { get; set; }
    public Exam Exam { get; set; }
    public int ObtainMarks { get; set; }

    public StudentExam()
    {
        Student = new Student();
        Exam = new Exam();
    }


    public override bool Equals(object obj)
    {
        StudentExam other = obj as StudentExam;

        return other.Exam.Equals(Exam)
             && other.Student.Equals(Student)
               && other.ObtainMarks == ObtainMarks;

       /* if (other.Exam.ExamDate != Exam.ExamDate)
            return false;
        if (other.Exam.Standard.Name != Exam.Standard.Name)
            return false;
        if (other.Exam.Subject.Name != Exam.Subject.Name)
            return false;
        if (other.Exam.Subject.TotalMarks != Exam.Subject.TotalMarks)
            return false;
        if (other.ObtainMarks != ObtainMarks)
            return false;
        if (other.Student.Name != Student.Name)
            return false;
        if (other.Student.Roll != Student.Roll)
            return false;
        return true;*/

    }
}

class Test
{

    
    static void Main()
    {
        StudentExam e = new StudentExam();
        e.Exam.ExamDate = DateTime.Parse("12/31/2013");
        e.Exam.Standard.Name = "1st";
        e.Exam.Subject.Name = "English";
        e.Exam.Subject.TotalMarks = 100;
        e.Student.Roll = 10;
        e.Student.Name = "Abc";

        StudentExam t = new StudentExam();
        t.Exam.ExamDate = DateTime.Parse("12/31/2013");
        t.Exam.Standard.Name = "1st";
        t.Exam.Subject.Name = "English";
        t.Exam.Subject.TotalMarks = 100;
        t.Student.Roll = 10;
        t.Student.Name = "Abc";

        Console.WriteLine(e.Equals(t));


    }
}