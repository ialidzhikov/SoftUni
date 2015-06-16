using System;
using Interfaces;

namespace Projects
{
    public enum State
    {
        Open, Closed
    }
    public class Project : IProject
    {
        #region Fields

        private string projectName;
        private DateTime startDate;
        private string details;
        private State state;

        #endregion

        #region Constructors

        public Project(string projectName, DateTime startDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        #endregion

        #region Properties

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The project name cannot be null, empty or whitespace.");
                }
                else
                {
                    this.projectName = value;
                }
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.details = "(no data)";
                }
                else
                {
                    this.details = value;
                }
            }
        }

        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        #endregion

        #region Methods

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10:dd/MM/yyyy} {2,-10} {3,-6}",
                this.ProjectName, this.StartDate, this.Details, this.State);
        }

        #endregion
    }
}
