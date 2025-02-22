using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Infrastructure;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class ProjectTableRepository : IProjectTableRepository
    {
        private readonly ProjectDbContext dbContext;

        public ProjectTableRepository(ProjectDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<ProjectTable> GetAll()
        {
            return dbContext.ProjectTables.ToList();
        }

        public ProjectTable GetById(Guid _projectId)
        {
            return dbContext.ProjectTables.First<ProjectTable>(p => p.ProjectId == _projectId);
        }

        public ProjectTable CreateProjectTable(ProjectTable projectTable)
        {
            dbContext.ProjectTables.Add(projectTable);
            dbContext.SaveChanges();

            return projectTable;
        }

        ProjectTable IProjectTableRepository.UpdateProjectTable(ProjectTable projectTable)
        {
            dbContext.ProjectTables.Update(projectTable);
            dbContext.SaveChanges();

            return projectTable;
        }

        void IProjectTableRepository.deleteProjectTable(Guid _projectId)
        {
            var project = dbContext.ProjectTables.First<ProjectTable>(p => p.ProjectId == _projectId);
            if (project != null)
            {
                dbContext.ProjectTables.Remove(project);
                dbContext.SaveChanges();
            }
        }
    }
}
