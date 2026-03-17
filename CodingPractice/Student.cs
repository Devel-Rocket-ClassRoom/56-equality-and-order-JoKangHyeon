using System;

class Student:IComparable<Student>
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Score { get; set; }

    public Student(string name, int grade, int score)
    {
        Name = name;
        Grade = grade;
        Score = score;
    }

    public int CompareTo(Student other)
    {
        if (Grade == other.Grade)
        {
            if (Score == other.Score)
            {
                return Name.CompareTo(other.Name);
            }
            else
            {
                return other.Score.CompareTo(Score);
            }
        }
        else
        {
            return Grade.CompareTo(other.Grade);
        }
    }
}
