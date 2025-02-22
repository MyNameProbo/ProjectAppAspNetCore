using VueAppProjectManagement.Project.Domain;
namespace VueAppProjectManagement.Project.Application
{
    public interface IWorkerTableService
    {
        List<WorkerTable> GetAll();

        WorkerTable GetById(Guid _workerlId);

        WorkerTable CreateWorkerTable(WorkerTable _workerTable);

        WorkerTable UpdateWorkerTable(WorkerTable _workerTable);

        void deleteWorkerTable(Guid _workerId);

    }
}
