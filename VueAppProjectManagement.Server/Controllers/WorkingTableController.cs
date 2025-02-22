using Microsoft.AspNetCore.Mvc;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Application;

namespace VueAppProjectManagement.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkingTableController : Controller
    {
        private readonly IWorkingTableService workingTableService;

        public WorkingTableController(IWorkingTableService _workingTableService)
        {
            workingTableService = _workingTableService;
        }        

        [HttpGet]
        public ActionResult<List<WorkingTable>> Get() {
            var service = workingTableService.GetAll();
            if (service == null) {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("{WorkingId:guid}")]
        public IActionResult GetById(Guid WorkingId)
        {
            WorkingTable? working = null;
            try
            {
                working = workingTableService.GetById(WorkingId);
            }
            catch { }

            if (working == null)
            {
                return NotFound();
            }
            return Ok(working);
        }

        [HttpPost]
        public ActionResult<WorkingTable> post(WorkingTable _workingTable)
        {
            workingTableService.CreateWorkingTable(_workingTable);
            return Ok(_workingTable);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult<WorkingTable> UpdatePost(WorkingTable _workingTable)
        {
            workingTableService.UpdateWorkingTable(_workingTable);
            return Ok(_workingTable);
        }

        [HttpDelete]
        [Route("{WorkingId:guid}")]
        public ActionResult<WorkingTable> DeletePost(Guid WorkingId)
        {
            workingTableService.deleteWorkingTable(WorkingId);
            return Ok();
        }
    }
}
