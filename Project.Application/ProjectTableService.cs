
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public class ProjectTableService : IProjectTableService
    {
        private readonly IProjectTableRepository projectTableRepository;

        public ProjectTableService(IProjectTableRepository _projectTableRepository)
        {
            projectTableRepository = _projectTableRepository;
        }
        public List<ProjectTable> GetAll()
        {
            return projectTableRepository.GetAll();
        }

        public ProjectTable GetById(Guid _projectId)
        {
            return projectTableRepository.GetById(_projectId);
        }

        public ProjectTable CreateProjectTable(ProjectTable projectTable)
        {
            projectTableRepository.CreateProjectTable(projectTable);

            return projectTable;
        }

        public ProjectTable UpdateProjectTable(ProjectTable projectTable)
        {
            projectTableRepository.UpdateProjectTable(projectTable);

            return projectTable;
        }

        public void deleteProjectTable(Guid _projectId)
        {
            projectTableRepository.deleteProjectTable(_projectId);
        }
    }
}
