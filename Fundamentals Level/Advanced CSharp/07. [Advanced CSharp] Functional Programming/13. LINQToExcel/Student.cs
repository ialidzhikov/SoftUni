using System;

class Student
{

    #region Constructors

    public Student(int id, string firstName, string lastName, string email, string gender,
        string studentType, int examResult, int homeworkSent, int homeworkEvaluated,
        double teamworkScore, int attendancesCount, double bonus)
    {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Gender = gender;
        this.StudentType = studentType;
        this.ExamResult = examResult;
        this.HomeworkSent = homeworkSent;
        this.HomeworkEvaluated = homeworkEvaluated;
        this.TeamworkScore = teamworkScore;
        this.AttendancesCount = attendancesCount;
        this.Bonus = bonus;
        this.Result = Math.Round((examResult + homeworkSent + homeworkEvaluated + teamworkScore + attendancesCount + bonus) / 5.00, 2);
    }


    #endregion

    #region Properties

    public int ID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Gender { get; set; }

    public string StudentType { get; set; }

    public int ExamResult { get; set; }

    public int HomeworkSent { get; set; }

    public int HomeworkEvaluated { get; set; }

    public double TeamworkScore { get; set; }

    public int AttendancesCount { get; set; }

    public double Bonus { get; set; }

    public double Result { get; set; }

    #endregion

}

