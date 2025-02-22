
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public class WorkerTableService : IWorkerTableService
    {
        private readonly IWorkerTableRepository workerTableRepository;

        public WorkerTableService(IWorkerTableRepository _worktableRepository)
        {
            workerTableRepository = _worktableRepository;
        }
        public List<WorkerTable> GetAll()
        {
            return workerTableRepository.GetAll();
        }

        public WorkerTable GetById(Guid _workerId)
        {
            return workerTableRepository.GetById(_workerId);
        }

        public WorkerTable CreateWorkerTable(WorkerTable workerTable)
        {
            workerTableRepository.CreateWorkerTable(workerTable);

            return workerTable;
        }

        public WorkerTable UpdateWorkerTable(WorkerTable workerTable)
        {
            workerTableRepository.UpdateWorkerTable(workerTable);

            return workerTable;
        }

        public void deleteWorkerTable(Guid _workerId)
        {
            workerTableRepository.deleteWorkerTable(_workerId);
        }
    }
}
