using Microsoft.AspNetCore.Mvc;
using VueAppProjectManagement.Project.Domain;
using VueAppProjectManagement.Project.Application;
using Microsoft.EntityFrameworkCore;

namespace VueAppProjectManagement.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectTableController : Controller
    {
        private readonly IProjectTableService projectTableService;

        public ProjectTableController(IProjectTableService _projectTableService)
        {
            projectTableService = _projectTableService;
        }        

        [HttpGet]
        public ActionResult<List<ProjectTable>> Get() {
            var service = projectTableService.GetAll();
            if (service == null) {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("{ProjectId:guid}")]
        public IActionResult GetById(Guid _projectId)
        {
            ProjectTable? project = null;

            try
            {
                project = projectTableService.GetById(_projectId);
            }
            catch { }

            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        public ActionResult<ProjectTable> post(ProjectTable _projectTable)
        {
            projectTableService.CreateProjectTable(_projectTable);
            return Ok(_projectTable);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult<ProjectTable> UpdatePost(ProjectTable _projectTable)
        {
            projectTableService.UpdateProjectTable(_projectTable);
            return Ok(_projectTable);
        }

        [HttpDelete]
        [Route("{ProjectId:guid}")]
        public ActionResult<ProjectTable> DeletePost(Guid ProjectId)
        {
            projectTableService.deleteProjectTable(ProjectId);
            return Ok("Delete Success");
        }
    }
}
