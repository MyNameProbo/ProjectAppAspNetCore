
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Application
{
    public class MaterialTableService : IMaterialTableService
    {
        private readonly IMaterialTableRepository materialTableRepository;

        public MaterialTableService(IMaterialTableRepository _materialTableRepository)
        {
            materialTableRepository = _materialTableRepository;
        }
        public List<MaterialTable> GetAll()
        {
            return materialTableRepository.GetAll();
        }

        public MaterialTable GetById(Guid _materialId)
        {
            return materialTableRepository.GetById(_materialId);
        }

        public MaterialTable CreateMaterialTable(MaterialTable _materialTable)
        {
            materialTableRepository.CreateMaterialTable(_materialTable);

            return _materialTable;
        }

        public MaterialTable UpdateMaterialTable(MaterialTable materialTable)
        {
            materialTableRepository.UpdateMaterialTable(materialTable);

            return materialTable;
        }

        public void deleteMaterialTable(Guid _materialId)
        {
            materialTableRepository.deleteMaterialTable(_materialId);
        }
    }
}
