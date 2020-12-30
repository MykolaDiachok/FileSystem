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
    public class FileSystemController : ControllerBase
    {
        private readonly IFileSystemJob _fileSystemJob;
        private readonly ILogger<FileSystemController> _logger;

        public FileSystemController(IFileSystemJob fileSystemJob, ILogger<FileSystemController> logger)
        {
            _fileSystemJob = fileSystemJob;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ShowAll()
        {
            return Ok(_fileSystemJob.ShowAll());
        }
    }
}
