using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public interface IProjectTableService
    {
        List<ProjectTable> GetAll();

        ProjectTable GetById(Guid _projectId);

        ProjectTable CreateProjectTable(ProjectTable _projectTable);

        ProjectTable UpdateProjectTable(ProjectTable _projectTable);

        void deleteProjectTable(Guid _projectId);
    }
}
