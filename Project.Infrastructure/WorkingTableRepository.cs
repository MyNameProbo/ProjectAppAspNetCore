using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Infrastructure;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class WorkingTableRepository : IWorkingTableRepository
    {
        private readonly ProjectDbContext dbContext;

        public WorkingTableRepository(ProjectDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<WorkingTable> GetAll()
        {
            return dbContext.WorkingTables.ToList();
        }

        public WorkingTable GetById(Guid _workingId)
        {
            return dbContext.WorkingTables.First<WorkingTable>(p => p.WorkingId == _workingId);
        }

        public WorkingTable CreateWorkingTable(WorkingTable _workingTable)
        {
            dbContext.WorkingTables.Add(_workingTable);
            dbContext.SaveChanges();

            return _workingTable;
        }

        public WorkingTable UpdateWorkingTable(WorkingTable _workingTable)
        {
            dbContext.WorkingTables.Update(_workingTable);
            dbContext.SaveChanges();

            return _workingTable;
        }

        public void deleteWorkingTable(Guid _workingId)
        {
            var working = dbContext.WorkingTables.First<WorkingTable>(p => p.WorkingId == _workingId);
            if (working != null)
            {
                dbContext.WorkingTables.Remove(working);
                dbContext.SaveChanges();
            }
        }
    }
}
