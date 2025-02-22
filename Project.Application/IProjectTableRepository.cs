using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public interface IProjectTableRepository
    {
        List<ProjectTable> GetAll();

        ProjectTable GetById(Guid _projectId);

        ProjectTable CreateProjectTable(ProjectTable _projectTable);

        ProjectTable UpdateProjectTable(ProjectTable _projectTable);

        void deleteProjectTable(Guid _projectId);

    }
}
