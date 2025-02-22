using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Infrastructure;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class WorkingLineRepository : IWorkingLineRepository
    {
        private readonly ProjectDbContext dbContext;

        public WorkingLineRepository(ProjectDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<WorkingLine> GetAll()
        {
            return dbContext.WorkingLines.ToList();
        }
        public WorkingLine GetById(Guid _lineId)
        {
            return dbContext.WorkingLines.First<WorkingLine>(p => p.LineId == _lineId);
        }

        public WorkingLine CreateWorkingLine(WorkingLine _workingLine)
        {
            dbContext.WorkingLines.Add(_workingLine);
            dbContext.SaveChanges();

            return _workingLine;
        }

        public WorkingLine UpdateWorkingLine(WorkingLine _workingLine)
        {
            dbContext.WorkingLines.Update(_workingLine);
            dbContext.SaveChanges();

            return _workingLine;
        }

        public void deleteWorkingLine(Guid _lineId)
        {
            var line = dbContext.WorkingLines.First<WorkingLine>(p => p.LineId == _lineId);
            if (line != null)
            {
                dbContext.WorkingLines.Remove(line);
                dbContext.SaveChanges();
            }
        }
    }
}
