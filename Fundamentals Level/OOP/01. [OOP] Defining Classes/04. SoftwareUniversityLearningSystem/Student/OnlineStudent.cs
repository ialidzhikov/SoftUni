using System;

namespace SoftwareUniversityLearningSystem.Student
{
    public class OnlineStudent : CurrentStudent
    {
        #region Constructors

        public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double averageGrades, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrades, currentCourse)
        {
            
        }

        #endregion
    }
}
