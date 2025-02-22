using Microsoft.AspNetCore.Mvc;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Application;

namespace VueAppProjectManagement.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkingLineController : Controller
    {
        private readonly IWorkingLineService workingLineService;

        public WorkingLineController(IWorkingLineService _workingLineService)
        {
            workingLineService = _workingLineService;
        }        

        [HttpGet]
        public ActionResult<List<WorkingLine>> Get() {
            var service = workingLineService.GetAll();
            if (service == null) {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("{LineId:guid}")]
        public IActionResult GetById(Guid LineId)
        {
            WorkingLine? line = null;

            try
            {
                line = workingLineService.GetById(LineId);
            }
            catch { }

            if (line == null)
            {
                return NotFound();
            }
            return Ok(line);
        }

        [HttpPost]
        public ActionResult<WorkingLine> post(WorkingLine _workingLine)
        {
            workingLineService.CreateWorkingLine(_workingLine);
            return Ok(_workingLine);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult<WorkingLine> UpdatePost(WorkingLine _workingLine)
        {
            workingLineService.UpdateWorkingLine(_workingLine);
            return Ok(_workingLine);
        }

        [HttpDelete]
        [Route("{LineId:guid}")]
        public ActionResult<WorkingLine> DeletePost(Guid LineId)
        {
            workingLineService.deleteWorkingLine(LineId);
            return Ok();
        }
    }
}
