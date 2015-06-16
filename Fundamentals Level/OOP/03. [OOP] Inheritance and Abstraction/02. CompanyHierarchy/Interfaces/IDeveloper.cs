using System;
using System.Collections.Generic;
using Projects;

namespace Interfaces
{
    interface IDeveloper : IRegularEmployee
    {
        List<Project> Projects { get; set; }

        void AddProject(Project project);
    }
}
