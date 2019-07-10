using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hopeline.Service.Interfaces;
using Hopeline.Service.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hopeline.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/rescomm")]
    [ApiController]
    public class ResCommController : ControllerBase
    {
        private readonly ICommonResourceService _commRes;
        public ResCommController(ICommonResourceService commRes)
        {
            _commRes = commRes;
        }
        [HttpGet("getalltopics")]
        public IActionResult getAllTopics()
        {
            return Ok(_commRes.getAllTopics());
        }

        [HttpGet("getallrescates")]
        public IActionResult getAllResCates()
        {
            return Ok(_commRes.getAllResourceCategories());
        }
        [HttpGet("getallres")]
        public IActionResult getAllRes()
        {
            return Ok(_commRes.getAllResources());
        }
        [HttpGet("getallcomms")]
        public IActionResult getAll()
        {
            return Ok(_commRes.getAllCommunities());
        }
    }
}