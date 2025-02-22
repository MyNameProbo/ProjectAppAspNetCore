using VueAppProjectManagement.Project.Domain;
namespace VueAppProjectManagement.Project.Application
{
    public interface IWorkingTableService
    {
        List<WorkingTable> GetAll();

        WorkingTable GetById(Guid _workingId);

        WorkingTable CreateWorkingTable(WorkingTable _workingTable);

        WorkingTable UpdateWorkingTable(WorkingTable _workingTable);

        void deleteWorkingTable(Guid _workingId);

    }
}
