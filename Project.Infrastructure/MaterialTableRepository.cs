using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Infrastructure;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class MaterialTableRepository : IMaterialTableRepository
    {
        private readonly ProjectDbContext dbContext;

        public MaterialTableRepository(ProjectDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<MaterialTable> GetAll()
        {
            return dbContext.MaterialTables.ToList();
        }

        public MaterialTable GetById(Guid _materialId)
        {
            return dbContext.MaterialTables.First<MaterialTable>(m=>m.MaterialId==_materialId);
        }

        public MaterialTable CreateMaterialTable(MaterialTable _materialTable)
        {
            dbContext.MaterialTables.Add(_materialTable);
            dbContext.SaveChanges();

            return _materialTable;
        }

        public MaterialTable UpdateMaterialTable(MaterialTable _materialTable)
        {
            dbContext.MaterialTables.Update(_materialTable);
            dbContext.SaveChanges();

            return _materialTable;
        }

        public void deleteMaterialTable(Guid _materialId)
        {
            var material = dbContext.MaterialTables.First<MaterialTable>(p => p.MaterialId == _materialId);
            if (material != null)
            {
                dbContext.MaterialTables.Remove(material);
                dbContext.SaveChanges();
            }
        }
    }
}
