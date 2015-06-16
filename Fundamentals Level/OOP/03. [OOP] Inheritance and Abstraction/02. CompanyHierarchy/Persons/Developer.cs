using System;
using System.Collections.Generic;
using Interfaces;
using Projects;

namespace Persons
{
    public class Developer : RegularEmployee, IDeveloper
    {
        #region Fields

        private List<Project> projects;

        #endregion

        #region Constructors

        public Developer(string firstName, string lastName, string id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = new List<Project>();
        }

        #endregion

        #region Properties

        public List<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        #endregion

        #region Methods

        public void AddProject(Project project)
        {
            this.Projects.Add(project);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}Projects: {2}", base.ToString(), Environment.NewLine, string.Join(", ", this.Projects));
        }

        #endregion
    }
}
