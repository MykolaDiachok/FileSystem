using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileSystem.Core.Action;
using Microsoft.Extensions.Logging;

namespace FileSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileJob _fileJob;
        private readonly ILogger<FileController> _logger;

        public FileController(IFileJob fileJob, ILogger<FileController> logger)
        {
            _fileJob = fileJob;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AddFile(string name, Guid fileId, string category, Guid parentDirectoryId)
        {
            return Ok(_fileJob.AddFile(name, fileId, category, parentDirectoryId));
        }

        [HttpDelete]
        public IActionResult DeleteFile(Guid fileId)
        {
            return Ok(_fileJob.DeleteFile(fileId));
        }
    }
}
