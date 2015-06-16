using System;

namespace HumanStudentAndWorker.Human
{
    public class Worker : Human
    {
        #region Fields

        private double weekSalary;
        private double workHoursPerDay;

        #endregion

        #region Constructors

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerday) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerday;
        }

        #endregion

        #region Properties

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary should be positive.");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day should be positive.");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        #endregion

        #region

        public override string ToString()
        {
            return string.Format("{0} {1,-6:F2} {2,-6:F2}", base.ToString(), this.WeekSalary, this.WorkHoursPerDay);
        }

        #endregion
    }
}
