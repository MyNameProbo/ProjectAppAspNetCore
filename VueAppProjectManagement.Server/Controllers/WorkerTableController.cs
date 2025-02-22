using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Domain;

namespace VueAppworkerManagement.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerTableController : Controller
    {
        private readonly IWorkerTableService workerTableService;

        public WorkerTableController(IWorkerTableService _workerTableService)
        {
            workerTableService = _workerTableService;
        }        

        [HttpGet]
        public ActionResult<List<WorkerTable>> Get() {
            var service = workerTableService.GetAll();
            if (service == null) {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("{WorkerId:guid}")]
        public IActionResult GetById(Guid WorkerId)
        {
            WorkerTable? worker = null;

            try
            {
                worker = workerTableService.GetById(WorkerId);
            }
            catch { }

            if (worker == null)
            {
                return NotFound();
            }
            return Ok(worker);
        }

        [HttpPost]
        public ActionResult<WorkerTable> post(WorkerTable _workerTable)
        {
            workerTableService.CreateWorkerTable(_workerTable);
            return Ok(_workerTable);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult<WorkerTable> UpdatePost(WorkerTable _workerTable)
        {
            workerTableService.UpdateWorkerTable(_workerTable);
            return Ok(_workerTable);
        }

        [HttpDelete]
        [Route("{WorkerId:guid}")]
        public ActionResult<WorkerTable> DeletePost(Guid WorkerId)
        {
            workerTableService.deleteWorkerTable(WorkerId);
            return Ok();
        }
    }
}
