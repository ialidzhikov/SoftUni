using System;
using System.Collections.Generic;

namespace StudentSpecialty
{
    public class StudentSpecialty
    {
        public static List<StudentSpecialty> StudentSpecialties = new List<StudentSpecialty>()
        {
            new StudentSpecialty("Web Developer", 44011),
            new StudentSpecialty("Web Developer", 440016),
            new StudentSpecialty("PHP Developer", 440014),
            new StudentSpecialty(".NET Developer", 440018),
            new StudentSpecialty("QA Engineer", 44011),
            new StudentSpecialty("Web Developer", 440012),
        };

        #region Constructors

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        #endregion

        #region Properties

        public string SpecialtyName { get; set; }

        public int FacultyNumber { get; set; }

        #endregion

    }
}
