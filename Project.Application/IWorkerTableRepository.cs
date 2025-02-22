using VueAppProjectManagement.Project.Domain;
namespace VueAppProjectManagement.Project.Application
{
    public interface IWorkerTableRepository
    {
        List<WorkerTable> GetAll();
        WorkerTable GetById(Guid _workerId);
        WorkerTable CreateWorkerTable(WorkerTable _workerTable);

        WorkerTable UpdateWorkerTable(WorkerTable _workerTable);

        void deleteWorkerTable(Guid _workerId);

    }
}
