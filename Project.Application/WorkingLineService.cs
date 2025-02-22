
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public class WorkingLineService : IWorkingLineService
    {
        private readonly IWorkingLineRepository workingLineRepository;

        public WorkingLineService(IWorkingLineRepository _workingLineRepository)
        {
            workingLineRepository = _workingLineRepository;
        }
        public List<WorkingLine> GetAll()
        {
            return workingLineRepository.GetAll();
        }

        public WorkingLine GetById(Guid _lineId)
        {
            return workingLineRepository.GetById(_lineId);
        }

        public WorkingLine CreateWorkingLine(WorkingLine _workingLine)
        {
            workingLineRepository.CreateWorkingLine(_workingLine);

            return _workingLine;
        }

        public WorkingLine UpdateWorkingLine(WorkingLine _workingLine)
        {
            workingLineRepository.UpdateWorkingLine(_workingLine);

            return _workingLine;
        }

        public void deleteWorkingLine(Guid _lineId)
        {
            workingLineRepository.deleteWorkingLine(_lineId);
        }
    }
}
