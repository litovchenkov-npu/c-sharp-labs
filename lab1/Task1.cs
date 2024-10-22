using System;
using System.Collections.Generic;

public class Grade
{
    public string Subject { get; set; }
    public double Score { get; set; }

    public Grade(string subject, double score)
    {
        Subject = subject;
        Score = score;
    }

    public void DisplayGrade()
    {
        Console.WriteLine($"Subject: {Subject}, Score: {Score}");
    }
}

public class Student
{
    public string Name { get; set; }
    public List<Grade> Grades { get; set; }

    public Student(string name)
    {
        Name = name;
        Grades = new List<Grade>();
    }

    public void AddGrade(Grade grade)
    {
        Grades.Add(grade);
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Grades:");
        foreach (var grade in Grades)
        {
            grade.DisplayGrade();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("John Doe");

        student.AddGrade(new Grade("Maths", 95));
        student.AddGrade(new Grade("Physics", 88));

        student.DisplayStudentInfo();
    }
}