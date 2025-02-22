using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Infrastructure;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class WorkerTableRepository : IWorkerTableRepository
    {
        private readonly ProjectDbContext dbContext;

        public WorkerTableRepository(ProjectDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<WorkerTable> GetAll()
        {
            return dbContext.WorkerTables.ToList();
        }

        public WorkerTable GetById(Guid _workerId)
        {
            return dbContext.WorkerTables.First<WorkerTable>(p => p.WorkerId == _workerId);
        }

        public WorkerTable CreateWorkerTable(WorkerTable _workerTable)
        {
            dbContext.WorkerTables.Add(_workerTable);
            dbContext.SaveChanges();

            return _workerTable;
        }

        public WorkerTable UpdateWorkerTable(WorkerTable _workerTable)
        {
            dbContext.WorkerTables.Update(_workerTable);
            dbContext.SaveChanges();

            return _workerTable;
        }

        public void deleteWorkerTable(Guid _workerId)
        {
            var worker = dbContext.WorkerTables.First<WorkerTable>(p => p.WorkerId == _workerId);
            if (worker != null)
            {
                dbContext.WorkerTables.Remove(worker);
                dbContext.SaveChanges();
            }
        }
    }
}
