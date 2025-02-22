using Microsoft.AspNetCore.Mvc;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Application;

namespace VueAppProjectManagement.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialTableController : Controller
    {
        private readonly IMaterialTableService materialTableService;

        public MaterialTableController(IMaterialTableService _materialTableService)
        {
            materialTableService = _materialTableService;
        }        

        [HttpGet]
        public ActionResult<List<MaterialTable>> Get() {
            var service = materialTableService.GetAll();
            if (service == null) {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("{MaterialId:guid}")]
        public IActionResult GetById(Guid MaterialId)
        {
            MaterialTable? material = null;
            try
            {
                material = materialTableService.GetById(MaterialId);
            }
            catch { }

            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }

        [HttpPost]
        public ActionResult<MaterialTable> post(MaterialTable _materialTable)
        {
            materialTableService.CreateMaterialTable(_materialTable);
            return Ok(_materialTable);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult<MaterialTable> UpdatePost(MaterialTable _materialTable)
        {
            materialTableService.UpdateMaterialTable(_materialTable);
            return Ok(_materialTable);
        }

        [HttpDelete]
        [Route("{MaterialId:guid}")]
        public ActionResult<MaterialTable> DeletePost(Guid MaterialId)
        {
            materialTableService.deleteMaterialTable(MaterialId);
            return Ok();
        }
    }
}
