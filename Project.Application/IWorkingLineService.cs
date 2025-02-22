using VueAppProjectManagement.Project.Domain;
namespace VueAppProjectManagement.Project.Application
{
    public interface IWorkingLineService
    {
        List<WorkingLine> GetAll();

        WorkingLine GetById(Guid _lineId);

        WorkingLine CreateWorkingLine(WorkingLine _workingTable);

        WorkingLine UpdateWorkingLine(WorkingLine _workingTable);

        void deleteWorkingLine(Guid _lineId);

    }
}
