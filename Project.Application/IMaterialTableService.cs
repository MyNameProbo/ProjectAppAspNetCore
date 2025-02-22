using VueAppProjectManagement.Project.Domain;
namespace VueAppProjectManagement.Project.Application
{
    public interface IMaterialTableService
    {
        List<MaterialTable> GetAll();

        MaterialTable GetById(Guid _materialId);        

        MaterialTable CreateMaterialTable(MaterialTable _materialTable);

        MaterialTable UpdateMaterialTable(MaterialTable _materialTable);

        void deleteMaterialTable(Guid _materialId);

    }
}
