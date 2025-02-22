
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public class WorkingTableService : IWorkingTableService
    {
        private readonly IWorkingTableRepository workingTableRepository;

        public WorkingTableService(IWorkingTableRepository _workingTableRepository)
        {
            workingTableRepository = _workingTableRepository;
        }
        public List<WorkingTable> GetAll()
        {
            return workingTableRepository.GetAll();
        }
        public WorkingTable GetById(Guid _workingId)
        {
            return workingTableRepository.GetById(_workingId);
        }

        public WorkingTable CreateWorkingTable(WorkingTable _workingTable)
        {
            workingTableRepository.CreateWorkingTable(_workingTable);

            return _workingTable;
        }

        public WorkingTable UpdateWorkingTable(WorkingTable _workingTable)
        {
            workingTableRepository.UpdateWorkingTable(_workingTable);

            return _workingTable;
        }

        public void deleteWorkingTable(Guid _workingId)
        {
            workingTableRepository.deleteWorkingTable(_workingId);
        }
    }
}
