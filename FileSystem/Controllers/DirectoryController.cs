using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileSystem.Core.Action;
using FileSystem.Core.Base;
using Microsoft.Extensions.Logging;

namespace FileSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectoryJob _directoryJob;
        private readonly ILogger<DirectoryController> _logger;

        public DirectoryController(IDirectoryJob directoryJob, ILogger<DirectoryController> logger)
        {
            _directoryJob = directoryJob;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AddDirectory(string name, Guid directoryId, string category, Guid parentDirectoryId)
        {
            return Ok(_directoryJob.AddDirectory(name, directoryId, category, parentDirectoryId));
        }

        [HttpDelete]
        public IActionResult DeleteDirectory(Guid directoryId)
        {
            return Ok(_directoryJob.DeleteDirectory(directoryId));
        }
    }
}
