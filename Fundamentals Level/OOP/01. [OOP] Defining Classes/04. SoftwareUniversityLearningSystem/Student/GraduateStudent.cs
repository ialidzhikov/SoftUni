using System;

namespace SoftwareUniversityLearningSystem.Student
{
    public class GraduateStudent : Student
    {
        #region Constructors

        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            
        }

        #endregion
    }
}
